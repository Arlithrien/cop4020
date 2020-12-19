library("rjson")


# create an empty dataframe
df <- data.frame(matrix(ncol=5, nrow=0))

# with type information for each column based on the input file
colnames(df) <- c("reviewerID",
                  "asin",
                  "reviewText",
                  "overall",
                  "reviewTime")


# open the input file and return "con"
fileName <- "review.data"
con <- file(fileName,open="r")

# read in entire file
lines <-readLines(con)


for (i in 1:length(lines)){
  
    # load lines into an R object
    review <- fromJSON(lines[i])
    
    # convert R object into a dataframe
    reviewdf <- as.data.frame(review)
    
    # combine "reviewdf" with "df
    df<- rbind(df, reviewdf)
}

# extract reviews whose value is >= 4.0
df4plus = df[df[, "overall"] >= 4,]

View(df)
View(df4plus)

# print the original dataframe, and one with reviews >= 4 to a file.
write.csv(df, file="reviews.csv")
write.csv(df4plus, file="reviews_4plus.csv")


# close the open file "con"
close(con)


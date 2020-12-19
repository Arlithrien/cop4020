library("rjson")
library("stringr")

# create an empty dataframe
df <- data.frame(matrix(ncol=5, nrow=0))

# type of information in each column based on the input file
colnames(df) <- c("reviewerID",
                  "asin",
                  "reviewText",
                  "overall",
                  "reviewTime")

# open the input file
fileName <- "review.data"
con <- file(fileName, open="r")

# read entire file
lines = readLines(con)

# iterate through all lines
for (i in 1:length(lines)){
  
  # load lines into an R object
  review <- fromJSON(lines[i])
  
  # convert R object into a dataframe
  reviewdf = as.data.frame(review)
  
  # combine "reviewdf" with "df"
  df <- rbind(df, reviewdf)
}
# count number of words in a string
nwords <- function(string, pseudo=F){
  ifelse( pseudo, 
          pattern <- "\\S+", 
          pattern <- "[[:alpha:]]+" 
  )
  str_count(string, pattern)
}

# add a new column to df called numOfWords, containing reviewText column's str count
df$numOfWords <- nwords(df[, "reviewText"])

# declare x and y vectors used as boxplot x and y planes
x = c()
y = c()

# create dataframe for overalls 1-5 and then prints the mean numOfWords value
for(i in 1:5){
  dfbuff <- df[df[, "overall"] == i,]
  avg <- mean(dfbuff$numOfWords, na.rm=T)
  print(avg)
  x[i] = i
  y[i] = avg
}  

# create barplot where x is the overall rating and y is the avg # of words
barplot(y,names.arg=x, xlab = "Overall Rating", ylab="Average Word Count", col="Red")

View(df)



close(con)
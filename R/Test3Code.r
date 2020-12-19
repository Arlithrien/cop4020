library(rjson)
library(stringr)

cherry <- read.csv("cherry.csv")
future <- read.csv("Future-500.csv")
test <- read.csv("test3data.csv")



intrev <- test$Revenue.asNumeric
rev <- median(test$Revenue)
print(rev)

exp <- mean(test$Expenses, na.rm=T)
#revenue <- test
test <- test[-c(321, 342)]
test[130, 3] <- "Mississippi"
test[156, 3] <- "Wyoming"
test[199, 3] <- "California"


#gsub("", mean())
temp <- test[test[,"Month"] == 6,]
temp <- mean(temp$Profit, na.rm=T)



barplot(cherry$Volume, names.arg=cherry$Height, xlab="Height", ylab="Volume", col="red", main="Barchart of Cherry.csv")
spread <- range(cherry$Volume, na.rm=T)
middle <- median(cherry$Volume, na.rm=T)

#symmetry - skewed left, unimodal
#middle - 24.2
#spread - 77.0 - 10.2 = 66.8
#unusual features - height of 87 has an absolute maximum of 77, absolute minimum is height 70 and 71
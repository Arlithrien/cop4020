library(jsonlite)

cycler1 <- read.csv("cyclerCPK.csv")
load(cycler1)
plot(cycler1$CPK, rep(0,length(cycler1$CPK1)))
Q()
hist(cycler1$CPK1)
points(cyler1$CPK1, rep(0, length(cycler1$CPK1)))
source("tuesday.R")
temp <- hist(cycler1$CPK1, xlab="CPK1", main="Histogram of CPK1", col="orange")
names(temp)
source("tuesday.R")
score1 <- read.csv("Testing1.csv")
head(score1)
hist(score1$Grade5, col="red", xlab="Score", xlim=c(0,1))
hist(score1$Grade7, add=TRUE, col="blue")
hist(score1$Grade10, add=TRUE, col="green")
source(tuesday.R)
#//////////////////////////////////////////////

score2 <- read.csv("Testing2.csv")
head(score2)
hist(score2$Grade6, main="Grade6", xlab="Score")
hist(score2$grade8, main="Grade8", xlab="Score")
hist(score2$grade11, main="Grade11", xlab="Score")
stem(cycler1$CPK1)
#/////////////////////////////////////////
boxplot(cycler1$CPK1)
source("tuesday.R")

cpk1 <- cycler1[, C(1,2,3,4,5)]
cpk2 <- cycler1[, C(1,2,3,4,6)]
cpk3 <- cycler1[, C(1,2,3,4,7)]
cpk4 <- cycler1[, C(1,2,3,4,8)]


boxplot(cpkstack$CPK - cpkstack$TRT)


















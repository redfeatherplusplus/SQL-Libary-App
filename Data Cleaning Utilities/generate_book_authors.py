# Author: Daren Cheng
# Class: CS 6350
# Date: 9/27/2016
# 
# Desc: Generates book_authors.csv from the normalized books.csv and generated authors.csv

import re

# defined constants
derived_table_name = "book_authors.csv"
ISBN10 = 0
ISBN13 = 1
Title = 2
Author = 3
Cover = 4
Publisher = 5
Pages = 6

Author_id = 0
Name = 1

authors_lowercase = []
book_author_tuples = []

def main(books_path, authors_path): 
	# read authors from authors file
	file = open(authors_path, "r")
	author_tuples = file.readlines()
	file.close()
	
	for author in author_tuples[1:]:
		author = author.split("	")
		authors_lowercase.insert(int(author[Author_id]), author[Name].lower()[:-1])
		
		# note: I use [:-1] to clip the leading "\n"
	
	# read lines from the books file
	file = open(books_path, "r")
	lines = file.readlines()
	file.close()
	
	# derive the appropriate tuples from each line
	book_authors_path = "\\".join(books_path.split("\\")[:-1]) + "\\" + derived_table_name
	file = open(book_authors_path, "w")
	
	column_headers = "	".join(["Author_id", "Isbn"]) + "\n"
	file.write(column_headers)
	
	for line in lines[1:]:
		write_derived_tuples(file, line)
	file.close()

def write_derived_tuples(file, line):
	books_tuple = line.split("	")
	book_authors = re.split(", |; |,|;", books_tuple[Author])
	book_isbn = books_tuple[ISBN13]
	for book_author in book_authors:
		book_author_tuple = "	".join([str(authors_lowercase.index(book_author.lower()) + 1), books_tuple[ISBN13][:-3]]) + "\n"
		if book_author_tuple not in book_author_tuples:
			file.write(book_author_tuple)
			book_author_tuples.append(book_author_tuple)
		
		# note: I add '1' to the index as authors has no header

if __name__ == '__main__':
	main("C:\\Users\\Cheng\\Downloads\\books_03.csv", "C:\\Users\\Cheng\\Downloads\\authors.csv")
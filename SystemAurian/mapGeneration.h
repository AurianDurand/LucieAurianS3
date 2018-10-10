#ifndef MAPGENERATION_H
#define MAPGENERATION_H

int askForSize();
void createMap(int TABSIZE, char** map);
void printMap(int TABSIZE, char** map);
void print2Maps(int TABSIZE, char** map1, char** map2);

#endif
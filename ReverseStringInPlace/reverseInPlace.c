#include <stdio.h>
#include <string.h>

void reverse_string(char* original) {
  int length = strlen(original);
  for (int i = 0; i < length / 2; i++) {
    char tmp = original[i];
    original[i] = original[length - 1 - i];
    original[length - 1 - i] = tmp;
  }
}

int main(void) {
  char foo[10] = "itest";
  printf("testing: %s\n", foo);
  reverse_string(foo);
  printf("%s\n", foo);
  return 0;
}

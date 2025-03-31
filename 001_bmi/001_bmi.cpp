#include <stdio.h>

int main() {
	//키와체중을 입력받아서, bmi를 계산하고, 출력
	double h; // 키
	double w; // 체중


	printf("키(cm) : ");
	scanf_s("%lf", &h);

	printf("체중(kg) : ");
	scanf_s("%lf", &w);

	h /= 100;

	double bmi = w/(h * h);
	printf("bmi = %lf\n", bmi);

}
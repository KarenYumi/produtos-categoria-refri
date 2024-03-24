#include <stdio.h>
int main(){

float p_unitario, final_ =0, impost=0, esto=0;
char refri, categoria, resposta;

do{
printf("Digite o valor do produto: R$");
scanf("%f", &p_unitario);

if(p_unitario <=20.00){

    printf("Digite a categoria (A-alimento, L-limpeza ou V-vestuario: ");
    scanf(" %c", &categoria);
    categoria = toupper(categoria);
    printf("Nao possue refrigeracao!\n");

    if(categoria == 'A'){
        impost = p_unitario * 0.02;
        esto = 5.00;
        final_ = esto + p_unitario + (impost);
    }
    if(categoria == 'L'){
        impost = p_unitario * 0.02;
        esto = 10.00;
        final_ = esto +p_unitario + impost;
    }
    else{
        impost = p_unitario * 0.02;
        esto = 15.00;
        final_ = esto +p_unitario + impost;
    }
}

if(p_unitario > 20.00 && p_unitario <= 50.00){
    printf("Digite a refrigeracao (S se necessitam, caso contrario N): ");
    scanf(" %c", &refri);
    refri = toupper(refri);
    printf("Nao possue categoria!\n");

    if(refri == 'S'){
        impost = p_unitario * 0.02;
        esto = 21.00;
        final_ = esto + p_unitario + (impost);
    }
    else{
        impost = p_unitario * 0.02;
        esto = 0.00;
        final_ = esto +p_unitario + impost;
    }
}

if(p_unitario > 50.00){
    printf("Digite a refrigeracao (S se necessitam, caso contrario N): ");
    scanf(" %c", &refri);
    refri = toupper(refri);
    printf("Digite a categoria (A-alimento, L-limpeza ou V-vestuario: ");
    scanf(" %c", &categoria);
    categoria = toupper(categoria);

    if(refri == 'S'){
            if(categoria =='A'){
                impost = p_unitario * 0.04;
                esto = 6.00;
                final_ = esto + p_unitario + (impost);
            }
            if(categoria =='L'){
                impost = p_unitario * 0.02;
                esto = 2.00;
                final_ = esto + p_unitario + (impost);
            }
            else{
                impost = p_unitario * 0.02;
                esto = 4.00;
                final_ = esto + p_unitario + (impost);
            }
        }
    if(refri == 'N'){
            if(categoria =='A' || categoria =='V'){
                impost = p_unitario * 0.02;
                esto = 0.00;
                final_ = esto + p_unitario + (impost);
            }
            else{
                impost = p_unitario * 0.02;
                esto = 1.00;
                final_ = esto + p_unitario + (impost);
            }
        }
}


printf("\nPreco do unitario: %.2f", p_unitario);
printf("\nPreco de estocagem: %.2f", esto);
printf("\nPreco do imposto: %.2f", impost);
printf("\nTotal: %.2f", final_);

printf("\n..................................................\n\n");

printf("Deseja continuar colocando mais produtos?");
scanf(" %c", &resposta);
resposta = toupper(resposta);

printf("\n..................................................\n\n");


}
while(resposta == 'S');

return 0;
}


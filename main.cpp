#include<bits/stdc++.h>
#include<windows.h>
using namespace std;
void display();
void Employee();
const int Max_size=100;
void SetColor(int ForgC)
{
     WORD wColor;
     HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
     CONSOLE_SCREEN_BUFFER_INFO csbi;
     if(GetConsoleScreenBufferInfo(hStdOut, &csbi))
     {
          wColor = (csbi.wAttributes & 0xF0) + (ForgC & 0x0F);
          SetConsoleTextAttribute(hStdOut, wColor);
     }
     return;
}
class Node{
public:
    string data;
    Node* next;
};
class LinkedList {
    Node *head;

public:
    LinkedList() {
        head = NULL;
    }
    bool isEmpty() {
        return head == NULL;
    }
    void addNode(string data) {
        Node *newNode = new Node();
        newNode->data = data;
        newNode->next = NULL;
        if (isEmpty()) {
            head = newNode;
        } else {
            Node *temp = head;
            while (temp->next != NULL) {
                temp = temp->next;
            }
            temp->next = newNode;
        }
    }
    bool search(string item) {
        if (isEmpty()) {
            return false;
        } else {
            Node *temp = head;
            while (temp != NULL) {
                if (temp->data == item) {
                    return true;
                }
                temp = temp->next;
            }
            return false;
        }
    }
    void deleteNode(string item) {
        if(search(item)){
            Node *temp = head;
            Node *prev = NULL;
            while (temp != NULL) {
                if (temp->data == item) {
                    break;
                }
                prev = temp;
                temp = temp->next;
            }
            if (prev == NULL) {
                head = temp->next;
                delete temp;
            } else {
                prev->next = temp->next;
                delete temp;
            }
        } else {
            cout << "Item not found" << endl;
        }

    }
    void displaylinked() {
        if (isEmpty()) {
            cout << "List is empty" << endl;
        } else {
            Node *temp = head;
            while (temp != NULL) {
                cout << temp->data << endl;
                temp = temp->next;
            }
        }
    }
    string getFront() {
        if (isEmpty()) {
            return "List is empty";
        } else {
            return head->data;
        }
    }
};
LinkedList list1;
class feature{
    pair<int,string> arr[Max_size];
    int size;
public:
    feature(){
        size=0;
    }
    bool isempty(){return size==0;}
    bool isfull(){return size==Max_size;}

    void addcustomer(string ssn){
        if(isfull())
        {
            cout<<"5las shatbna"<<endl;
            return;
        }
        int i;
        int processes=0;
        for(i=size-1;i>=0;i--){
            if(arr[i].first>processes)
                arr[i+1]=arr[i];
            else{
                break;
            }
        }
        arr[i+1].first=processes;
        arr[i+1].second=ssn;
        ++size;
    }
    void addprocess(string ssn){
        bool check= false;
        if(isempty()){
            cout<<"There is no users"<<endl;
            return;
        }
        for(int i=0;i<size;i++){
            if(arr[i].second==ssn){
                arr[i].first++;
                check=true;
            }
        }
        if(!check){cout<<"No users with this ssn"<<endl;return;}
        pair<int,string > swap;
        for (int j = 0; j < size - 1; j++) { // Outer loop for multiple passes
            for (int i = 0; i < size - 1 - j; i++) { // Inner loop for one pass
                if (arr[i].first > arr[i+1].first) {
                    swap = arr[i+1];
                    arr[i+1] = arr[i];
                    arr[i] = swap;
                }
            }
        }

        //cout<<"hello"<<endl;
    }
    bool getTop(string ssn){
        if(isempty()){
            cout<<"NO users "<<endl;
            return false;
        }
        if(ssn == arr[size-1].second && arr[size-1].first>0){
            return true;
        }
        else{
            return false;
        }
    }
};
class Transactions{
    int last_transactions;
    string transactions[Max_size];
public:
    Transactions(){
        last_transactions=-1;
    }
    void add_Transaction(string e){
        if(last_transactions<Max_size-1){
            last_transactions++;
            transactions[last_transactions]=e;
        }
        else{
            cout<<"you can not add transactions";
        }
    }
    bool is_Empty(){
        if(last_transactions==-1){
            return true;
        }
        else{
            return false;
        }
    }
    string get_LastTransaction(){
        if(is_Empty()){
            cout<<"there is no transactions";
        }
        else{
            return transactions[last_transactions];
        }
    }
    void Delete_Transaction(){
        if(is_Empty()){
            cout<<"there is no transactions to delete ";
        }
        else {
            last_transactions--;
        }
    }
};
class  ManagingCustomers{
    int front;
    int rear;
    string q[Max_size];
public:
    ManagingCustomers(){
        front=-1;
        rear=-1;
    }

    void addCustomer(string e){
        if((rear+1)%Max_size==front){
            cout<<"Queue is full";
        }
        else if(front==-1 && rear==-1){
            front=0;
            rear=0;
            q[rear]=e;
        }
        else{
            rear=(rear+1)%Max_size;
            q[rear]=e;
        }
    }
    bool is_Empty(){
        if(front==-1 && rear==-1){
            return true;
        }
        else{
            return false;
        }
    }
    string get_front(){
        if(is_Empty()){
            cout<<"Queue is empty";
        }
        else{
            return q[front];
        }
    }
    void AcceptCustomer(){
        if(is_Empty()){
            cout<<"Queue is empty";
        }
        else if(front==rear){
            front=-1;
            rear=-1;
        }
        else{
            front=(front+1)%Max_size;
        }
    }
    void Showlist(){
        if(is_Empty()){
            cout<<"Queue is empty";
        }
        else{
            int j=1;
            for(int i=front;i!=rear;i=(i+1)%Max_size){
                cout<<j<<"-"<<q[i]<<endl;
                j++;
            }
            cout<<j<<"-"<<q[rear];
        }
    }

};

Transactions st;
ManagingCustomers queue1;
feature f1;

void showlistqueue()
{
    cout<<"-----------------------------------------------------"<<endl;
    queue1.Showlist();
    cout<<endl<<"-----------------------------------------------------"<<endl;
}
void showpendinglist () {
    if(!queue1.is_Empty()){
        list:
        {
            if(!queue1.is_Empty()){
                cout << "this is the pending list" << endl;
                showlistqueue();
                cout << "if you want to accept the first user click 1" << endl;
                int choice;
                cin >> choice;
                if (choice == 1) {
                    list1.addNode(queue1.get_front());
                    queue1.AcceptCustomer();
                    if (queue1.is_Empty()) {
                        cout << "the list is empty" << endl;
                        display();
                    } else {
                        SetColor(82);
                        cout << "User has accepted\n\n" << endl;
                        SetColor(7);
                        goto list;
                    }
                }
                else {
                    SetColor(196); //red
                    printf("\nList Is Empty\n \n");
                    SetColor(7);
                    Employee();
                }
            }
        }
    }
    else{
        SetColor(196);
        cout<<"The Queue Is Empty";
        SetColor(7);
    }

}
void showcustomerlist(){

   top:{

    cout<<"-----------------------------------------------------"<<endl;
    list1.displaylinked();
    cout<<endl<<"-----------------------------------------------------"<<endl;
    cout<<"if you want to back to the main menu choose 1"<<endl;
    cout<<"if you want to delete item choose 2"<<endl;
    int choice ;
    cin>>choice;
    cin.ignore();
    if(choice==1)
    {
        display();
    }
    else if(choice==2)
    {
        cout<<"Enter the item you want to delete"<<endl;
        string item;
        getline(cin, item);
       if(list1.search(item)){
         list1.deleteNode(item);
         SetColor(82);
         cout<<"\n \n Customer  has successfully deleted\n\n"<<endl;
          SetColor(7);
            goto top;
       }
       else
       {
           SetColor(196);
           cout<<"\n User Not Found !\n";
            SetColor(7);
           goto top;
       }

    }
    else
    {
        SetColor(196); //red
        printf("\nInvalid Input!\nPlease try again\n \n");
        SetColor(7);
        Employee();
    }
}
}

void premium_process(){
    cout<<"Enter your ssn"<<endl;
    string ssn;
    cin>>ssn;
    if(f1.getTop(ssn)){
        cout<<"OK you can access to the premium processes"<<endl;
        cout<<"if you want to take a loan enter 1"<<endl;
        cout<<"if you want to make a premium account with more features enter 2"<<endl;
        int fe;
        cin>>fe;
        cout<<"DONE"<<endl;
        cout<<"Thanks for using our premium features"<<endl;
        display();
    }
    else{
        cout<<"You are not allow to use this premium features"<<endl;
        display();
    }
}
void normal_process(){
    bool keeprunning = true;
    while (keeprunning) {
        cout << "if you want to deposite click 1" << endl;
        cout << "if you want to withdrawl click 2" << endl;
        cout << "if you want to know your last process click 3" << endl;
        cout << "if you want to know the process before the last process click 4" << endl;
        cout<<"if you want to exit click 5"<<endl;
        int y;
        cin >> y;
        if(y==1 || y==2 ){
            cout<<"Enter your ssn"<<endl;
            string ssn;
            cin>>ssn;
            f1.addprocess(ssn);
        }
        if (y == 1) {
            cout << "Enter the amount" << endl;
            string s;
            cin >> s;
            st.add_Transaction("deposite " + s);
        } else if (y == 2) {
            cout << "Enter the amount" << endl;
            string s;
            cin >> s;
            st.add_Transaction("withdrawl " + s);
        } else if (y == 3) {
            cout << st.get_LastTransaction();
        } else if (y == 4) {
            st.Delete_Transaction();
            cout << st.get_LastTransaction();
        }
        else if(y==5){
            display();
        }
        cout<<endl;
        cout<<endl;
    }
}

void Employee()
{

    cout<<"Please enter your Job number"<<endl;
    int jnumber;
    cin>>jnumber;
    if(jnumber==11576||jnumber==17105||jnumber==98755) {
        cout<<"if you want to show the pending list click 1"<<endl;
        cout<<"if you want to show the list of our users click 2"<<endl;
        int choice;
        cin>>choice;
        if(choice==1)
        {
            showpendinglist();
        }
        else if(choice==2)
        {
            if(!list1.isEmpty()){
                showcustomerlist();
            }
            else {
                cout<<"\n\n List is Empty\n";
            }
        }
        else
        {
                SetColor(196); //red
                printf("\nInvalid Input!\nPlease try again\n \n");
                SetColor(7);
            Employee();
        }
    }

    else
    {
        SetColor(196); //red
        printf("\nInvalid Input!\nPlease try again\n \n");
        SetColor(7);
        Employee();
    }
}
void display()
{
    st.add_Transaction("withdrawl 100");
    st.add_Transaction("deposite 1000");
    st.add_Transaction("withdrawl 300");
    cout<<" Menu : \n";
    cout<<"if you a new user click 1"<<endl;
    cout<<"if you an old user click 2 "<<endl;
    cout<<"if you an employee click 3"<<endl;
    int x;
    cin >> x;
    cin.ignore();
    if(x==1){
        cout << "Please Enter your name:";
        string name;
        getline(cin, name);
        cout << "Please Enter your SSN:";
        string ssn;
        cin >> ssn;
        string newuser = "Full name: " + name + "  " + "SSN: " + ssn;

        queue1.addCustomer(newuser);
        f1.addcustomer(ssn);
        SetColor(82);
        cout<<"\n\n Customer has been added to the Queue Successfully !\n\n";
        SetColor(7);
        cout<<"if you want to back to the main menu choose 1"<<endl;
        cout<<"if you want to exit choose 2"<<endl;
        int choice ;
        cin>>choice;
        if(choice==1)
        {
            display();
        }
        else if(choice==2)
        {
            return;
        }
        else
        {
            SetColor(196); //red
            printf("\nInvalid Input!\nPlease try again\n \n");
            SetColor(7);
            display();
        }
    }
    else if(x==2) {
        cout<<"if you want to make a normal process enter 1"<<endl;
        cout<<"if you want to make a premium process enter 2"<<endl;
        int ch;
        cin>>ch;
        if(ch==1){
            normal_process();
        }
        if(ch==2){
            premium_process();
        }
        else{
            SetColor(196);
            cout<<"\n\nWrong number\n\n"<<endl;
            SetColor(7);
            display();
        }
    }
    else if(x==3){
        Employee();
    }
}
int main() {
    //system("color B0");
    display();
    return 0;
}

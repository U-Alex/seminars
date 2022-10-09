

int[] array = new int[24];
string[] jrn = new string[]{"11-13", "10-14", "9-10", "11-22", "18-18", "0-23", "4-5", "4-5", "4-5"};

void printArray(int[] array) {
    for (int ind=0; ind < array.Length; ind++) {Console.Write(array[ind] + "  ");}
    Console.Write("\n");
}
int find_max(int[] array) {
    int max = array[0];
    for (int i=1; i < array.Length; i++) {
        if (array[i] > max) max = array[i];
    }
    return max;
}
void printResult(List<string> result){
    foreach (string i in result) {
        Console.Write(i + " ");
    }
}
List<string> selectTime(int[] array) {
    int max = find_max(array);
    int index = 0;
    int time_st = 0;
    int time_end = 0;
    bool st = false;
    List<string> result = new List<string>();
    while (index < array.Length) {
        if (array[index] == max) {
            if (!st) {//начало интервала
                st = true;
                time_st = index;
                time_end = index;
            }
            else {//продолжение интервала
                time_end = index;
            }
        }
        else {
            if (st) {//конец интервала
                result.Add(time_st.ToString() + "-" + time_end.ToString());
            }
            st = false;
        }
        index++;
    }   
    if (st) {//конец интервала, если max в конце array
        result.Add(time_st.ToString() + "-" + time_end.ToString());
    }
    return result;
}

/// start
for (int ind=0; ind < jrn.Length; ind++) {
    string[] time = jrn[ind].Split('-');
    int t_st = int.Parse(time[0]);
    int t_end = int.Parse(time[1]);
    int t_len = t_end - t_st + 1;
    for (int x = 0; x < t_len; x++) {
        array[t_st+x]++;
    }
}
printArray(array);
List<string> result = selectTime(array);
printResult(result);




















/*
int max = find_max(array);
int index = 0;
int time_st = 0;
int time_end = 0;
bool st = false;
List<string> result = new List<string>();

while (index < array.Length) {
    if (array[index] == max) {
        if (!st) { 
            st = true;
            time_st = index;
            time_end = index;
        }
        else {
            time_end = index;
        }
    }
    else {
        if (st) {
            result.Add(time_st.ToString() + "-" + time_end.ToString());
        }
        st = false;
    }
    index++;
}

printResult(result);
*/
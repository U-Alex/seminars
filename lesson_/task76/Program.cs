Console.Clear();

List<int> CreateNumList(int st, int end) {
    List<int> nums = new List<int>();
    for (int i = st; i < end; i++) nums.Add(i);
    return nums;
}

List<List<int>> GroupsNumbers(int num) {
    List<List<int>> grps = new List<List<int>>();
    grps.Add(new List<int>(){1});
    List<int> numList = CreateNumList(2, num);
    
    while (numList.Count != 0) {
        List<int> grp = numList.ToList();
        for (int i = 0; i < grp.Count; i++) {
            grp.RemoveAll(num => num != grp[i] && num % grp[i] == 0);
        }
        grps.Add(grp);
        numList.RemoveAll(num => grp.Contains(num));
    }
    return grps;
}

List<List<int>> res = GroupsNumbers(50);

foreach (List<int> ob in res) {
    foreach (int ob2 in ob) {
        Console.Write($"{ob2} ");
    }
    Console.WriteLine();
}


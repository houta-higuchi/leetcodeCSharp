function listToNum(list, c) {
    if (c == list.length) return 0;
        let num = 1;
        for(let i = 0; i < list.length - c -1; i++) {
            num *= 2;
        }
        num *= list[c];
        return listToNum(list, c+1) + num;
}


console.log(listToNum([1, 0, 0], 0));



function minimumSwaps(arr) {
  let minimumSwap = 0;
  let sortedArr = [];
  // hash table
  let HashTB = {};
  for (let i = 0; i < arr.length; i++) {
    HashTB[arr[i]] = i;
    sortedArr[arr[i] - 1] = arr[i];
  }
  sortedArr = sortedArr.filter(Number)
  for (let i = 0; i < arr.length; i++) {
    let targetVL = sortedArr[i];
    let currentVL = arr[i];

    if (currentVL != targetVL) {
      let j = HashTB[targetVL];
      arr[j] = currentVL;
      arr[i] = targetVL;
      HashTB[currentVL] = j;
      HashTB[targetVL] = i;
      minimumSwap++;
    }
  }
  return minimumSwap;
}

let arr = [1, 3, 5, 2, 4, 6, 8];

minimumSwaps(arr);
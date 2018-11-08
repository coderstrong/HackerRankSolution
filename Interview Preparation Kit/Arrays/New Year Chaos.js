function minimumBribes(q) {
  let palmminimum = 0;
  for (let index = 0; index < q.length; index++) {
    // if(q[index]==index+1)
    //     continue;
    if (q[index] - (index + 1) > 2) {
      palmminimum = -1;
      break;
    }
    for (let jdex = Math.max(0, q[index] - 2); jdex < index; jdex++) {
      if (q[jdex] > q[index]) {
        palmminimum++;
      }
    }
  }
  if (palmminimum > 0) {
    console.log(palmminimum);
  }
  else {
    console.log('Too chaotic');
  }

}
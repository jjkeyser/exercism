
export const toRna = (dna) => {
  let dnaMap = {G:'C', C:'G', T:'A', A:'U'};
  return dna.split('').reduce((a,b)=> a += dnaMap[b], '')
};

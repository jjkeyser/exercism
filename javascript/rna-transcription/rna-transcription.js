
export const toRna = (dna) => {
  let rna = '';
  let dnaMap = {G:'C', C:'G', T:'A', A:'U'};
  let i;

  for (i = 0; i < dna.length; i++) {
      rna += dnaMap[dna[i]];
  }

  return rna;
};

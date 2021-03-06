
export const translate = (rnaSequence = '') => {
  let codonMap = {
    AUG:'Methionine',
    UUU:'Phenylalanine',
    UUC:'Phenylalanine',
    UUA:'Leucine',
    UUG:'Leucine',
    UCU:'Serine',
    UCC:'Serine',
    UCA:'Serine',
    UCG:'Serine',
    UAU:'Tyrosine',
    UAC:'Tyrosine',
    UGU:'Cysteine',
    UGC:'Cysteine',
    UGG:'Tryptophan',
    UAA:'STOP',
    UAG:'STOP',
    UGA:'STOP',
  };

  let proteins = [];

  for (let i = 0; i < rnaSequence.length; i += 3) {
    let codon = rnaSequence.slice(i, i + 3);
    
    if (!(codon in codonMap)) {
      throw Error('Invalid codon');
    }

    if (codonMap[codon] === 'STOP') {
      break;
    }

    proteins.push(codonMap[codon]);
  }

  return proteins;
};

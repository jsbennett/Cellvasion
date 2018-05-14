using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Unlockables : MonoBehaviour {

	public Text Tier1; 
	public Text Tier2;
	public Text Tier3;
	public Text Tier4;
	
	// Use this for initialization
	void Start () {
	
		float scoreEarned = PlayerPrefs.GetFloat("scoreEarned"); 
		if(scoreEarned >=100 && scoreEarned <=499)
		{
			Tier1.text = "DNA, which stands for deoxyribonucleic acid, is the material that makes up everyone and everything! Yes even bananas! (more on that later) DNA is made up of four elements - Adenine, Thymine, Cytosine and Guanine. "; 
		}
		else if (scoreEarned >=500 && scoreEarned <=999)
		{
			Tier1.text = "DNA, which stands for deoxyribonucleic acid, is the material that makes up everyone and everything! Yes even bananas! (more on that later) DNA is made up of four elements - Adenine, Thymine, Cytosine and Guanine. "; 
			Tier2.text = "Here are some cracking DNA facts! Our DNA is 95% identical to the DNA of chimpanzees. But what I bet you didnt know is that our DNA is 50% identical to banana DNA........ BANANAS?!?!?!?!??! I'm shook. But also cabbages and we share about 40-50% of identical DNA!!!!!"; 
		}
		else if(scoreEarned >=1000 && scoreEarned <=1999)
		{
			Tier1.text = "DNA, which stands for deoxyribonucleic acid, is the material that makes up everyone and everything! Yes even bananas! (more on that later) DNA is made up of four elements - Adenine, Thymine, Cytosine and Guanine. "; 
			Tier2.text = "Here are some cracking DNA facts! Our DNA is 95% identical to the DNA of chimpanzees. But what I bet you didnt know is that our DNA is 50% identical to banana DNA........ BANANAS?!?!?!?!??! I'm shook. But also cabbages and we share about 40-50% of identical DNA!!!!!"; 
			Tier3.text = "If someone manages to unwind all DNA molecules in a human body and place them end to end, the total length that can be covered is 10 billion miles! That’s the distance covered in a trip from Earth to Pluto and back to Earth."; 
		}
		else if(scoreEarned >= 5000)
		{
			Tier1.text = "DNA, which stands for deoxyribonucleic acid, is the material that makes up everyone and everything! Yes even bananas! (more on that later) DNA is made up of four elements - Adenine, Thymine, Cytosine and Guanine. "; 
			Tier2.text = "Here are some cracking DNA facts! Our DNA is 95% identical to the DNA of chimpanzees. But what I bet you didnt know is that our DNA is 50% identical to banana DNA........ BANANAS?!?!?!?!??! I'm shook. But also cabbages and we share about 40-50% of identical DNA!!!!!"; 
			Tier3.text = "If someone manages to unwind all DNA molecules in a human body and place them end to end, the total length that can be covered is 10 billion miles! That’s the distance covered in a trip from Earth to Pluto and back to Earth."; 
			Tier4.text = "1 single gram of DNA is capable of holding an amazing 700 terabytes of data! If we want to store all digital information in this world, all we need is 2 grams of DNA.";
		}
	}
}

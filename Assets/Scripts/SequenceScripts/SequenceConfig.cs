using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SequenceConfig {

	public string foo_foo;
	public string faa_faa;
	public string seq3;

}

[System.Serializable]
public class SeqArray {

	//public SequenceConfig[] sequences;
	public List <SequenceConfig> sequences = new List<SequenceConfig>();



}


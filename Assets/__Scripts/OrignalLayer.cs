using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrignalLayer : MonoBehaviour
{
	/*
	<!-- Layer0, the deepest cards. -->
	<slot id = "0" x="-6" y="-5" faceup="0" layer="0" hiddenby="3,4" />
	<slot id = "1" x="0"  y="-5" faceup="0" layer="0" hiddenby="5,6" />
	<slot id = "2" x="6"  y="-5" faceup="0" layer="0" hiddenby="7,8" />
	
	<!-- Layer1, the next level. -->
	<slot id = "3" x="-7" y="-4" faceup="0" layer="1" hiddenby="9,10" />
	<slot id = "4" x="-5" y="-4" faceup="0" layer="1" hiddenby="10,11" />
	<slot id = "5" x="-1" y="-4" faceup="0" layer="1" hiddenby="12,13" />
	<slot id = "6" x="1"  y="-4" faceup="0" layer="1" hiddenby="13,14" />
	<slot id = "7" x="5"  y="-4" faceup="0" layer="1" hiddenby="15,16" />
	<slot id = "8" x="7"  y="-4" faceup="0" layer="1" hiddenby="16,17" />
	
	
	<!-- Layer2, the next level. -->
	<slot id = "9"  x="-8" y="-3" faceup="0" layer="2" hiddenby="18,19" />
	<slot id = "10" x="-6" y="-3" faceup="0" layer="2" hiddenby="19,20" />
	<slot id = "11" x="-4" y="-3" faceup="0" layer="2" hiddenby="20,21" />
	<slot id = "12" x="-2" y="-3" faceup="0" layer="2" hiddenby="21,22" />
	<slot id = "13" x="0"  y="-3" faceup="0" layer="2" hiddenby="22,23" />
	<slot id = "14" x="2"  y="-3" faceup="0" layer="2" hiddenby="23,24" />
	<slot id = "15" x="4"  y="-3" faceup="0" layer="2" hiddenby="24,25" />
	<slot id = "16" x="6"  y="-3" faceup="0" layer="2" hiddenby="25,26" />
	<slot id = "17" x="8"  y="-3" faceup="0" layer="2" hiddenby="26,27" />
	
	
	<!-- Layer3, the top level. -->
	<slot id = "18" x="-9" y="-2" faceup="1" layer="3" />
	<slot id = "19" x="-7" y="-2" faceup="1" layer="3" />
	<slot id = "20" x="-5" y="-2" faceup="1" layer="3" />
	<slot id = "21" x="-3" y="-2" faceup="1" layer="3" />
	<slot id = "22" x="-1" y="-2" faceup="1" layer="3" />
	<slot id = "23" x="1"  y="-2" faceup="1" layer="3" />
	<slot id = "24" x="3"  y="-2" faceup="1" layer="3" />
	<slot id = "25" x="5"  y="-2" faceup="1" layer="3" />
	<slot id = "26" x="7"  y="-2" faceup="1" layer="3" />
	<slot id = "27" x="9"  y="-2" faceup="1" layer="3" />
	*/

	/*
	<!-- decorators appear on every card. They are the suit and rank in the corners. -->
	<decorator type="letter" x="-1.05" y="1.42" z="0" flip="0" scale="1.25"/>
	<decorator type="suit" x="-1.05" y="1.03" z="0" flip="0" scale="0.4"/>
	<decorator type="suit" x="1.05" y="-1.03" z="0" flip="1" scale="0.4"/>
	<decorator type="letter" x="1.05" y="-1.42" z="0" flip="1" scale="1.25"/>
	<!-- A list of all cards that defines where pips are placed. -->
	<card rank="1">
		<pip x="0" y="0" z="0" flip="0" scale="2"/>
	</card>
	<card rank="2">
		<pip x="0" y="1.1" z="0" flip="0"/>
		<pip x="0" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="3">
		<pip x="0" y="1.1" z="0" flip="0"/>
		<pip x="0" y="0" z="0" flip="0"/>
		<pip x="0" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="4">
		<pip x="-.55" y="1.1" z="0" flip="0"/>
		<pip x=".55" y="1.1" z="0" flip="0"/>
		<pip x="-.55" y="-1.1" z="0" flip="1"/>
		<pip x=".55" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="5">
		<pip x="-.55" y="1.1" z="0" flip="0"/>
		<pip x=".55" y="1.1" z="0" flip="0"/>
		<pip x="0" y="0" z="0" flip="0"/>
		<pip x="-.55" y="-1.1" z="0" flip="1"/>
		<pip x=".55" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="6">
		<pip x="-.55" y="1.1" z="0" flip="0"/>
		<pip x=".55" y="1.1" z="0" flip="0"/>
		<pip x="-.55" y="0" z="0" flip="0"/>
		<pip x=".55" y="0" z="0" flip="0"/>
		<pip x="-.55" y="-1.1" z="0" flip="1"/>
		<pip x=".55" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="7">
		<pip x="-.55" y="1.1" z="0" flip="0"/>
		<pip x=".55" y="1.1" z="0" flip="0"/>
		<pip x="0" y=".55" z="0" flip="0"/>
		<pip x="-.55" y="0" z="0" flip="0"/>
		<pip x=".55" y="0" z="0" flip="0"/>
		<pip x="-.55" y="-1.1" z="0" flip="1"/>
		<pip x=".55" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="8">
		<pip x="-.55" y="1.1" z="0" flip="0"/>
		<pip x=".55" y="1.1" z="0" flip="0"/>
		<pip x="0" y=".55" z="0" flip="0"/>
		<pip x="-.55" y="0" z="0" flip="0"/>
		<pip x=".55" y="0" z="0" flip="0"/>
		<pip x="0" y="-.55" z="0" flip="1"/>
		<pip x="-.55" y="-1.1" z="0" flip="1"/>
		<pip x=".55" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="9">
		<pip x="-.58" y="1.1" z="0" flip="0"/>
		<pip x=".58" y="1.1" z="0" flip="0"/>
		<pip x="-.58" y=".37" z="0" flip="0"/>
		<pip x=".58" y=".37" z="0" flip="0"/>
		<pip x="0" y="0" z="0" flip="0"/>
		<pip x="-.58" y="-.37" z="0" flip="1"/>
		<pip x=".58" y="-.37" z="0" flip="1"/>
		<pip x="-.58" y="-1.1" z="0" flip="1"/>
		<pip x=".58" y="-1.1" z="0" flip="1"/>
	</card>
	<card rank="10">
		<pip x="-.58" y="1.1" z="0" flip="0"/>
		<pip x=".58" y="1.1" z="0" flip="0"/>
		<pip x="0" y=".73" z="0" flip="0"/>
		<pip x="-.58" y=".37" z="0" flip="0"/>
		<pip x=".58" y=".37" z="0" flip="0"/>
		<pip x="-.58" y="-.37" z="0" flip="1"/>
		<pip x=".58" y="-.37" z="0" flip="1"/>
		<pip x="0" y="-.73" z="0" flip="1"/>
		<pip x="-.58" y="-1.1" z="0" flip="1"/>
		<pip x=".58" y="-1.1" z="0" flip="1"/>
	</card>
	<!-- Face cards have no pips, so this references the name of the Sprite to be shown. -->
	<card rank="11" face="FaceCard_11"/>
	<card rank="12" face="FaceCard_12"/>
	<card rank="13" face="FaceCard_13"/>


		<!-- Layer0, the deepest cards. -->
	<slot id = "0" x="-6" y="-5" faceup="0" layer="0" hiddenby="5,6" />
	<slot id = "1" x="-4" y="-5" faceup="0" layer="0" hiddenby="6,7" />
	<slot id = "2" x="0"  y="-5" faceup="0" layer="0" hiddenby="8,9" />
	<slot id = "3" x="4" y="-5" faceup="0" layer="0" hiddenby="10,11" />
	<slot id = "4" x="6" y="-5" faceup="0" layer="0" hiddenby="11,12" />
	
	<!-- Layer1, the next level. -->
	<slot id = "5" x="-7" y="-4" faceup="0" layer="1" hiddenby="13,14" />
	<slot id = "6" x="-5" y="-4" faceup="0" layer="1" hiddenby="14,15" />
	<slot id = "7" x="-3" y="-4" faceup="0" layer="1" hiddenby="15,16" />
	<slot id = "8" x="-1" y="-4" faceup="0" layer="1" hiddenby="16,17" />
	<slot id = "9" x="1"  y="-4" faceup="0" layer="1" hiddenby="17,18" />
	<slot id = "10" x="3" y="-4" faceup="0" layer="1" hiddenby="18,19" />
	<slot id = "11" x="5" y="-4" faceup="0" layer="2" hiddenby="19,20" />
	<slot id = "12" x="7" y="-4" faceup="0" layer="2" hiddenby="20,21" />
	
	
	<!-- Layer2, the next level. -->
	<slot id = "13" x="-8" y="-3" faceup="0" layer="2" hiddenby="22,23" />
	<slot id = "14" x="-6" y="-3" faceup="0" layer="2" hiddenby="23" />
	<slot id = "15" x="-4" y="-3" faceup="1" layer="2" />
	<slot id = "16" x="-2" y="-3" faceup="0" layer="2" hiddenby="24" />
	<slot id = "17" x="0"  y="-3" faceup="0" layer="2" hiddenby="24,25" />
	<slot id = "18" x="2"  y="-3" faceup="0" layer="2" hiddenby="25" />
	<slot id = "19" x="4"  y="-3" faceup="1" layer="2" />
	<slot id = "20" x="6"  y="-3" faceup="0" layer="2" hiddenby="26" />
	<slot id = "21" x="8"  y="-3" faceup="0" layer="2" hiddenby="26,27" />
	
	
	<!-- Layer3, the top level. -->
	<slot id = "22" x="-9" y="-2" faceup="1" layer="3" />
	<slot id = "23" x="-7" y="-2" faceup="1" layer="3" />
	<slot id = "24" x="-1" y="-2" faceup="1" layer="3" />
	<slot id = "25" x="1"  y="-2" faceup="1" layer="3" />
	<slot id = "26" x="7"  y="-2" faceup="1" layer="3" />
	<slot id = "27" x="9"  y="-2" faceup="1" layer="3" />







		<!-- Layer0, the deepest cards. -->
	<slot id="27" x="0" y="3.5" faceup="0" layer="0" hiddenby="25,26"/>

	<!-- Layer1, the next level. -->
	<slot id="25" x="-1" y="2.5" faceup="0" layer="1" hiddenby="22,23" />
	<slot id="26" x="1" y="2.5" faceup="0" layer="1" hiddenby="23,24" />

	<!-- Layer2, the next level. -->
	<slot id="22" x="-2" y="1.5" faceup="0" layer="2" hiddenby="18,19" />
	<slot id="23" x="0" y="1.5" faceup="0" layer="2" hiddenby="19,20" />
	<slot id="24" x="2" y="1.5" faceup="0" layer="2" hiddenby="20,21" />

	<!-- Layer3, the next level. -->
	<slot id="18" x="-3" y="0.5" faceup="0" layer="3" hiddenby="22" />
	<slot id="19" x="-1" y="0.5" faceup="0" layer="3" hiddenby="22,23" />
	<slot id="20" x="1" y="0.5" faceup="0" layer="3" hiddenby="23,24" />
	<slot id="21" x="3" y="0.5" faceup="0" layer="3" hiddenby="24" />
	
	<!-- Layer4, the next level. -->
	<slot id="13" x="-4" y="-0.5" faceup="0" layer="4" hiddenby="18" />
	<slot id="14" x="-2" y="-0.5" faceup="0" layer="4" hiddenby="18,19" />
	<slot id="15" x="0" y="-0.5" faceup="0" layer="4" hiddenby="19,20" />
	<slot id="16" x="2" y="-0.5" faceup="0" layer="4" hiddenby="20,21" />
	<slot id="17" x="4" y="-0.5" faceup="0" layer="4" hiddenby="21" />
	
	<!-- Layer5, the next level. -->
	<slot id="7" x="-5" y="-1.5" faceup="0" layer="5" hiddenby="13" />
	<slot id="8" x="-3" y="-1.5" faceup="0" layer="5" hiddenby="13,14" />
	<slot id="9" x="-1" y="-1.5" faceup="0" layer="5" hiddenby="14,15" />
	<slot id="10" x="1" y="-1.5" faceup="0" layer="5" hiddenby="15,16" />
	<slot id="11" x="3" y="-1.5" faceup="0" layer="5" hiddenby="16,17" />
	<slot id="12" x="5" y="-1.5" faceup="0" layer="5" hiddenby="17" />
	
	<!-- Layer6, the top level. -->
	<slot id="0" x="-6" y="-2.5" faceup="1" layer="6" hiddenby="7" />
	<slot id="1" x="-4" y="-2.5" faceup="1" layer="6" hiddenby="7,8" />
	<slot id="2" x="-2" y="-2.5" faceup="1" layer="6" hiddenby="8,9" />
	<slot id="3" x="0" y="-2.5" faceup="1" layer="6" hiddenby="9,10" />
	<slot id="4" x="2" y="-2.5" faceup="1" layer="6" hiddenby="10,11" />
	<slot id="5" x="4" y="-2.5" faceup="1" layer="6" hiddenby="11,12" />
	<slot id="6" x="6" y="-2.5" faceup="1" layer="6" hiddenby="12" />
	
	<!-- This positions the draw pile and staggers it -->
	<slot type="drawpile" x="3.7" y="-5" xstagger="0.15" layer="7"/>
	
	<!-- This positions the discard pile and target card -->
	<slot type="discardpile" x="-2.3" y="-5" layer="8"/>



	<!-- Layer0, the deepest cards. -->
	<slot id="27" x="0" y="3.5" faceup="0" layer="0" hiddenby="25,26"/>

	<!-- Layer1, the next level. -->
	<slot id="25" x="-1" y="2.5" faceup="0" layer="0" hiddenby="22,23" />
	<slot id="26" x="1" y="2.5" faceup="0" layer="0" hiddenby="23,24" />

	<!-- Layer2, the next level. -->
	<slot id="22" x="-2" y="1.5" faceup="0" layer="1" hiddenby="18,19" />
	<slot id="23" x="0" y="1.5" faceup="0" layer="1" hiddenby="19,20" />
	<slot id="24" x="2" y="1.5" faceup="0" layer="1" hiddenby="20,21" />

	<!-- Layer3, the next level. -->
	<slot id="18" x="-3" y="0.5" faceup="0" layer="2" hiddenby="13,14" />
	<slot id="19" x="-1" y="0.5" faceup="0" layer="2" hiddenby="14,15" />
	<slot id="20" x="1" y="0.5" faceup="0" layer="2" hiddenby="15,16" />
	<slot id="21" x="3" y="0.5" faceup="0" layer="2" hiddenby="16,17" />
	
	<!-- Layer4, the next level. -->
	<slot id="13" x="-4" y="-0.5" faceup="0" layer="3" hiddenby="7,8" />
	<slot id="14" x="-2" y="-0.5" faceup="0" layer="3" hiddenby="8,9" />
	<slot id="15" x="0" y="-0.5" faceup="0" layer="3" hiddenby="9,10" />
	<slot id="16" x="2" y="-0.5" faceup="0" layer="3" hiddenby="10,11" />
	<slot id="17" x="4" y="-0.5" faceup="0" layer="3" hiddenby="11,12" />
	
	<!-- Layer5, the next level. -->
	<slot id="7" x="-5" y="-1.5" faceup="0" layer="4" hiddenby="0,1" />
	<slot id="8" x="-3" y="-1.5" faceup="0" layer="4" hiddenby="1,2" />
	<slot id="9" x="-1" y="-1.5" faceup="0" layer="4" hiddenby="2,3" />
	<slot id="10" x="1" y="-1.5" faceup="0" layer="4" hiddenby="3,4" />
	<slot id="11" x="3" y="-1.5" faceup="0" layer="4" hiddenby="4,5" />
	<slot id="12" x="5" y="-1.5" faceup="0" layer="4" hiddenby="5,6" />
	
	<!-- Layer6, the top level. -->
	<slot id="0" x="-6" y="-2.5" faceup="1" layer="5"  />
	<slot id="1" x="-4" y="-2.5" faceup="1" layer="5"  />
	<slot id="2" x="-2" y="-2.5" faceup="1" layer="5"  />
	<slot id="3" x="0" y="-2.5" faceup="1" layer="5"  />
	<slot id="4" x="2" y="-2.5" faceup="1" layer="5"  />
	<slot id="5" x="4" y="-2.5" faceup="1" layer="5"  />
	<slot id="6" x="6" y="-2.5" faceup="1" layer="5"  />
	
	<!-- This positions the draw pile and staggers it -->
	<slot type="drawpile" x="3.7" y="-5" xstagger="0" layer="4"/> 
	
	<!-- This positions the discard pile and target card -->
	<slot type="discardpile" x="-2.3" y="-5" layer="5"/>
	
	<!-- This positions the draw pile and staggers it -->
	<slot type="drawpile" x="3.7" y="-5" xstagger="0.15" layer="4"/>
	
	<!-- This positions the discard pile and target card -->
	<slot type="discardpile" x="-2.3" y="-5" layer="5"/>

		*/


}

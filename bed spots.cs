List<Wizard> Wizards;

const int BedSpotCount = 12;

bool CalculateBedSpotMember(List<Wizard> Wizards) {
	
	List<string> BedSpotMembers = new List<string>();

	foreach(Wizard wiz in Wizards) {
		
		if(BedSpotMembers.Count < BedSpotCount) {
			if(wiz.Captain == true){
				BedSpotMembers.add(wiz);
				Wizards.wiz.remove();
			} else if(wiz.year >= 4) {
				BedSpotMembers.add(wiz);
				Wizards.wiz.remove();
			} else if(wiz.name == "John Benfer") {
				BedSpotMembers.add(wiz);
				Wizards.wiz.remove();
			}
		} else {
			return BedSpotMembers;
		}
	}
	
	// all captain and 4th year or greater have bed spot by now
	
	//add third years with most attendance
	bool temp = true;
	foreach(Wizard wiz in Wizards) {
		if (BedSpotMembers.Count < BedSpotCount) {
			if (wiz.year == 3){
				temp = true;
				foreach(Wizard w in Wizards) {
					if(w.year == 3) {
						if(wiz.practiceCount < w.practiceCount) {
							temp = false;
						}
					}
				}
				if(temp == true) {
					BedSpotMembers.add(wiz);
					Wizards.wiz.remove();
				}
			}
		} else {
			return BedSpotMembers;
		}
	}
	
	// if here then all third years also have bedspot. 
	//No need to further calculate for first and second years because they do not need bed spots. 
	
	return BedSpotMembers;
	
}



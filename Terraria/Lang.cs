using System;
namespace Terraria
{
	internal class Lang
	{
		public static int lang = 0;
		public static string[] misc = new string[31];
		public static string[] menu = new string[114];
		public static string[] gen = new string[73];
		public static string[] inter = new string[59];
		public static string[] tip = new string[56];
		public static string[] mp = new string[22];
		public static string[] dt = new string[3];
		public static string the;
		public static string dialog(int l, bool english = false)
		{
			string text = Main.chrName[18];
			string str = Main.chrName[17];
			string text2 = Main.chrName[19];
			string text3 = Main.chrName[20];
			string str2 = Main.chrName[38];
			string arg_36_0 = Main.chrName[54];
			string str3 = Main.chrName[22];
			string arg_49_0 = Main.chrName[108];
			string text4 = Main.chrName[107];
			string text5 = Main.chrName[124];
			string str4 = Main.chrName[160];
			string arg_76_0 = Main.chrName[178];
			string arg_82_0 = Main.chrName[207];
			string str5 = Main.chrName[208];
			string str6 = Main.chrName[209];
			string arg_A8_0 = Main.chrName[227];
			string arg_B4_0 = Main.chrName[228];
			string str7 = Main.chrName[229];
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
				case 1:
					return "I hope a scrawny kid like you isn't all that is standing between us and Cthulu's Eye.";
				case 2:
					return "Look at that shoddy armor you're wearing. Better buy some more healing potions.";
				case 3:
					return "I feel like an evil presence is watching me.";
				case 4:
					return "Sword beats paper! Get one today.";
				case 5:
					return "You want apples? You want carrots? You want pineapples? We got torches.";
				case 6:
					return "Lovely morning, wouldn't you say? Was there something you needed?";
				case 7:
					return "Night will be upon us soon, friend. Make your choices while you can.";
				case 8:
					return "You have no idea how much Dirt Blocks sell for overseas.";
				case 9:
					return "Ah, they will tell tales of " + Main.player[Main.myPlayer].name + " some day... good ones I'm sure.";
				case 10:
					return "Check out my dirt blocks; they are extra dirty.";
				case 11:
					return "Boy, that sun is hot! I do have some perfectly ventilated armor.";
				case 12:
					return "The sun is high, but my prices are not.";
				case 13:
					return string.Concat(new string[]
					{
						"Oh, great. I can hear ",
						text5,
						" and ",
						text,
						" arguing from here."
					});
				case 14:
					return "Have you seen Chith...Shith.. Chat... The big eye?";
				case 15:
					return "Hey, this house is secure, right? Right? " + Main.player[Main.myPlayer].name + "?";
				case 16:
					return "Not even a blood moon can stop capitalism. Let's do some business.";
				case 17:
					return "Keep your eye on the prize, buy a lense!";
				case 18:
					return "Kosh, kapleck Mog. Oh sorry, that's klingon for 'Buy something or die.'";
				case 19:
					return Main.player[Main.myPlayer].name + " is it? I've heard good things, friend!";
				case 20:
					return "I hear there's a secret treasure... oh never mind.";
				case 21:
					return "Angel Statue you say? I'm sorry, I'm not a junk dealer.";
				case 22:
					return "The last guy who was here left me some junk... er I mean... treasures!";
				case 23:
					return "I wonder if the moon is made of cheese...huh, what? Oh yes, buy something!";
				case 24:
					return "Did you say gold?  I'll take that off of ya.";
				case 25:
					return "You better not get blood on me.";
				case 26:
					return "Hurry up and stop bleeding.";
				case 27:
					return "If you're going to die, do it outside.";
				case 28:
					return "What is that supposed to mean?!";
				case 29:
					return "I don't think I like your tone.";
				case 30:
					return "Why are you even here? If you aren't bleeding, you don't need to be here. Get out.";
				case 31:
					return "WHAT?!";
				case 32:
					return "Have you seen that old man pacing around the dungeon? He looks troubled.";
				case 33:
					return "I wish " + str2 + " would be more careful.  I'm getting tired of having to sew his limbs back on every day.";
				case 34:
					return "Hey, has " + text2 + " mentioned needing to go to the doctor for any reason? Just wondering.";
				case 35:
					return "I need to have a serious talk with " + str3 + ". How many times a week can you come in with severe lava burns?";
				case 36:
					return "I think you look better this way.";
				case 37:
					return "Eww... What happened to your face?";
				case 38:
					return "MY GOODNESS! I'm good, but I'm not THAT good.";
				case 39:
					return "Dear friends we are gathered here today to bid farewell... Oh, you'll be fine.";
				case 40:
					return "You left your arm over there. Let me get that for you...";
				case 41:
					return "Quit being such a baby! I've seen worse.";
				case 42:
					return "That's gonna need stitches!";
				case 43:
					return "Trouble with those bullies again?";
				case 44:
					return "Hold on, I've got some cartoon bandages around here somewhere.";
				case 45:
					return "Walk it off, " + Main.player[Main.myPlayer].name + ", you'll be fine. Sheesh.";
				case 46:
					return "Does it hurt when you do that? Don't do that.";
				case 47:
					return "You look half digested. Have you been chasing slimes again?";
				case 48:
					return "Turn your head and cough.";
				case 49:
					return "That's not the biggest I've ever seen... Yes, I've seen bigger wounds for sure.";
				case 50:
					return "Would you like a lollipop?";
				case 51:
					return "Show me where it hurts.";
				case 52:
					return "I'm sorry, but you can't afford me.";
				case 53:
					return "I'm gonna need more gold than that.";
				case 54:
					return "I don't work for free you know.";
				case 55:
					return "I don't give happy endings.";
				case 56:
					return "I can't do anymore for you without plastic surgery.";
				case 57:
					return "Quit wasting my time.";
				case 58:
					return "I heard there is a doll that looks very similar to " + str3 + " somewhere in the underworld.  I'd like to put a few rounds in it.";
				case 59:
					return "Make it quick! I've got a date with " + text + " in an hour.";
				case 60:
					return "I want what " + text + " is sellin'. What do you mean, she doesn't sell anything?";
				case 61:
					return text3 + " is a looker.  Too bad she's such a prude.";
				case 62:
					return "Don't bother with " + str2 + ", I've got all you need right here.";
				case 63:
					return "What's " + str2 + "'s problem? Does he even realize we sell completely different stuff?";
				case 64:
					return "Man, it's a good night not to talk to anybody, don't you think, " + Main.player[Main.myPlayer].name + "?";
				case 65:
					return "I love nights like tonight.  There is never a shortage of things to kill!";
				case 66:
					return "I see you're eyeballin' the Minishark.. You really don't want to know how it was made.";
				case 67:
					return "Hey, this ain't a movie, pal. Ammo is extra.";
				case 68:
					return "Keep your hands off my gun, buddy!";
				case 69:
					return "Have you tried using purification powder on the ebonstone of the corruption?";
				case 70:
					return "I wish " + text2 + " would stop flirting with me. Doesn't he realize I'm 500 years old?";
				case 71:
					return "Why does " + str + " keep trying to sell me an angel statues? Everyone knows that they don't do anything.";
				case 72:
					return "Have you seen the old man walking around the dungeon? He doesn't look well at all...";
				case 73:
					return "I sell what I want! If you don't like it, too bad.";
				case 74:
					return "Why do you have to be so confrontational during a time like this?";
				case 75:
					return "I don't want you to buy my stuff. I want you to want to buy my stuff, ok?";
				case 76:
					return "Dude, is it just me or is there like a million zombies out tonight?";
				case 77:
					return "You must cleanse the world of this corruption.";
				case 78:
					return "Be safe; Terraria needs you!";
				case 79:
					return "The sands of time are flowing. And well, you are not aging very gracefully.";
				case 80:
					return "What's this about me having more 'bark' than bite?";
				case 81:
					return "So two goblins walk into a bar, and one says to the other, 'Want to get a Goblet of beer?!";
				case 82:
					return "I cannot let you enter until you free me of my curse.";
				case 83:
					return "Come back at night if you wish to enter.";
				case 84:
					return "My master cannot be summoned under the light of day.";
				case 85:
					return "You are far too weak to defeat my curse.  Come back when you aren't so worthless.";
				case 86:
					return "You pathetic fool.  You cannot hope to face my master as you are now.";
				case 87:
					return "I hope you have like six friends standing around behind you.";
				case 88:
					return "Please, no, stranger. You'll only get yourself killed.";
				case 89:
					return "You just might be strong enough to free me from my curse...";
				case 90:
					return "Stranger, do you possess the strength to defeat my master?";
				case 91:
					return "Please! Battle my captor and free me! I beg you!";
				case 92:
					return "Defeat my master, and I will grant you passage into the Dungeon.";
				case 93:
					return "Trying to get past that ebonrock, eh?  Why not introduce it to one of these explosives!";
				case 94:
					return "Hey, have you seen a clown around?";
				case 95:
					return "There was a bomb sitting right here, and now I can't seem to find it...";
				case 96:
					return "I've got something for them zombies alright!";
				case 97:
					return "Even " + text2 + " wants what I'm selling!";
				case 98:
					return "Would you rather have a bullet hole or a grenade hole? That's what I thought.";
				case 99:
					return "I'm sure " + text + " will help if you accidentally lose a limb to these.";
				case 100:
					return "Why purify the world when you can just blow it up?";
				case 101:
					return "If you throw this one in the bathtub and close all the windows, it'll clear your sinuses and pop your ears!";
				case 102:
					return "Wanna play Fuse Chicken?";
				case 103:
					return "Hey, could you sign this Griefing Waiver?";
				case 104:
					return "NO SMOKING IN HERE!!";
				case 105:
					return "Explosives are da' bomb these days.  Buy some now!";
				case 106:
					return "It's a good day to die!";
				case 107:
					return "I wonder what happens if I... (BOOM!)... Oh, sorry, did you need that leg?";
				case 108:
					return "Dynamite, my own special cure-all for what ails ya.";
				case 109:
					return "Check out my goods; they have explosive prices!";
				case 110:
					return "I keep having vague memories of tying up a woman and throwing her in a dungeon.";
				case 111:
					return "... we have a problem! Its a blood moon out there!";
				case 112:
					return "T'were I younger, I would ask " + text + " out. I used to be quite the lady killer.";
				case 113:
					return "That Red Hat of yours looks familiar...";
				case 114:
					return "Thanks again for freeing me from my curse. Felt like something jumped up and bit me.";
				case 115:
					return "Mama always said I would make a great tailor.";
				case 116:
					return "Life's like a box of clothes; you never know what you are gonna wear!";
				case 117:
					return "Of course embroidery is hard! If it wasn't hard, no one would do it! That's what makes it great.";
				case 118:
					return "I know everything they is to know about the clothierin' business.";
				case 119:
					return "Being cursed was lonely, so I once made a friend out of leather. I named him Wilson.";
				case 120:
					return "Thank you for freeing me, human.  I was tied up and left here by the other goblins.  You could say that we didn't get along very well.";
				case 121:
					return "I can't believe they tied me up and left me here just for pointing out that they weren't going east!";
				case 122:
					return "Now that I'm an outcast, can I throw away the spiked balls? My pockets hurt.";
				case 123:
					return "Looking for a gadgets expert? I'm your goblin!";
				case 124:
					return "Thanks for your help. Now, I have to finish pacing around aimlessly here. I'm sure we'll meet again.";
				case 125:
					return "I thought you'd be taller.";
				case 126:
					return "Hey...what's " + text5 + " up to? Have you...have you talked to her, by chance?";
				case 127:
					return "Hey, does your hat need a motor? I think I have a motor that would fit exactly in that hat.";
				case 128:
					return "Yo, I heard you like rockets and running boots, so I put some rockets in your running boots.";
				case 129:
					return "Silence is golden. Duct tape is silver.";
				case 130:
					return "YES, gold is stronger than iron. What are they teaching these humans nowadays?";
				case 131:
					return "You know, that mining helmet-flipper combination was a much better idea on paper.";
				case 132:
					return "Goblins are surprisingly easy to anger. In fact, they could start a war over cloth!";
				case 133:
					return "To be honest, most goblins aren't exactly rocket scientists. Well, some are.";
				case 134:
					return "Do you know why we all carry around these spiked balls? Because I don't.";
				case 135:
					return "I just finished my newest creation! This version doesn't explode violently if you breathe on it too hard.";
				case 136:
					return "Goblin thieves aren't very good at their job. They can't even steal from an unlocked chest!";
				case 137:
					return "Thanks for saving me, friend!  This bondage was starting to chafe.";
				case 138:
					return "Ohh, my hero!";
				case 139:
					return "Oh, how heroic! Thank you for saving me, young lady!";
				case 140:
					return "Oh, how heroic! Thank you for saving me, young man!";
				case 141:
					return "Now that we know each other, I can move in with you, right?";
				case 142:
					return "Well, hi there, " + str3 + "! What can I do for you today?";
				case 143:
					return "Well, hi there, " + str2 + "! What can I do for you today?";
				case 144:
					return "Well, hi there, " + text4 + "! What can I do for you today?";
				case 145:
					return "Well, hi there, " + text + "! What can I do for you today?";
				case 146:
					return "Well, hi there, " + text5 + "! What can I do for you today?";
				case 147:
					return "Well, hi there, " + text3 + "! What can I do for you today?";
				case 148:
					return "Want me to pull a coin from behind your ear? No? Ok.";
				case 149:
					return "Do you want some magic candy? No? Ok.";
				case 150:
					return "I make a rather enchanting hot chocolate if you'd be inter...No? Ok.";
				case 151:
					return "Are you here for a peek at my crystal ball?";
				case 152:
					return "Ever wanted an enchanted ring that turns rocks into slimes? Well neither did I.";
				case 153:
					return "Someone once told me friendship is magic. That's ridiculous. You can't turn people into frogs with friendship.";
				case 154:
					return "I can see your future now... You will buy a lot of items from me!";
				case 155:
					return "I once tried to bring an Angel Statue to life. It didn't do anything.";
				case 156:
					return "Thanks!  It was just a matter of time before I ended up like the rest of the skeletons down here.";
				case 157:
					return "Hey, watch where you're going! I was over there a little while ago!";
				case 158:
					return "Hold on, I've almost got wifi going down here.";
				case 159:
					return "But I was almost done putting blinking lights up here!";
				case 160:
					return "DON'T MOVE. I DROPPED MY CONTACT.";
				case 161:
					return "All I want is for the switch to make the... What?!";
				case 162:
					return "Oh, let me guess. Didn't buy enough wire. Idiot.";
				case 163:
					return "Just-could you just... Please? Ok? Ok. Ugh.";
				case 164:
					return "I don't appreciate the way you're looking at me. I am WORKING right now.";
				case 165:
					return string.Concat(new string[]
					{
						"Hey, ",
						Main.player[Main.myPlayer].name,
						", did you just come from ",
						text4,
						"'s? Did he say anything about me by chance?"
					});
				case 166:
					return text2 + " keeps talking about pressing my pressure plate. I told him it was for stepping on.";
				case 167:
					return "Always buy more wire than you need!";
				case 168:
					return "Did you make sure your device was plugged in?";
				case 169:
					return "Oh, you know what this house needs? More blinking lights.";
				case 170:
					return "You can tell a Blood Moon is out when the sky turns red. There is something about it that causes monsters to swarm.";
				case 171:
					return "Hey, buddy, do you know where any deathweed is? Oh, no reason; just wondering, is all.";
				case 172:
					return "If you were to look up, you'd see that the moon is red right now.";
				case 173:
					return "You should stay indoors at night. It is very dangerous to be wandering around in the dark.";
				case 174:
					return "Greetings, " + Main.player[Main.myPlayer].name + ". Is there something I can help you with?";
				case 175:
					return "I am here to give you advice on what to do next.  It is recommended that you talk with me anytime you get stuck.";
				case 176:
					return "They say there is a person who will tell you how to survive in this land... oh wait. That's me.";
				case 177:
					return "You can use your pickaxe to dig through dirt, and your axe to chop down trees. Just place your cursor over the tile and click!";
				case 178:
					return "If you want to survive, you will need to create weapons and shelter. Start by chopping down trees and gathering wood.";
				case 179:
					return "Press ESC to access your crafting menu. When you have enough wood, create a workbench. This will allow you to create more complicated things, as long as you are standing close to it.";
				case 180:
					return "You can build a shelter by placing wood or other blocks in the world. Don't forget to create and place walls.";
				case 181:
					return "Once you have a wooden sword, you might try to gather some gel from the slimes. Combine wood and gel to make a torch!";
				case 182:
					return "To interact with backgrounds, use a hammer!";
				case 183:
					return "You should do some mining to find metal ore. You can craft very useful things with it.";
				case 184:
					return "Now that you have some ore, you will need to turn it into a bar in order to make items with it. This requires a furnace!";
				case 185:
					return "You can create a furnace out of torches, wood, and stone. Make sure you are standing near a work bench.";
				case 186:
					return "You will need an anvil to make most things out of metal bars.";
				case 187:
					return "Anvils can be crafted out of iron, or purchased from a merchant.";
				case 188:
					return "Underground are crystal hearts that can be used to increase your max life. You can smash them with a pickaxe.";
				case 189:
					return "If you gather 5 fallen stars, they can be combined to create an item that will increase your magic capacity.";
				case 190:
					return "Stars fall all over the world at night. They can be used for all sorts of usefull things. If you see one, be sure to grab it because they disappear after sunrise.";
				case 191:
					return "There are many different ways you can attract people to move in to our town. They will of course need a home to live in.";
				case 192:
					return "In order for a room to be considered a home, it needs to have a door, chair, table, and a light source.  Make sure the house has walls as well.";
				case 193:
					return "Two people will not live in the same home. Also, if their home is destroyed, they will look for a new place to live.";
				case 194:
					return "You can use the housing interface to assign and view housing. Open your inventory and click the house icon.";
				case 195:
					return "If you want a merchant to move in, you will need to gather plenty of money. 50 silver coins should do the trick!";
				case 196:
					return "For a nurse to move in, you might want to increase your maximum life.";
				case 197:
					return "If you had a gun, I bet an arms dealer might show up to sell you some ammo!";
				case 198:
					return "You should prove yourself by defeating a strong monster. That will get the attention of a dryad.";
				case 199:
					return "Make sure to explore the dungeon thoroughly. There may be prisoners held deep within.";
				case 200:
					return "Perhaps the old man by the dungeon would like to join us now that his curse has been lifted.";
				case 201:
					return "Hang on to any bombs you might find. A demolitionist may want to have a look at them.";
				case 202:
					return "Are goblins really so different from us that we couldn't live together peacefully?";
				case 203:
					return "I heard there was a powerfully wizard who lives in these parts.  Make sure to keep an eye out for him next time you go underground.";
				case 204:
					return "If you combine lenses at a demon altar, you might be able to find a way to summon a powerful monster. You will want to wait until night before using it, though.";
				case 205:
					return "You can create worm bait with rotten chunks and vile powder. Make sure you are in a corrupt area before using it.";
				case 206:
					return "Demonic altars can usually be found in the corruption. You will need to be near them to craft some items.";
				case 207:
					return "You can make a grappling hook from a hook and 3 chains. Skeletons found deep underground usually carry hooks, and chains can be made from iron bars.";
				case 208:
					return "If you see a pot, be sure to smash it open. They contain all sorts of useful supplies.";
				case 209:
					return "There is treasure hidden all over the world. Some amazing things can be found deep underground!";
				case 210:
					return "Smashing a shadow orb will sometimes cause a meteor to fall out of the sky. Shadow orbs can usually be found in the chasms around corrupt areas.";
				case 211:
					return "You should focus on gathering more heart crystals to increase your maximum life.";
				case 212:
					return "Your current equipment simply won't do. You need to make better armor.";
				case 213:
					return "I think you are ready for your first major battle. Gather some lenses from the eyeballs at night and take them to a demon altar.";
				case 214:
					return "You will want to increase your life before facing your next challenge. Fifteen hearts should be enough.";
				case 215:
					return "The ebonstone in the corruption can be purified using some powder from a dryad, or it can be destroyed with explosives.";
				case 216:
					return "Your next step should be to explore the corrupt chasms.  Find and destroy any shadow orb you find.";
				case 217:
					return "There is a old dungeon not far from here. Now would be a good time to go check it out.";
				case 218:
					return "You should make an attempt to max out your available life. Try to gather twenty hearts.";
				case 219:
					return "There are many treasures to be discovered in the jungle, if you are willing to dig deep enough.";
				case 220:
					return "The underworld is made of a material called hellstone. It's perfect for making weapons and armor.";
				case 221:
					return "When you are ready to challenge the keeper of the underworld, you will have to make a living sacrifice. Everything you need for it can be found in the underworld.";
				case 222:
					return "Make sure to smash any demon altar you can find. Something good is bound to happen if you do!";
				case 223:
					return "Souls can sometimes be gathered from fallen creatures in places of extreme light or dark.";
				case 224:
					return "Ho ho ho, and a bottle of... Egg Nog!";
				case 225:
					return "Care to bake me some cookies?";
				case 226:
					return "What? You thought I wasn't real?";
				case 227:
					return "I managed to sew your face back on. Be more careful next time.";
				case 228:
					return "That's probably going to leave a scar.";
				case 229:
					return "All better. I don't want to see you jumping off anymore cliffs.";
				case 230:
					return "That didn't hurt too bad, now did it?";
				case 231:
					return "As if living underground wasn't bad enough, jerks like you come in while I'm sleeping and steal my children.";
				case 232:
					return "Between you and me, " + text3 + " is the only one I trust. She is the only one here who hasn't tried to eat me or use me in a potion.";
				case 233:
					return "I tried to lick myself the other day to see what the big deal was, everything started glowing blue.";
				case 234:
					return "Everytime I see the color blue, it makes me depressed and lazy.";
				case 235:
					return "You haven't seen any pigs around here have you? My brother lost his leg to one.";
				case 236:
					return "Everyone in this town feels a bit off. I woke up to the clothier chewing on my foot last night.";
				case 237:
					return "I'll give you a discount on your wears if you can convince " + str4 + " to come over for a...sizing.";
				case 238:
					return "I feel like " + str4 + " is a bit misunderstood, he really is a fun guy.";
				case 240:
					return "I don't know the 'Truffle Shuffle,' so stop asking!";
				case 241:
					return "There's been such a huge rumor that's being spread about me, 'If you can't beat him, eat him!'";
				case 242:
					return "Oy, whatchu got in you jiminy fluffer?";
				case 243:
					return "Should I become an air pirate? I've considered becoming an air pirate.";
				case 244:
					return "Be it what it would, a jetpack would suit you nicely!";
				case 245:
					return "I'm feeling a bit peevish as of late, so enough with your palaver you ragamuffin!";
				case 246:
					return "I'm mighty curious about that " + str6 + " fellow. By what manner of consumption does he maintain such locomotion?";
				case 247:
					return "That captain fellow seems to me to be 'pretty well over the bay' if you know what mean!";
				case 248:
					return "Show me some gears!";
				case 249:
					return "I like your... gear. Does it come in brass?";
				case 250:
					return "Once you enter hallowed land, you will see a rainbow in the sky. I can help you with painting that if you want.";
				case 251:
					return "Check out " + str5 + ". Now that's a girl who can paint the town red!";
				case 252:
					return "I know the difference between turquoise and blue-green. But I won't tell you.";
				case 253:
					return "I'm all out of titanium white, so don't even ask.";
				case 254:
					return "Try swirly pink and purple, it works, I swear!";
				case 255:
					return "No, no, no... There's TONS of different grays! Don't get me started...";
				case 256:
					return "I hope it doesn't rain again until this paint dries. That would be a disaster!";
				case 257:
					return "I bring you the richest colors in exchange for your riches!";
				case 258:
					return "My dear, what you're wearing is much too drab. You absolutely must take a lesson in dyeing your tired attire!";
				case 259:
					return "The only kind of wood I would bother dyeing is RICH Mahogany. Dyeing any other wood is such a waste.";
				case 260:
					return "You must do something about " + str7 + ".  Everytime he comes over here, it takes me a week to get the smell off!";
				case 261:
					return "Which doctor am I? The Witch Doctor am I.";
				case 262:
					return "The heart of magic is nature. The nature of hearts is magic.";
				case 263:
					return text + " may help heal your body, but I can make you embody healing.";
				case 264:
					return "Choose wisely, " + Main.player[Main.myPlayer].name + ", my commodities are volatile and my dark arts, mysterious.";
				case 265:
					return "We have to talk. It's... it's about parties.";
				case 266:
					return "I can't decide what I like more: parties, or after-parties.";
				case 267:
					return "We should set up a blinkroot party, and we should also set up an after-party.";
				case 268:
					return "Wow, " + Main.player[Main.myPlayer].name + ", meeting an adventurous man like you makes me want to party!";
				case 269:
					return "Put up a disco ball and then I'll show you how to party.";
				case 270:
					return "I went to Sweden once, they party hard, why aren't you like that?";
				case 271:
					return "My name's " + str5 + " but people call me party pooper. Yeah I don't know, it sounds cool though";
				case 272:
					return "Do you party? Sometimes? Hm, okay then we can talk...";
				case 273:
					return "I'm no landlubber, but it's better to have lubbed and lost than never to have lubbed at all.";
				case 274:
					return "Yo ho ho and a bottle of....blinkroots!";
				case 275:
					return "YAR!  Funny ye should be mentionin' parrots b'cause...um...What t'were we talkin' 'bout?";
				case 276:
					return Main.player[Main.myPlayer].name + ", Ye be one o' the finest lookin' lassies this here captain's seen in many a fortnight!";
				case 277:
					return "Stay off me booty, ya scallywag!";
				case 278:
					return "What in blazes are ye talkin' about? Moby Dick is mine!";
				case 279:
					return "*Yarr Blarr Harrdarr*";
				case 280:
					return "And then Unit 492-8 said, 'Who do you think I am, Unit 472-6?' HA. HA. HA.";
				case 281:
					return "My expedition efficiency was critically reduced when a projectile impacted my locomotive actuator.";
				case 282:
					return "This sentence is false , or is it?";
				case 283:
					return "So that 'punk' lookin' chick is an inventor, eh? I think I could show her a thing or two!";
				case 284:
					return "Sure, me and " + str7 + " are pals, but I hate it when his parrot does his business on me. That stuff's corrosive!";
				case 285:
					return "I built myself a taste mechanism, so I can drink some ale!";
				case 286:
					return "Sometimes I come off a bit... Get it? a bit?";
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					switch (l)
					{
					case 1:
						return "Ich hoffe, du duennes Hemd bist nicht das Einzige, was zwischen Chtulus Auge und uns steht.";
					case 2:
						return "Was fuer eine schaebige Ruestung du traegst. Kaufe lieber ein paar Heiltraenke.";
					case 3:
						return "Ich habe das Gefuehl, dass mich eine boese Kraft beobachtet.";
					case 4:
						return "Schwert schlaegt Papier! Hol dir noch heute eins.";
					case 5:
						return "Du moechtest Aepfel? Du willst Karotten? Ananas? Wir haben Fackeln.";
					case 6:
						return "Ein schoener Morgen, nicht wahr? War da noch was, was du brauchst?";
					case 7:
						return "Die Nacht wird bald hereinbrechen. Entscheide dich, solange du kannst.";
					case 8:
						return "Du hast keine Ahnung, wie gut sich Dreckbloecke nach Uebersee verkaufen.";
					case 9:
						return "Ach, eines Tages werden sie Geschichten ueber" + Main.player[Main.myPlayer].name + " erzaehlen ... sicher gute";
					case 10:
						return "Schau dir mal meine Schmutzbloecke an; die sind wirklich super-dreckig.";
					case 11:
						return "Junge, Junge, wie die Sonne brennt! Ich hab da eine tolle klimatisierte Ruestung.";
					case 12:
						return "Die Sonne steht zwar hoch, meine Preise sind's aber nicht.";
					case 13:
						return string.Concat(new string[]
						{
							"Toll. Ich kann ",
							text5,
							" und ",
							text,
							" von hier aus diskutieren hoeren."
						});
					case 14:
						return "Hast du Chith ... Shith.. Chat... Das grosse Auge gesehen?";
					case 15:
						return "Heh, dieses Haus ist doch wohl sicher? Oder? " + Main.player[Main.myPlayer].name + "?";
					case 16:
						return "Nicht mal ein Blutmond kann den Kapitalismus stoppen. Lass uns also Geschaefte machen.";
					case 17:
						return "Achte auf den Preis, kaufe eine Linse!";
					case 18:
						return "Kosh, kapleck Mog. Oha, sorry. Das ist klingonisch fuer: Kauf oder stirb!";
					case 19:
						return Main.player[Main.myPlayer].name + " ist es? Ich habe nur Gutes ueber dich gehoert!";
					case 20:
						return "Ich hoerte, es gibt einen geheimen Schatz ... oh, vergiss es!";
					case 21:
						return "Engelsstatue, sagst du? Tut mir Leid, ich bin kein Nippesverkaeufer.";
					case 22:
						return "Der letzte Typ, der hier war, hinterliess mir einigen Nippes, aeh, ... Schaetze!";
					case 23:
						return "Ich frage mich, ob der Mond aus Kaese ist ... huch, was? Oh, ja, kauf etwas!";
					case 24:
						return "Hast du Gold gesagt? Ich nehm dir das ab.";
					case 25:
						return "Blute mich bloss nicht voll!";
					case 26:
						return "Mach schon und hoer mit dem Bluten auf!";
					case 27:
						return "Wenn du stirbst, dann bitte draussen.";
					case 28:
						return "Was soll das heissen?!";
					case 29:
						return "Irgendwie gefaellt mir dein Ton nicht.";
					case 30:
						return "Warum bist du ueberhaupt hier? Wenn du nicht blutest, gehoerst du nicht her. Raus jetzt!";
					case 31:
						return "WAS?!";
					case 32:
						return "Hast du den Greis um den Dungeon schreiten sehen? Der scheint Probleme zu haben.";
					case 33:
						return "Ich wuenschte, " + str2 + " waere vorsichtiger. Es nervt mich, taeglich seine Glieder zusammennaehen zu muessen.";
					case 34:
						return "Heh, hat " + text2 + " den Grund fuer einen notwendigen Arztbesuch erwaehnt? Ich wundere mich nur.";
					case 35:
						return "Ich muss mal ein ernsthaftes Wort mit  " + str3 + " reden. Wie oft kann man in einer Woche mit schweren Lava-Verbrennungen hereinkommen?";
					case 36:
						return "Ich finde, du siehst so besser aus.";
					case 37:
						return "Aehhh ... Was ist denn mit deinem Gesicht passiert?";
					case 38:
						return "MEINE GUeTE! Ich bin gut, aber ich bin nicht SO gut.";
					case 39:
						return "Liebe Freunde, wir sind zusammengekommen, um Aufwiedersehen zu sagen ... Ach, es wird schon werden.";
					case 40:
						return "Du hast deinen Arm da drueben gelassen. Lass ihn mich holen ...";
					case 41:
						return "Hoer schon auf, wie ein Baby zu plaerren! Ich habe Schlimmeres gesehen.";
					case 42:
						return "Das geht nicht ohne ein paar Stiche!";
					case 43:
						return "Schon wieder Aerger mit diesen Rabauken?";
					case 44:
						return "Halt aus. Ich hab hier irgendwo ein paar huebsch bedruckte Pflaster.";
					case 45:
						return "Hoer schon auf, " + Main.player[Main.myPlayer].name + ", du ueberstehst das schon. Mist.";
					case 46:
						return "Tut es weh, wenn ich das mache? Tu das nicht.";
					case 47:
						return "Du siehst halb verdaut aus. Hast du schon wieder Schleimis gejagt?";
					case 48:
						return "Drehe deinen Kopf und huste!";
					case 49:
						return "Ich habe schon Schlimmeres gesehen ... ja, ganz sicher habe ich schon groessere Wunden gesehen.";
					case 50:
						return "Moechtest du einen Lollipop?";
					case 51:
						return "Zeig mir, wo es schmerzt.";
					case 52:
						return "Tut mir Leid, aber du kannst mich dir gar nicht leisten.";
					case 53:
						return "Dafuer brauche ich mehr Gold.";
					case 54:
						return "Ich arbeite schliesslich nicht umsonst.";
					case 55:
						return "Ich verschenke keine Happy-Ends.";
					case 56:
						return "Ich kann nicht mehr fuer dich tun ohne Schoenheitsoperation.";
					case 57:
						return "Verschwende meine Zeit nicht laenger!";
					case 58:
						return "Ich habe gehoert, es gibt eine Puppe in der Unterwelt, die " + str3 + " sehr aehnlich sieht. Ich wuerde gern ein bisschen schiessen.";
					case 59:
						return "Mach schnell! Ich habe in einer Stunde ein Date mit " + text + ".";
					case 60:
						return "Ich moechte das, was " + text + "  verkauft. Was heisst, sie verkauft nichts?";
					case 61:
						return text3 + " ist ein Huebscher. Zu dumm, dass sie so pruede ist.";
					case 62:
						return "Halte dich nicht mit " + str2 + " auf, ich habe alles, was du brauchst hier.";
					case 63:
						return "Was ist eigentlich mit " + str2 + " los? Kriegt der mal mit, dass wir ganz andere Sachen verkaufen?";
					case 64:
						return "Das ist eine gute Nacht, um mit niemandem zu sprechen, denkst du nicht, " + Main.player[Main.myPlayer].name + "?";
					case 65:
						return "Ich liebe Naechte wie diese. Es gibt immer genug zu toeten!";
					case 66:
						return "Wie ich sehe, starrst du den Minihai an ... Du solltest lieber nicht fragen, wie der entstand.";
					case 67:
						return "Moment, das ist kein Film, Freundchen. Munition geht extra.";
					case 68:
						return "Haende weg von meinem Gewehr, Kumpel!";
					case 69:
						return "Hast du versucht, das Reinigungspulver auf dem Ebenstein des Verderbens auszuprobieren?";
					case 70:
						return "Ich wuenschte,  " + text2 + " wuerde die Flirterei lassen. Versteht er nicht, dass ich 500 Jahre alt bin?";
					case 71:
						return "Warum versucht " + str + " , mir Engelsstatuen zu verkaufen? Jeder weiss, dass sie nutzlos sind.";
					case 72:
						return "Hast du den Greis um den Dungeon herumgehen sehen? Der sieht gar nicht gut aus ...";
					case 73:
						return "Ich verkaufe, was ich will! Dein Pech, wenn du es nicht magst.";
					case 74:
						return "Warum bist du in einer Zeit wie dieser so aggressiv?";
					case 75:
						return "Ich moechte nicht, dass du meine Sachen kaufst, sondern dass du dir wuenschst, sie zu kaufen.";
					case 76:
						return "Kommt es mir nur so vor oder sind heute Nacht eine Million Zombies draussen?";
					case 77:
						return "Du musst die Welt von diesem Verderben befreien.";
					case 78:
						return "Verlass dich darauf, Terraria braucht dich!";
					case 79:
						return "Der Zahn der Zeit nagt und du alterst nicht gerade wuerdevoll.";
					case 80:
						return "Was soll das heissen: Ich belle mehr als ich beisse?";
					case 81:
						return "Zwei Goblins kommen in einen Stoffladen. Sagt der eine zum anderen: Sitzt du gerne auf Gobelin?";
					case 82:
						return "Ich kann dich nicht hineinlassen, bevor du mich von meinem Fluch befreit hast.";
					case 83:
						return "Komm in der Nacht wieder, wenn du hinein willst.";
					case 84:
						return "Mein Meister kann nicht bei Tageslicht herbeigerufen werden.";
					case 85:
						return "Du bist viel zu schwach, um meinen Fluch zu brechen. Komm wieder, wenn du was aus dir gemacht hast.";
					case 86:
						return "Du armseliger Wicht. So kannst du meinem Meister nicht gegenuebertreten.";
					case 87:
						return "Ich hoffe, du hast mindestens sechs Freunde, die hinter dir stehen.";
					case 88:
						return "Bitte nicht, Fremdling. Du bringst dich nur selbst um.";
					case 89:
						return "Du koenntest tatsaechlich stark genug sein, um meinen Fluch aufzuheben ...";
					case 90:
						return "Fremdling, hast du die Kraft, meinen Meister zu besiegen?";
					case 91:
						return "Bitte! Bezwinge meinen Kerkermeister und befreie mich! Ich flehe dich an!";
					case 92:
						return "Besiege meinen Meister und ich gewaehre dir den Zutritt in den Dungeon.";
					case 93:
						return "Du versuchst, den Ebenstein in den Griff zu kriegen? Warum fuehrst du ihn nicht  mit diesen Explosiva zusammen?";
					case 94:
						return "Heh, hast du hier in der Gegend einen Clown gesehen?";
					case 95:
						return "Genau hier war doch eine Bombe und jetzt kann ich sie nicht finden ...";
					case 96:
						return "Ich habe etwas fuer diese Zombies!";
					case 97:
						return "Sogar " + text2 + " ist scharf auf meine Waren!";
					case 98:
						return "Haettest du lieber das Einschussloch eines Gewehrs oder einer Granate? Das dachte ich mir.";
					case 99:
						return "Ich bin sicher, dass " + text + " dir helfen wird, wenn du versehentlich ein Glied verlierst.";
					case 100:
						return "Warum willst du die Welt reinigen, wenn du sie einfach in die Luft jagen kannst?";
					case 101:
						return "Wenn du das hier in die Badewanne schmeisst und alle Fenster schliesst, durchpustet es deine Nasenhoehlen und  dir fliegen die Ohren weg!";
					case 102:
						return "Moechtest du mal Grillhaehnchen spielen?";
					case 103:
						return "Koenntest du hier unterschreiben, dass du nicht jammern wirst?";
					case 104:
						return "RAUCHEN IST HIER NICHT ERLAUBT!!";
					case 105:
						return "Explosiva sind zur Zeit der Knaller. Kaufe dir jetzt welche!";
					case 106:
						return "Ein schoener Tag, um zu sterben!";
					case 107:
						return "Ich frage mich, was passiert, wenn ich ... (BUMM!) ... Oha, sorry, brauchtest du dieses Bein noch?";
					case 108:
						return "Dynamit, mein ganz spezielles Heilmittelchen - fuer alles, was schmerzt.";
					case 109:
						return "Schau dir meine Waren an - mit hochexplosiven Preisen!";
					case 110:
						return "Ich erinnere mich vage an eine Frau, die ich fesselte und in den Dungeon warf.";
					case 111:
						return "... wir haben ein Problem! Es ist Blutmond!";
					case 112:
						return "Wenn ich juenger waere, wuerde ich mit " + text + " ausgehen wollen. Ich war mal ein Womanizer.";
					case 113:
						return "Dein roter Hut kommt mir bekannt vor ...";
					case 114:
						return "Danke nochmals, dass du mich vom Fluch befreit hast. Es fuehlte sich an, als wenn mich etwas angesprungen und gebissen hat.";
					case 115:
						return "Mama sagte immer, dass ich einen guten Schneider abgeben wuerde.";
					case 116:
						return "Das Leben ist wie ein Kleiderschrank; du weisst nie, was du tragen wirst!";
					case 117:
						return "Natuerlich ist die Stickerei schwierig! Wenn es nicht schwierig waere, wuerde es niemand machen! Das macht es so grossartig.";
					case 118:
						return "Ich weiss alles, was man ueber das Kleidergeschaeft wissen muss.";
					case 119:
						return "Das Leben mit dem Fluch war einsam, deshalb fertigte ich mir aus Leder einen Freund. Ich nannte ihn Wilson.";
					case 120:
						return "Danke fuer die Befreiung, Mensch. Ich wurde gefesselt und von den anderen Goblins hier zurueckgelassen. Man kann sagen, dass wir nicht besonders gut miteinander auskamen.";
					case 121:
						return "Ich kann nicht glauben, dass sie mich fesselten und hier liessen, nur um anzuzeigen, dass sie nicht nach Osten gehen.";
					case 122:
						return "Nun da ich zu den Verstossenen gehoere, darf ich doch meine Stachelkugeln wegwerfen? Es piekt durch die Taschen.";
					case 123:
						return "Suchst du einen Bastelexperten? Dann bin ich dein Goblin!";
					case 124:
						return "Danke fuer deine Hilfe. Jetzt muss ich erst mal aufhoeren, hier ziellos herumzuschreiten. Wir begegnen uns sicher wieder.";
					case 125:
						return "Ich hielt dich fuer groesser.";
					case 126:
						return "Heh ... was macht " + text5 + " so? Hast du ... hast du vielleicht mit ihr gesprochen?";
					case 127:
						return "Waer ein Motor fuer deinen Hut nicht schick? Ich glaube, ich habe einen Motor, der genau hineinpasst.";
					case 128:
						return "Ja, ich hab schon gehoert, dass du Raketen und Laufstiefel magst. Deshalb habe ich ein paar Raketen in deine Laufstiefel montiert.";
					case 129:
						return "Schweigen ist Gold. Klebeband ist Silber.";
					case 130:
						return "Ja! Gold ist staerker als Eisen. Was bringt man den Menschen heutzutage eigentlich bei?";
					case 131:
						return "Diese Helm-Flossen-Kombination sah auf dem Papier viel besser aus.";
					case 132:
						return "Goblins kann man erstaunlich leicht auf die Palme bringen. Die wuerden sogar wegen Kleidern einen Krieg anfangen.";
					case 133:
						return "Um die Wahrheit zu sagen, Goblins sind nicht gerade Genies oder Astroforscher. Aber einige schon.";
					case 134:
						return "Weisst du eigentlich, warum wir alle diese Stachelkugeln mit uns herumtragen? Ich weiss es jedenfalls nicht.";
					case 135:
						return "Meine neuste Erfindung ist fertig! Diese Version explodiert nicht, wenn du sie  heftig anhauchst.";
					case 136:
						return "Goblin-Diebe sind nicht besonders gut in ihrem Job. Sie koennen nicht mal aus einer unverschlossenen Truhe klauen.";
					case 137:
						return "Danke fuer die Rettung, mein Freund! Die Fesseln fingen an, zu scheuern.";
					case 138:
						return "Oh, mein Held!";
					case 139:
						return "Oh, wie heroisch! Danke fuer die Rettung, Lady!";
					case 140:
						return "Oh, wie heroisch! Danke fuer die Rettung, mein Herr!";
					case 141:
						return "Nun da wir uns kennen, kann ich doch bei dir einziehen?";
					case 142:
						return "Hallo, " + str3 + "! Was kann ich heute fuer dich tun?";
					case 143:
						return "Hallo, " + str2 + "! Was kann ich heute fuer dich tun?";
					case 144:
						return "Hallo, " + text4 + "! Was kann ich heute fuer dich tun?";
					case 145:
						return "Hallo, " + text + "! Was kann ich heute fuer dich tun?";
					case 146:
						return "Hallo, " + text5 + "! Was kann ich heute fuer dich tun?";
					case 147:
						return "Hallo, " + text3 + "! Was kann ich heute fuer dich tun?";
					case 148:
						return "Moechtest du, dass ich eine Muenze hinter deinem Ohr hervorziehe? Nein? Gut.";
					case 149:
						return "Moechtest du vielleicht magische Suessigkeiten? Nein? Gut.";
					case 150:
						return "Ich braue eine heisse Zauber-Schokolade, wenn du inter ... Nein? Gut.";
					case 151:
						return "Bist du hier, um einen Blick in meine Kristallkugel zu werfen?";
					case 152:
						return "Hast du dir je einen verzauberten Ring gewuenscht, der Steine in Schleimis verwandelt? Ich auch nicht.";
					case 153:
						return "Jemand sagte mir mal, Freundschaft sei magisch. Das ist laecherlich. Du kannst mit Freundschaft nicht Menschen in Froesche verwandeln.";
					case 154:
						return "Jetzt kann ich deine Zukunft sehen ... Du wirst mir eine Menge Items abkaufen!";
					case 155:
						return "Ich habe mal versucht, eine Engelsstatue zu beleben. Hat ueberhaupt nichts gebracht!";
					case 156:
						return "Danke! Es waere nur eine Frage Zeit gewesen, bis aus mir eines der Skelette hier geworden waere.";
					case 157:
						return "Pass auf, wo du hingehst! Ich war vor einer Weile dort drueben.";
					case 158:
						return "Warte, ich habe es fast geschafft, hier unten Wifi zu installieren.";
					case 159:
						return "Aber ich habe es fast geschafft, hier oben blinkende Lichter anzubringen.";
					case 160:
						return "BEWEGE DICH NICHT. ICH HABE MEINE KONTAKTLINSE VERLOREN.";
					case 161:
						return "Ich moechte nur den Schalter ... Was?!";
					case 162:
						return "Oh, lass mich raten. Nicht genuegend Kabel gekauft, Idiot.";
					case 163:
						return "Koenntest du vielleicht ... bitte? Ja? Gut. Uff!";
					case 164:
						return "Mir gefaellt nicht, wie du mich anschaust. Ich ARBEITE gerade.";
					case 165:
						return string.Concat(new string[]
						{
							"Sag, ",
							Main.player[Main.myPlayer].name,
							", kommst du gerade von ",
							text4,
							"? Hat er vielleicht etwas ueber mich gesagt?"
						});
					case 166:
						return text2 + " spricht immer davon, auf meine Druckplatten zu druecken. Ich habe ihm gesagt, die ist zum Drauftreten.";
					case 167:
						return "Kaufe immer etwas mehr Kabel als benoetigt!";
					case 168:
						return "Hast du dich vergewissert, dass dein Geraet angeschlossen ist?";
					case 169:
						return "Oh, weisst du was dieses Haus noch braucht? Mehr blinkende Lichter.";
					case 170:
						return "Du erkennst den Blutmond an der Rotfaerbung des Himmels. Irgendetwas daran laesst Monster ausschwaermen.";
					case 171:
						return "Weisst du vielleicht, wo Todeskraut ist? Nein, es hat keinen Grund. Ich frag  mich das bloss.";
					case 172:
						return "Wenn du mal hochschauen wuerdest, wuerdest du bemerken, dass der Mond rot ist.";
					case 173:
						return "Du solltest in der Nacht drinnen bleiben. Es ist sehr gefaehrlich, in der Dunkelheit umherzustreifen.";
					case 174:
						return "Sei gegruesst, " + Main.player[Main.myPlayer].name + ". Gibt es etwas, das ich fuer dich tun kann?";
					case 175:
						return "Ich bin hier, um dir zu raten, was du als Naechstes tust. Du solltest immer zu mir kommen, wenn du feststeckst.";
					case 176:
						return "Man sagt, es gibt jemanden, der dir erklaert, wie man in diesem Land ueberlebt ... oh, Moment. Das bin ja ich.";
					case 177:
						return "Du kannst deine Spitzhacke zum Graben im Dreck verwenden und deine Axt zum Holz faellen. Bewege einfach deinen Zeiger ueber das Feld und klicke!";
					case 178:
						return "Wenn du ueberleben willst, musst du Waffen und Zufluchten bauen.  Faelle dazu Baeume und sammele das Holz.";
					case 179:
						return "Druecke ESC zum Aufrufen des Handwerksmenues. Wenn du genuegend Holz hast, stelle eine Werkbank zusammen. Damit kannst du komplexere Sachen herstellen, solange du nahe genug bei ihr   stehst. ";
					case 180:
						return "Du kannst durch Platzieren von Holz oder anderen Bloecken in der Welt eine Zuflucht bauen. Vergiss dabei nicht, auch Waende zu bauen und aufzustellen.";
					case 181:
						return "Wenn du einmal ein Holzschwert hast, kannst du versuchen, etwas Glibber von den Schleimis zu sammeln. Kombiniere Holz und Glibber zur Herstellung einer Fackel.";
					case 182:
						return "Zum Interagieren mit Hintergruenden und platzierten Objekten verwende einen Hammer!";
					case 183:
						return "Du solltest ein bisschen Bergbau betreiben, um Gold zu finden. Du kannst sehr nuetzliche Dinge damit herstellen.";
					case 184:
						return "Jetzt, da du etwas Gold hast, musst du es in einen Barren verwandeln, um damit Items zu erschaffen. Dazu brauchst du einen Hochofen!";
					case 185:
						return "Du kannst einen Hochofen aus Fackeln, Holz und Steinen herstellen. Achte dabei darauf, dass du neben einer Werkbank stehst.";
					case 186:
						return "Zum Herstellen der meisten Sachen aus einem Metallbarren wirst du einen Amboss brauchen.";
					case 187:
						return "Ambosse koennen aus Eisen hergestellt oder von einem Haendler gekauft werden.";
					case 188:
						return "Unterirdisch finden sich Kristallherzen, die verwendet werden koennen, um deine maximale Lebensspanne zu erhoehen. Um sie zu erhalten, benoetigst du einen Hammer.";
					case 189:
						return "Wenn du 10 Sternschnuppen gesammelt hast, koennen sie zur Herstellung eines Items kombiniert werden. Dieses Item erhoeht deine magische Faehigkeit.";
					case 190:
						return "Sterne fallen nachts auf der ganzen Welt herunter. Sie koennen fuer alle moeglichen nuetzlichen Dinge verwendet werden. Wenn du einen erspaeht hast, dann greif ihn dir schnell - sie verschwinden nach Sonnenaufgang.";
					case 191:
						return "Es gibt viele Moeglichkeiten, wie du Menschen dazu bewegen kannst, in unsere Stadt zu ziehen. Sie brauchen zuallererst ein Zuhause.";
					case 192:
						return "Damit ein Raum wie ein Heim wirkt, braucht es eine Tuer, einen Stuhl, einen Tisch und eine Lichtquelle. Achte darauf, dass das Haus auch Waende hat.";
					case 193:
						return "Zwei Menschen werden nicht im selben Haus leben wollen. Ausserdem brauchen sie ein neues Zuhause, wenn ihr Heim zerstoert wurde.";
					case 194:
						return "Du kannst das Behausungsinterface verwenden, um ein Haus zuzuweisen und anzuschauen. Oeffne dein Inventar und klicke auf das Haus-Symbol.";
					case 195:
						return "Wenn du willst, dass ein Haendler einzieht, brauchst du eine Menge Geld. 50 Silbermuenzen sollten aber reichen.";
					case 196:
						return "Damit eine Krankenschwester einzieht, solltest du deine maximale Lebensspanne erhoehen.";
					case 197:
						return "Wenn du ein Gewehr hast, sollte ein Waffenhaendler auftauchen, um dir Munition zu verkaufen.";
					case 198:
						return "Du solltest dich selbst testen, indem du ein starkes Monster besiegst. Das wird die Aufmerksamkeit eines Dryaden erregen.";
					case 199:
						return "Erforsche den Dungeon wirklich sorgfaeltig. Tief unten koennte sich ein Gefangener befinden.";
					case 200:
						return "Vielleicht hat der Greis vom Dungeon Lust, bei uns mitzumachen - jetzt da sein Fluch aufgehoben wurde.";
					case 201:
						return "Behalte alle Bomben, die du findest. Ein Sprengmeister moechte vielleicht einen Blick darauf werfen.";
					case 202:
						return "Sind Goblins wirklich so anders als wir, dass wir nicht in Frieden zusammenleben koennen?";
					case 203:
						return "Ich hoerte, dass ein maechtiger Zauberer in diesen Gebieten lebt. Achte bei deiner naechsten unterirdischen Expedition auf ihn.";
					case 204:
						return "Wenn du Linsen an einem Daemonenaltar kombinieren moechtest, solltest du einen Weg finden koennen, ein maechtiges Monster herbeizurufen. Du solltest jedoch bis zur Nacht warten, bevor du es verwendest.";
					case 205:
						return "Du kannst einen Wurmkoeder mit Verfaultem und Ekelpulver erzeugen. Achte aber darauf, dass du dich vor der Verwendung in einem verderbten Gebiet befindest.";
					case 206:
						return "Daemonenaltaere sind gewoehnlich im Verderben zu finden. Du musst aber nahe bei ihnen stehen, um Items herstellen zu koennen.";
					case 207:
						return "Du kannst einen Enterhaken aus einem Haken und 3 Ketten herstellen.  Die Skelette tief unter der Erde tragen gewoehnlich Haken bei sich. Die Ketten dazu koennen aus Eisenbarren gefertigt werden.";
					case 208:
						return "Wenn du einen Topf siehst, so schlage ihn auf. Toepfe enthalten alle moeglichen Sorten von nuetzlichem Zubehoer.";
					case 209:
						return "Verborgene Schaetze sind auf der ganzen Welt zu finden! Einige erstaunliche Dinge sind auch tief unter der Erde aufzuspueren!";
					case 210:
						return "Beim Zerschlagen einer Schattenkugel faellt mitunter ein Meteor vom Himmel. Schattenkugeln koennen normalerweise in den Schluchten bei verderbten Gebieten gefunden werden.";
					case 211:
						return "Du solltest dich darauf konzentrieren, mehr Kristallherzen zur Erhoehung deiner maximalen Lebensspanne zu sammeln.";
					case 212:
						return "Deine jetzige Ausruestung wird einfach nicht ausreichen. Du musst eine bessere Ruestung fertigen.";
					case 213:
						return "Ich denke, du bist bereit fuer deinen ersten grossen Kampf. Sammele in der Nacht ein paar Linsen von den Augaepfeln und bringe sie zum Daemonenaltar.";
					case 214:
						return "Du solltest dein Leben verlaengern, bevor du die naechste Herausforderung annimmst. 15 Herzen sollten ausreichen.";
					case 215:
						return "Der Ebenstein im Verderben kann durch Verwendung von etwas Pulver des Dryaden gereinigt werden oder er kann durch Explosiva zerstoert werden.";
					case 216:
						return "Dein naechster Schritt ist, die verderbten Schluchten zu untersuchen. Suche nach Schattenkugeln und zerstoere sie!";
					case 217:
						return "Nicht weit von hier gibt es einen alten Dungeon. Jetzt waere ein guter Zeitpunkt, um ihn zu untersuchen.";
					case 218:
						return "Du solltest versuchen, deine Lebensspanne auf das Maximum anzuheben. Versuche, 20 Herzen zu finden.";
					case 219:
						return "Im Dschungel lassen sich viele Schaetze finden, wenn du bereit bist, tief genug zu graben.";
					case 220:
						return "Die Unterwelt entstand aus einem Material, welches sich Hoellenstein nennt. Es ist perfekt geeignet fuer die Produktion von Waffen und Ruestungen.";
					case 221:
						return "Wenn du bereit bist, den Waechter der Unterwelt herauszufordern, musst du ein Opfer bringen. Alles was du brauchst, findest du in der Unterwelt.";
					case 222:
						return "Zerschlage jeden Daemonenaltar, den du findest. Etwas Gutes wird sich ereignen!";
					case 223:
						return "Seelen koennen manchmal von gefallenen Kreaturen an Orten extremen Lichts oder Finsternis aufgesammelt werden.";
					case 224:
						return "Ho ho ho, und eine Flasche ... Egg Nog!";
					case 225:
						return "Pflege zu backen mir ein paar Kekse?";
					case 226:
						return "Was? Sie dachte, ich wäre nicht real?";
					case 227:
						return "Es gelang mir, dein Gesicht wieder annähen. Vorsichtiger sein beim nächsten Mal.";
					case 228:
						return "Das ist wahrscheinlich eine Narbe hinterlassen.";
					case 229:
						return "Alle besser. Ich will nicht, dass du springen mehr Klippen.";
					case 230:
						return "Das tat nicht weh zu schlecht, jetzt hat es getan?";
					case 231:
						return "Als ob im Untergrund leben nicht schon schlimm genug, wie Sie in Zuckungen, während ich schlafe kommen und stehlen meine Kinder.";
					case 232:
						return "Zwischen Ihnen und mir, " + text3 + " ist der einzige, der ich vertraue. Sie ist die einzige hier, die nicht versucht hat, mich zu essen oder benutzen Sie mich in einem Trank.";
					case 233:
						return "Ich versuchte, mich lecken den anderen Tag zu sehen, was die große Sache war, begann alles leuchtend blaue.";
					case 234:
						return "Jedesmal, wenn ich die Farbe Blau sehen, es macht mich depressiv und faul.";
					case 235:
						return "Sie haben nicht gesehen, alle Schweine hier haben Sie? Mein Bruder verlor sein Bein zu eins.";
					case 236:
						return "Jeder in dieser Stadt fühlt sich ein bisschen aus. Ich wachte auf der Tuchmacher Kauen auf meinen Fuß letzte Nacht.";
					case 237:
						return "Ich gebe Ihnen einen Rabatt auf Ihre trägt, wenn Sie " + str4 + " überzeugen können, zu kommen für eine ... Sizing.";
					case 238:
						return "Ich fühle mich wie " + str4 + " ein wenig missverstanden wird, er ist wirklich ein lustiger Kerl.";
					case 240:
						return "Ich weiß nicht, die Truffle Shuffle, so aufhören zu fragen!";
					case 241:
						return "Es ist schon so ein großes Gerücht, das über mich verbreitet ist: 'Wenn du sie nicht schlagen ihn, ihn essen!'";
					case 242:
						return "Oy, was Sie in Ihrem jiminy fluffer haben?";
					case 243:
						return "Sollte ich eine Luft Pirat zu werden? Ich habe als zu einem Luft-Pirat.";
					case 244:
						return "Sei es, wie es wäre, ein Jetpack würden Sie gut zu entsprechen!";
					case 245:
						return "Ich fühle mich ein bisschen ärgerlich wie der spät, so genug mit Ihren Palaver Sie Lump!";
					case 246:
						return "Ich bin mächtig neugierig auf dieser " + str6 + " Kerl. Durch welche Art und Weise der Verbrauch hat er beibehalten, wie Fortbewegung?";
					case 247:
						return "Dass Kapitän Kerl scheint mir zu ziemlich gut über die Bucht 'sein, wenn Sie, was bedeuten wissen!";
					case 248:
						return "Zeigen Sie mir ein paar Gänge!";
					case 249:
						return "Ich mag deine ... Gang. Ist es in Messing kommen?";
					case 250:
						return "Sobald Sie geheiligten Land zu betreten, sehen Sie einen Regenbogen in den Himmel. Ich kann Ihnen mit der Malerei, dass, wenn Sie wollen helfen.";
					case 251:
						return "Schauen Sie sich " + str5 + ". Nun, das ist ein Mädchen, das die Stadt rot malen kann!";
					case 252:
						return "Ich kenne den Unterschied zwischen türkis und blau-grün. Aber ich werde Ihnen nicht sagen.";
					case 253:
						return "Ich bin ganz aus Titan weiß, also nicht einmal fragen.";
					case 254:
						return "Versuchen swirly rosa und lila, es funktioniert, ich schwöre!";
					case 255:
						return "Nein, nein, nein ... Es gibt Unmengen an verschiedenen Grautönen! Verstehen Sie mich nicht begonnen ...";
					case 256:
						return "Ich hoffe, dass es nicht wieder zu regnen, bis diese Farbe trocknet. Das wäre eine Katastrophe!";
					case 257:
						return "Ich bringe euch die reichsten Farben im Austausch für Ihr Reichtum!";
					case 258:
						return "Mein Lieber, was du trägst ist viel zu eintönig. Sie müssen unbedingt eine Lektion in Färben Sie Ihre müden Kleidung zu nehmen!";
					case 259:
						return "Die einzige Art von Holz I Färben stören würde, ist Mahagoni. Färben andere Holz ist so eine Verschwendung. ";
					case 260:
						return "Sie müssen etwas über " + str7 + " zu tun.  Jedes Mal, wenn er kommt hierher, dauert es mir eine Woche, um den Geruch zu steigen!";
					case 261:
						return "Welcher Arzt bin ich? Der Witch Doctor ich bin.";
					case 262:
						return "Das Herz der Magie ist die Natur. Die Natur der Herzen ist Magie.";
					case 263:
						return text + " kann helfen, Ihren Körper zu heilen, aber ich kann Sie verkörpern Heilung.";
					case 264:
						return "Wählen Sie mit Bedacht, " + Main.player[Main.myPlayer].name + ", meine Rohstoffe sind volatil und meine dunklen Künste, geheimnisvoll.";
					case 265:
						return "Wir müssen reden. Es ist ... es geht um Parteien.";
					case 266:
						return "Ich kann mich nicht entscheiden, was ich mehr mag: Partys oder After-Partys.";
					case 267:
						return "Wir sollten ein blinkroot Partei, und wir sollten auch die Einrichtung eines nach der Party.";
					case 268:
						return "Wow, " + Main.player[Main.myPlayer].name + ", Treffen Sie eine abenteuerliche Mann wie Sie macht mich wollen Party!";
					case 269:
						return "Biete eine Disco-Kugel und dann werde ich Ihnen zeigen, wie man feiert.";
					case 270:
						return "Ich ging nach Schweden einmal, sie Partei schwer, warum bist du nicht so?";
					case 271:
						return "Mein Name ist " + str5 + " aber die Leute nennen mich Partei Popper. Ja, ich weiß es nicht, es klingt aber kühl";
					case 272:
						return "Haben Sie Party? Manchmal? Hm, okay, dann können wir reden ...";
					case 273:
						return "Ich bin kein Liebhaber Land, aber es ist besser, geliebt und verloren haben, als nie, überhaupt zu lieben.";
					case 274:
						return "Yo ho ho und eine Flasche... Blinkroots!";
					case 275:
						return "YAR! Lustige sollten Sie erwähnen, Papageien, weil ... ähm ... Was haben wir hier reden?";
					case 276:
						return Main.player[Main.myPlayer].name + ", Sie können eine der schönsten Blick lassies diese hier Kapitän in vielen vierzehn Tagen gesehen hat sein!";
					case 277:
						return "Bleib weg von mir Beute, scallywag ye!";
					case 278:
						return "Was zum Teufel redest du? Moby Dick ist mein!";
					case 279:
						return "*Yarr Blarr Harrdarr*";
					case 280:
						return "Und dann Einheit 492-8 sagte: Wer glaubst du denkst, ich bin, Referat 472-6? HA. HA. HA.";
					case 281:
						return "Meine Expedition Effizienz kritisch wurde reduziert, wenn ein Projektil beeinflusst meine Lok Antrieb.";
					case 282:
						return "Dieser Satz ist falsch, oder ist es?";
					case 283:
						return "Damit 'punk' suchen Küken ein Erfinder ist, eh? Ich glaube, ich könnte ihr zeigen, eine Sache oder zwei!";
					case 284:
						return "Sicher, mir und " + str7 + " sind Kumpels, aber ich hasse es, wenn seinem Papagei macht sein Geschäft auf mich. Das Zeug ist ätzend!";
					case 285:
						return "Ich baute mir einen Vorgeschmack Mechanismus, so kann ich einige Bier trinken!";
					case 286:
						return "Manchmal komme ich aus ein bisschen ... Holen Sie sich das? ein bisschen?";
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						switch (l)
						{
						case 1:
							return "Spero che tra noi e l'Occhio di Cthulhu non ci sia solo un bimbo scarno come te.";
						case 2:
							return "Guarda la pessima armatura che indossi. Faresti meglio a comprare più pozioni curative.";
						case 3:
							return "Ho la sensazione che una presenza malvagia mi stia guardando.";
						case 4:
							return "Spada batte carta! Prendine una oggi.";
						case 5:
							return "Desideri mele? Carote? Ananas? Abbiamo delle fiaccole.";
						case 6:
							return "Bella mattina, no? C'era qualcosa di cui avevi bisogno?";
						case 7:
							return "Presto si farà notte, amico. Fai le tue scelte finché puoi.";
						case 8:
							return "Non immagini quanti blocchi di terra si vendono oltreoceano.";
						case 9:
							return "Ah, racconteranno storie di " + Main.player[Main.myPlayer].name + " un giorno... belle storie ovviamente.";
						case 10:
							return "Guarda i miei blocchi di terra: sono super terrosi.";
						case 11:
							return "Ragazzo, quel sole scotta! Ho un'armatura perfettamente ventilata.";
						case 12:
							return "Il sole è alto, ma i miei prezzi no.";
						case 13:
							return string.Concat(new string[]
							{
								"Fantastico. Sento ",
								text5,
								" e ",
								text,
								" discutere da qui."
							});
						case 14:
							return "Hai visto Chith... Shith... Chat... Il grande occhio?";
						case 15:
							return "Ehi, questa casa è sicura, no? Giusto? " + Main.player[Main.myPlayer].name + "?";
						case 16:
							return "Nemmeno una luna di sangue può arrestare il capitalismo. Facciamo un po' di affari.";
						case 17:
							return "Tieni d'occhio il premio, compra una lente!";
						case 18:
							return "Kosh, kapleck Mog. Oh scusa, in klingon significa 'Compra qualcosa o muori.'";
						case 19:
							return "Sei, " + Main.player[Main.myPlayer].name + ", vero? Ho sentito belle cose su di te!";
						case 20:
							return "Sento che c'è un tesoro segreto... non importa.";
						case 21:
							return "Una statua d'angelo, dici? Scusa, non tratto cianfrusaglie.";
						case 22:
							return "L'ultimo ragazzo venuto qui mi lasciò delle cianfrusaglie... o meglio... tesori!";
						case 23:
							return "Mi chiedo se la luna sia fatta di formaggio... Uhm, cosa? Oh sì, compra qualcosa!";
						case 24:
							return "Hai detto oro? Te lo tolgo io.";
						case 25:
							return "Niente sangue su di me.";
						case 26:
							return "Sbrigati e smettila di sanguinare.";
						case 27:
							return "Se stai per morire, fallo fuori.";
						case 28:
							return "Cosa vorresti insinuare?!";
						case 29:
							return "Quel tuo tono non mi piace.";
						case 30:
							return "Che ci fai qui? Se non sanguini, non devi stare qui. Via.";
						case 31:
							return "COSA?!";
						case 32:
							return "Hai visto il vecchio che gira intorno alla segreta? Sembra agitato.";
						case 33:
							return "Vorrei che " + str2 + " fosse più attento.  Mi sto stancando di dovergli ricucire gli arti ogni giorno.";
						case 34:
							return "Ehi, " + text2 + " ha detto di dover andare dal dottore per qualche ragione? Solo per chiedere.";
						case 35:
							return "Devo parlare seriamente con " + str3 + ". Quante volte a settimana si può venire con gravi ustioni da lava?";
						case 36:
							return "Penso che tu stia meglio così.";
						case 37:
							return "Ehm... Che ti è successo alla faccia?";
						case 38:
							return "SANTO CIELO! Sono brava, ma non fino a questo punto.";
						case 39:
							return "Cari amici, siamo qui riuniti, oggi, per congedarci... Oh, ti riprenderai.";
						case 40:
							return "Hai lasciato il braccio laggiù. Te lo prendo io...";
						case 41:
							return "Smettila di fare il bambino! Ho visto di peggio.";
						case 42:
							return "Serviranno dei punti!";
						case 43:
							return "Di nuovo problemi con quei bulli?";
						case 44:
							return "Aspetta, ho i cerotti con i cartoni animati da qualche parte.";
						case 45:
							return "Cammina, " + Main.player[Main.myPlayer].name + " starai bene. Fiuu.";
						case 46:
							return "Ti fa male quando lo fai? Non farlo.";
						case 47:
							return "Sembri mezzo digerito. Hai di nuovo inseguito gli slime?";
						case 48:
							return "Gira la testa e tossisci.";
						case 49:
							return "Non è la più grande ferita che abbia mai visto... Ne ho viste certamente di più grandi.";
						case 50:
							return "Vuoi un lecca-lecca?";
						case 51:
							return "Dimmi dove ti fa male.";
						case 52:
							return "Scusa, ma non puoi permetterti di avermi.";
						case 53:
							return "Avrò bisogno di più soldi.";
						case 54:
							return "Sai che non lavoro gratis.";
						case 55:
							return "Non faccio lieti fini.";
						case 56:
							return "Non posso fare più nulla per te senza chirurgia plastica.";
						case 57:
							return "Smettila di sprecare il mio tempo.";
						case 58:
							return "Ho sentito che c'è una bambola molto simile a " + str3 + " nel sottomondo. Vorrei metterci dei proiettili.";
						case 59:
							return "Veloce! Ho un appuntamento con " + text + " tra un'ora.";
						case 60:
							return "Voglio quello che vende " + text + ". In che senso, non vende niente?";
						case 61:
							return text3 + " è uno spettacolo. Peccato sia così bigotta.";
						case 62:
							return "Lascia stare " + str2 + ", ho tutto ciò che ti serve qui.";
						case 63:
							return "Qual è il problema di " + str2 + "? Almeno lo sa che vendiamo oggetti diversi?";
						case 64:
							return "Beh, è una bella notte per non parlare con nessuno, non credi, " + Main.player[Main.myPlayer].name + "?";
						case 65:
							return "Mi piacciono le notti come questa. Non mancano mai cose da demolire!";
						case 66:
							return "Vedo che stai addocchiando il Minishark... Meglio che non ti dica di cosa è fatto.";
						case 67:
							return "Ehi, non è un film, amico. Le munizioni sono extra.";
						case 68:
							return "Giù le mani dalla mia pistola, amico!";
						case 69:
							return "Hai provato a usare la polvere purificatrice sulla pietra d'ebano della distruzione?";
						case 70:
							return "Vorrei che " + text2 + " la smettesse di flirtare con me. Non sa che ho 500 anni?";
						case 71:
							return "Perché " + str + " continua a vendermi statue d'angelo? Lo sanno tutti che non servono a nulla.";
						case 72:
							return "Hai visto il vecchio che gira intorno alla segreta? Non ha per niente un bell'aspetto...";
						case 73:
							return "Vendo ciò che voglio! Se non ti piace, pazienza.";
						case 74:
							return "Perché devi essere così conflittuale in un momento come questo?";
						case 75:
							return "Non voglio che tu compri la mia roba. Voglio che tu desideri comprarla, ok?";
						case 76:
							return "Amico, sbaglio o ci sono tipo un milione di zombi in giro, stanotte?";
						case 77:
							return "Devi purificare il mondo da questa empietà.";
						case 78:
							return "Sii cauto: Terraria ha bisogno di te!";
						case 79:
							return "Il tempo vola e tu, ahimé, non stai invecchiando molto bene.";
						case 80:
							return "Cos'è questa storia di me che abbaio, ma non mordo?";
						case 81:
							return "Due goblin entrano in un bar e uno dice all'altro: 'Vuoi un calice di birra?!' ";
						case 82:
							return "Non posso farti entrare finché non mi libererai dalla maledizione.";
						case 83:
							return "Torna di notte se vuoi entrare.";
						case 84:
							return "Il mio capo non può essere convocato di giorno.";
						case 85:
							return "Sei decisamente troppo debole per sconfiggere la mia maledizione. Torna quando sarai più forte.";
						case 86:
							return "Tu, pazzo patetico. Non puoi sperare di affrontare il mio padrone ora come ora.";
						case 87:
							return "Spero che tu abbia almeno sei amici dietro di te.";
						case 88:
							return "No, ti prego, straniero. Finirai per essere ucciso.";
						case 89:
							return "Potresti essere abbastanza forte da liberarmi dalla mia maledizione...";
						case 90:
							return "Straniero, hai la forza per sconfiggere il mio padrone?";
						case 91:
							return "Ti prego! Sconfiggi chi mi ha catturato e liberami, ti supplico!";
						case 92:
							return "Sconfiggi il mio padrone e ti farò passare nella segreta.";
						case 93:
							return "Stai provando a superare quella pietra d'ebano, eh? Perché non metterci questi esplosivi!";
						case 94:
							return "Ehi, hai visto un clown in giro?";
						case 95:
							return "C'era una bomba qui e ora non riesco a trovarla...";
						case 96:
							return "Ho qualcosa per quegli zombi, altroché!";
						case 97:
							return "Persino " + text2 + " vuole ciò che sto vendendo!";
						case 98:
							return "Preferisci avere un buco da proiettile o granata? Ecco ciò che pensavo.";
						case 99:
							return "Sono sicuro che " + text + " ti aiuterà se per caso perderai un arto.";
						case 100:
							return "Perché purificare il mondo quando potresti farlo saltare in aria?";
						case 101:
							return "Se verserai questo nella vasca da bagno e chiuderai tutte le finestre, ti pulirà le cavità nasali e ti sturerà le orecchie.";
						case 102:
							return "Vuoi giocare a Esplodi-Pollo?";
						case 103:
							return "Ehi, potresti firmare questa rinuncia al dolore?";
						case 104:
							return "VIETATO FUMARE QUI DENTRO!!";
						case 105:
							return "Gli esplosivi vanno a ruba di questi tempi. Comprane un po'!";
						case 106:
							return "È un buon giorno per morire!";
						case 107:
							return "Mi chiedo cosa succederà se io... (BUM!) ... Oh, scusa, ti serviva quella gamba?";
						case 108:
							return "La dinamite, la mia cura speciale per tutto ciò che ti affligge.";
						case 109:
							return "Guarda i miei prodotti: hanno prezzi esplosivi!";
						case 110:
							return "Continuo ad avere vaghi ricordi di aver legato una donna e averla gettata in una segreta.";
						case 111:
							return "... abbiamo un problema! C'è una luna di sangue là fuori!";
						case 112:
							return "Fossi più giovane, chiederei a NURSE di uscire. Avevo un successone con le ragazze.";
						case 113:
							return "Quel tuo cappello rosso mi sembra familiare...";
						case 114:
							return "Grazie ancora per avermi liberato dalla maledizione. Sentivo come qualcosa che saltava e mi mordeva.";
						case 115:
							return "Mia mamma mi diceva sempre che sarei stato un grande sarto.";
						case 116:
							return "La vita è come una scatola di vestiti; non sai mai ciò che indosserai!";
						case 117:
							return "Ricamare è difficile! Se non fosse così, nessuno lo farebbe! È ciò che lo rende fantastico.";
						case 118:
							return "So tutto ciò che c'è da sapere riguardo alle attività di sartoria.";
						case 119:
							return "Nella maledizione ero solo, perciò una volta mi creai un amico di pelle. Lo chiamai Wilson.";
						case 120:
							return "Grazie per avermi liberato, umano. Sono stato legato e lasciato qui da altri goblin. Si potrebbe dire che non andavamo proprio d'accordo.";
						case 121:
							return "Non posso credere che mi hanno legato e lasciato qui soltanto per far notare che non andavano verso est!";
						case 122:
							return "Ora che sono un escluso, posso buttar via le palle chiodate? Mi fanno male le tasche.";
						case 123:
							return "Cerchi un esperto di gadget? Sono il tuo goblin!";
						case 124:
							return "Grazie per l'aiuto. Ora devo smetterla di gironzolare senza scopo qui attorno. Sono sicuro che ci incontreremo di nuovo.";
						case 125:
							return "Pensavo fossi più alto.";
						case 126:
							return "Ehi... cosa sta combinando " + text5 + "? Hai... hai parlato con lei, per caso?";
						case 127:
							return "Ehi, il tuo cappello ha bisogno di un motore? Credo di averne uno perfettamente adatto.";
						case 128:
							return "Ciao, ho sentito che ti piacciono i razzi e gli stivali da corsa, così ho messo dei missili nei tuoi stivali.";
						case 129:
							return "Il silenzio è d'oro. Il nastro adesivo è d'argento.";
						case 130:
							return "SÌ, l'oro è più forte del ferro. Cosa insegnano al giorno d'oggi a questi umani?";
						case 131:
							return "Sai, quella combinazione casco da minatore-pinne era un'idea molto migliore sulla carta.";
						case 132:
							return "I goblin si irritano molto facilmente. Potrebbero persino scatenare una guerra per i tessuti!";
						case 133:
							return "A dire il vero, la maggior parte dei goblin non sono ingegneri aerospaziali. Beh, alcuni sì.";
						case 134:
							return "Sai perché noi tutti ci portiamo dietro queste palle chiodate? Perché io non lo faccio.";
						case 135:
							return "Ho appena finito la mia ultima creazione! Questa versione non esplode violentemente se ci si respira troppo forte sopra.";
						case 136:
							return "I ladri goblin non sono molto furbi. Non sanno nemmeno rubare da una cassa aperta!";
						case 137:
							return "Grazie per avermi salvato, amico! Questi legacci iniziavano a irritarmi.";
						case 138:
							return "Ohh, mio eroe!";
						case 139:
							return "Oh, eroica! Grazie per avermi salvato, ragazza!";
						case 140:
							return "Oh, eroico!  Grazie per avermi salvato, ragazzo!";
						case 141:
							return "Ora che ci conosciamo, posso trasferirmi da te?";
						case 142:
							return "Bene, ciao, " + str3 + "! Cosa posso fare per te oggi?";
						case 143:
							return "Bene, ciao, " + str2 + "! Cosa posso fare per te oggi?";
						case 144:
							return "Bene, ciao, " + text4 + "! Cosa posso fare per te oggi?";
						case 145:
							return "Bene, ciao, " + text + "! Cosa posso fare per te oggi?";
						case 146:
							return "Bene, ciao, " + text5 + "! Cosa posso fare per te oggi?";
						case 147:
							return "Bene, ciao, " + text3 + "! Cosa posso fare per te oggi?";
						case 148:
							return "Vuoi che tiri fuori una moneta da dietro il tuo orecchio? No? Ok.";
						case 149:
							return "Vuoi dei dolci magici? No? Ok.";
						case 150:
							return "Posso preparare una cioccalata calda proprio deliziosa se sei inter...No? Ok.";
						case 151:
							return "Sei qui per dare un'ochiata alla mia sfera di cristallo?";
						case 152:
							return "Mai desiderato un anello incantato che trasforma le rocce in slime? Neanch'io.";
						case 153:
							return "Una volta qualcuno mi disse che l'amicizia è magica. Sciocchezze. Non puoi trasformare le persone in rane con l'amicizia.";
						case 154:
							return "Ora vedo il tuo futuro... Comprerai molti prodotti da me!";
						case 155:
							return "Una volta ho provato a dare la vita a una statua d'angelo. Invano.";
						case 156:
							return "Grazie! Era solo questione di tempo prima che facessi la stessa fine degli scheletri laggiù.";
						case 157:
							return "Ehi, guarda dove stai andando! Ero laggiù un attimo fa!";
						case 158:
							return "Resisti, sono quasi riuscita a portare fin qui il wifi.";
						case 159:
							return "Ma ero quasi riuscita a mettere luci intermettenti quassù!";
						case 160:
							return "NON MUOVERTI. MI È CADUTA UNA LENTE A CONTATTO.";
						case 161:
							return "Tutto ciò che voglio è che l'interruttore faccia... Cosa?!";
						case 162:
							return "Oh, fammi indovinare. Non hai comprato abbastanza filo metallico. Idiota.";
						case 163:
							return "Soltanto-potresti soltanto... Per favore? Ok? Ok. Puah.";
						case 164:
							return "Non apprezzo il modo in cui mi guardi. Sto LAVORANDO ora.";
						case 165:
							return string.Concat(new string[]
							{
								"Ehi, ",
								Main.player[Main.myPlayer].name,
								", sei appena stato da ",
								text4,
								"? Ha detto qualcosa di me, per caso?"
							});
						case 166:
							return text2 + " continua a dire di aver schiacciato la mia piastra a pressione. Gli ho spiegato che serve proprio a quello.";
						case 167:
							return "Compra sempre più filo metallico di quello necessario!";
						case 168:
							return "Ti sei assicurato che il tuo dispositivo fosse collegato?";
						case 169:
							return "Oh, sai di cosa ha bisogno questa casa? Di più luci intermittenti.";
						case 170:
							return "Si può dire che appare una luna di sangue quando il cielo si fa rosso.  C'è qualcosa in lei che ridesta i mostri.";
						case 171:
							return "Ehi, amico, sai dov'è un po' di erba della morte? Scusa, me lo stavo solo chiedendo, tutto qua.";
						case 172:
							return "Se dovessi alzare lo sguardo, vedresti che la luna è rossa ora.";
						case 173:
							return "Dovresti stare dentro di notte. Sai, è molto pericoloso girare al buio.";
						case 174:
							return "Saluti, " + Main.player[Main.myPlayer].name + ". Come posso esserti utile?";
						case 175:
							return "Sono qui per darti consigli su cosa fare dopo. Ti consiglio di parlare con me ogni volta che sarai nei guai.";
						case 176:
							return "Si dice ci sia una persona che ti dirà come sopravvivere in questa terra... Aspetta. Sono io.";
						case 177:
							return "Puoi utilizzare il piccone per scavare nell'immondizia e l'ascia per abbattere gli alberi. Posiziona il cursore  sulla mattonella e clicca!";
						case 178:
							return "Se vuoi sopravvivere, dovrai creare armi e un riparo. Inizia abbattendo gli alberi e raccogliendo legna.";
						case 179:
							return "Clicca su ESC per accedere al menu artigianato. Quando avrai abbastanza legna, crea un banco di lavoro. Così potrai creare oggetti più sofisticati, finché sarai vicino ad esso.";
						case 180:
							return "Puoi costruirti un riparo con legna o altri blocchi nel mondo. Non dimenticare di creare e sistemare le pareti.";
						case 181:
							return "Una volta che possiederai una spada di legno, puoi provare a raccogliere gel dagli slime. Metti assieme legna e gel per creare una fiaccola!";
						case 182:
							return "Per interagire con gli ambienti e gli oggetti posizionati, usa un martello!";
						case 183:
							return "Devi praticare un po' di estrazione per trovare minerale metallico. Puoi crearci oggetti molto utili.";
						case 184:
							return "Ora che hai un po' di minerale, dovrai trasformarlo in una sbarra per poterci fare degli oggetti. Per questo serve un forno!";
						case 185:
							return "Puoi creare una forno con fiaccole, legna e pietra. Assicurati di essere vicino a un banco di lavoro.";
						case 186:
							return "Avrai bisogno di un'incudine per creare la maggior parte degli oggetti dalle sbarre metalliche.";
						case 187:
							return "Le incudini possono essere create con del ferro o acquistate da un mercante.";
						case 188:
							return "Sottoterra vi sono cuori di cristallo che possono essere utilizzati per allungare la tua vita massima. Dovrai avere un martello per ottenerli.";
						case 189:
							return "Se raccoglierai 10 stelle cadenti, potrai combinarle per creare un oggetto che aumenterà le tue abilità magiche.";
						case 190:
							return "Le stelle cadono sul mondo di notte. Possono essere utilizzate per ogni tipo di oggetto utile.  Se ne vedi una, cerca di afferrarla, poiché scomparirà dopo l'alba.";
						case 191:
							return "Ci sono diversi modi per convincere le persone a trasferirsi nella tua città. Di sicuro dovranno avere una casa in cui vivere.";
						case 192:
							return "Perché una stanza sia considerata una casa, ha bisogno di una porta, una sedia, un tavolo e una fonte luminosa. Assicurati che la casa abbia anche delle pareti.";
						case 193:
							return "Due persone non possono vivere nella stessa casa. Inoltre, se la loro casa verrà distrutta, cercheranno un nuovo posto in cui vivere.";
						case 194:
							return "Puoi utilizzare l'interfaccia abitazioni per visualizzare e assegnare gli alloggi. Apri l'inventario e clicca sull'icona della casa.";
						case 195:
							return "Se vuoi che un mercante si trasferisca, dovrai raccogliere molto denaro. Servono 50 monete d'argento!";
						case 196:
							return "Se vuoi che un'infermiera si traferisca, dovrai essere intenzionato ad allungare la tua vita massima.";
						case 197:
							return "Se avessi una pistola, scommetto che potrebbe apparire un mercante d'armi per venderti munizioni!";
						case 198:
							return "Dovresti metterti alla prova sconfiggendo un mostro forte. Così attirerai l'attenzione di una driade.";
						case 199:
							return "Esplora attentamente tutta la segreta. Potrebbero esserci prigionieri nelle zone più profonde.";
						case 200:
							return "Forse il vecchio della segreta vorrebbe unirsi a noi, ora che la maledizione è terminata.";
						case 201:
							return "Arraffa tutte le bombe che potresti trovare. Un esperto in demolizioni potrebbe volerci dare un'occhiata.";
						case 202:
							return "I goblin sono così diversi da noi che non possiamo convivere in maniera pacifica?";
						case 203:
							return "Ho sentito che c'era un potente stregone da queste parti. Tienilo d'occhio la prossima volta che scenderai sottoterra.";
						case 204:
							return "Se combinerai le lenti a un altare demoniaco, potresti trovare un modo per chiamare un mostro potente. Ma aspetta che si faccia buio prima di utilizzarlo.";
						case 205:
							return "Puoi creare un'esca di vermi con pezzi marci e polvere disgustosa. Assicurati di essere in una zona distrutta prima di utilizzarla.";
						case 206:
							return "Gli altari demoniaci si trovano generalmente nella distruzione. Dovrai essere vicino ad essi per creare oggetti.";
						case 207:
							return "Puoi creare un rampino con un uncino e tre catene. Gli scheletri sottoterra di solito trasportano gli uncini, mentre le catene possono essere ricavate dalle sbarre di ferro.";
						case 208:
							return "Se vedi un vaso, demoliscilo e aprilo. Contiene una serie di utili provviste.";
						case 209:
							return "Vi sono tesori nascosti in tutto il mondo. Alcuni oggetti fantastici si possono trovare nelle zone sotterranee più profonde.";
						case 210:
							return "Demolire un'orbita d'ombra provocherà a volte la caduta di un meteorite dal cielo. Le orbite d'ombra si possono generalmente trovare negli abissi attorno alle zone distrutte.";
						case 211:
							return "Dovresti cercare di raccogliere più cuori di cristallo per allungare la tua vita massima.";
						case 212:
							return "La tua attrezzatura attuale non è sufficiente. Hai bisogno di un'armatura migliore.";
						case 213:
							return "Credo tu sia pronto per la tua prima grande battaglia. Raccogli lenti dai bulbi oculari di notte e portale a un altare demoniaco.";
						case 214:
							return "Allunga la tua vita prima di affrontare la prossima sfida. Quindici cuori dovrebbero bastare.";
						case 215:
							return "La pietra d'ebano nella distruzione può essere purificata con polvere di driade o distrutta con esplosivi.";
						case 216:
							return "La prossima tappa consiste nell'esplorazione degli abissi distrutti. Trova e distruggi ogni orbita d'ombra che incontrerai.";
						case 217:
							return "C'è una vecchia segreta non lontano da qui. Sarebbe il momento giusto per visitarla.";
						case 218:
							return "Dovresti tentare di massimizzare la vita disponibile. Prova a raccogliere venti cuori.";
						case 219:
							return "Ci sono molti tesori da scroprire nella giungla, se sei disposto a scavare abbastanza in profondità.";
						case 220:
							return "Il sottomondo è composto da un materiale detto pietra infernale, perfetto per creare armi e armatura.";
						case 221:
							return "Quando sarai pronto a sfidare il custode del sottomondo, dovrai fare un enorme sacrificio. Tutto ciò che ti serve si trova nel mondo di sotto.";
						case 222:
							return "Assicurati di demolire ogni altare demoniaco che incontri. Se lo farai, ti succederà qualcosa di bello!";
						case 223:
							return "A volte è possibile riunire le anime delle creature morte in luoghi estremamente luminosi o bui.";
						case 224:
							return "Ho ho ho e una bottiglia di ... Egg Nog!";
						case 225:
							return "Cura di cuocere dei biscotti me?";
						case 226:
							return "Che cosa? Credevi che non era reale?";
						case 227:
							return "Sono riuscito a cucire la tua faccia di nuovo. Essere più attento la prossima volta.";
						case 228:
							return "Che probabilmente lascerà una cicatrice.";
						case 229:
							return "Tutti i migliori. Non voglio vederti saltare fuori più scogliere.";
						case 230:
							return "Che non ha fatto male troppo male, ora lo ha fatto?";
						case 231:
							return "Come se vivere sottoterra non bastasse, cretini come si arriva in mentre dormo e rubato i miei figli.";
						case 232:
							return "Tra me e te, " + text3 + " è l'unico di cui mi fido. Lei è l'unico qui che non ha cercato di mangiare me o utilizzare in una pozione.";
						case 233:
							return "Ho provato a leccare me l'altro giorno per vedere che cosa il grosso problema era, tutto ha cominciato blu incandescente. ";
						case 234:
							return "Ogni volta che vedo il colore blu, mi rende depresso e pigro.";
						case 235:
							return "Non hai visto tutti i suini da queste parti hanno di te? Mio fratello ha perso la gamba a uno.";
						case 236:
							return "Ognuno in questa città si sente un po 'fuori. Mi sono svegliato al clothier masticare sul mio piede ieri sera.";
						case 237:
							return "Ti darò uno sconto sul tuo capo se si può convincere " + str4 + " di venire per un ... dimensionamento.";
						case 238:
							return "Mi sento come " + str4 + " è un po 'incompreso, lui è davvero un tipo divertente.";
						case 240:
							return "Non so il 'Tartufo Shuffle', così smettere di chiedere! ";
						case 241:
							return "C'è stato un enorme diceria che viene diffuso su di me, 'Se non lo puoi battere, lui mangiare!'";
						case 242:
							return "Oy, che cosa avete nel vostro Fluffer Grillo Parlante?";
						case 243:
							return "Devo diventare un pirata dell'aria? Ho pensato di diventare un pirata dell'aria.";
						case 244:
							return "Che si tratti di cosa sarebbe, un jetpack che si adattano bene!";
						case 245:
							return "Mi sento un po 'scontroso come di ritardo, in modo sufficiente con il tuo chiacchiere si ragamuffin!";
						case 246:
							return "Sono possente curioso di quel " + str6 + " compagno. Con che tipo di consumo fa a mantenere tale locomozione?";
						case 247:
							return "Quel tipo capitano mi sembra di essere 'abbastanza bene sulla baia' se sai cosa vuol dire! ";
						case 248:
							return "Mostrami alcuni ingranaggi! ";
						case 249:
							return "Mi piace il tuo ... ingranaggio. Le viene in ottone?";
						case 250:
							return "Una volta che si entra in terra consacrata, si vedrà un arcobaleno nel cielo. Io posso aiutarti con la pittura che, se si vuole.";
						case 251:
							return "Scopri " + str5 + ". Ora che è una ragazza che può dipingere di rosso la città!";
						case 252:
							return "Conosco la differenza tra il turchese e blu-verde. Ma io non lo dirò.";
						case 253:
							return "Sono tutti fuori di bianco di titanio, quindi non hanno nemmeno chiedere.";
						case 254:
							return "Prova swirly rosa e viola, funziona, lo giuro!";
						case 255:
							return "No, no, no ... Ci sono tonnellate di diversi grigi! Non fatemi parlare ...";
						case 256:
							return "Spero che non piova di nuovo fino a quando questa vernice si asciuga. Sarebbe un disastro! ";
						case 257:
							return "Vi porto i colori più ricchi in cambio della tua ricchezza!";
						case 258:
							return "Mio caro, quello che indossi è troppo triste. È assolutamente necessario prendere una lezione di tintura vostro abbigliamento stanco!";
						case 259:
							return "L'unico tipo di legno io mi preoccuperei di tintura è mogano ricco. Tintura qualsiasi altro legno è un tale spreco.";
						case 260:
							return "Devi fare qualcosa per " + str7 + ".  Ogni volta che viene qui, mi ci vuole una settimana per ottenere l'odore di sconto!";
						case 261:
							return "Quale dottore sono io? Il Witch Doctor sono.";
						case 262:
							return "Il cuore della magia è la natura. La natura del cuore è magia.";
						case 263:
							return text + " può aiutare a guarire il corpo, ma posso farti incarnano guarigione.";
						case 264:
							return "Scegli con saggezza, " + Main.player[Main.myPlayer].name + ", le mie materie prime sono volatili e la mia arte oscura, misteriosa.";
						case 265:
							return "Dobbiamo parlare. E '... si tratta di feste.";
						case 266:
							return "Non riesco a decidere quello che mi piace di più: feste, o post-feste.";
						case 267:
							return "Dovremmo creare un gruppo di blinkroot, e dovremmo anche istituito una festa dopo.";
						case 268:
							return "Wow, " + Main.player[Main.myPlayer].name + ", incontrare un uomo avventuroso come te mi fa venire voglia di festa!";
						case 269:
							return "Mettere su una palla da discoteca e poi ti faccio vedere come far festa.";
						case 270:
							return "Sono andato alla Svezia una volta, party hard, perche 'non ti piace?";
						case 271:
							return "Il mio nome di " + str5 + " ma le persone mi chiamano partito popper. Si. Non lo so, suona freddo comunque.";
						case 272:
							return "Ti partito? A volte? Hm, ok allora possiamo parlare...";
						case 273:
							return "Io non sono un amante del territorio, ma è meglio aver amato e perso che non amare affatto.";
						case 274:
							return "Yo ho ho e una bottiglia di ...blinkroots!";
						case 275:
							return "YAR!  Divertente si dovrebbe essere accennando pappagalli perché ... ehm ... cosa stavamo parlando?";
						case 276:
							return Main.player[Main.myPlayer].name + ", Siete di una delle più belle fanciulle che cercano questo qui capitano visto in molti una quindicina di giorni!";
						case 277:
							return "Rimanere fuori mi bottino, si scallywag!";
						case 278:
							return "Cosa diamine stai parlando? Moby Dick è mio!";
						case 279:
							return "*Yarr Blarr Harrdarr*";
						case 280:
							return "E poi Unità 492-8 disse: 'Chi pensi che io sono, Unità 472-6?' HA. HA. HA.";
						case 281:
							return "Il mio rendimento spedizione è stata criticamente ridotta quando un proiettile influenzato la mia locomotiva attuatore.";
						case 282:
							return "Questa frase è falsa, o è?";
						case 283:
							return "Così che il 'punk' cercando pulcino è un inventore, eh? Penso che avrei potuto mostrare una cosa o due!";
						case 284:
							return "Certo, io e " + str7 + " sono amici, ma odio quando il suo pappagallo fa il suo lavoro su di me. Corrosiva che roba!";
						case 285:
							return "Io stesso ho costruito un meccanismo di gusto, così posso bere qualche birra!";
						case 286:
							return "A volte mi si stacca un po '... Capito? un po '?";
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							switch (l)
							{
							case 1:
								return "Rassurez-moi, on ne doit pas compter que sur vous pour nous protéger de l'œil de Cthulhu.";
							case 2:
								return "Regardez-moi cette armure bas de gamme que vous avez sur le dos. Vous avez intérêt à acheter davantage de potions de soin.";
							case 3:
								return "Je sens une présence maléfique m'observer.";
							case 4:
								return "L'épée est plus forte que la plume. Achetez-en une dès aujourd'hui.";
							case 5:
								return "Vous voulez des pommes ? Vous voulez des poires ? Vous voulez des scoubidous ? Nous avons des torches.";
							case 6:
								return "Quelle belle matinée, n'est-ce pas ? Vous voulez quelque chose?";
							case 7:
								return "La nuit va bientôt tomber, alors faites votre choix tant qu'il est encore temps.";
							case 8:
								return "Vous n'avez pas idée du nombre de blocs de terre qui sont vendus à l'étranger.";
							case 9:
								return "Un jour, des légendes étonnantes circuleront sur " + Main.player[Main.myPlayer].name + ".";
							case 10:
								return "Jetez un œil à mes blocs de terre, c'est de la terre de premier choix.";
							case 11:
								return "Voyez comme le soleil tape. J'ai des armures parfaitement ventilées.";
							case 12:
								return "Le soleil est haut dans le ciel, mais mes prix sont bas.";
							case 13:
								return string.Concat(new string[]
								{
									"Oh, génial ! J'entends ",
									text5,
									" et ",
									text,
									" se disputer d'ici."
								});
							case 14:
								return "Avez-vous vu Chult... Cthuch... Le truc avec le gros œil?";
							case 15:
								return "Cette maison est sûre, n'est-ce pas ? Hein, " + Main.player[Main.myPlayer].name + "?";
							case 16:
								return "Même la Lune de Sang ne peut arrêter le capitalisme. Alors, faisons affaires.";
							case 17:
								return "Pour garder un œil sur les prix, achetez une lentille.";
							case 18:
								return "Kosh, kapleck Mog. Oh désolé, ça veut dire « Achetez-moi quelque chose ou allez au diable » en klingon.";
							case 19:
								return "Vous êtes " + Main.player[Main.myPlayer].name + ", n'est-ce pas ? J'ai entendu de bonnes choses à votre sujet.";
							case 20:
								return "J'ai entendu dire qu'il y avait un trésor caché... Bon, laissez tomber.";
							case 21:
								return "Une statue d'ange, dites-vous ? Désolé, ce n'est pas une boutique de souvenirs ici.";
							case 22:
								return "Le dernier type qui est venu m'a vendu quelques sales... Je veux dire, de vrais trésors.";
							case 23:
								return "Je me demande si la lune est un gros fromage... Hein, quoi ? Oh , bien sûr, achetez ce que vous voulez!";
							case 24:
								return "Vous avez dit or ? Je vais vous en débarrasser.";
							case 25:
								return "Faites attention de ne pas me mettre du sang partout.";
							case 26:
								return "Dépêchez-vous et arrêtez de saigner.";
							case 27:
								return "Si vous comptez mourir, faites-le dehors.";
							case 28:
								return "Qu'est-ce que ça veut dire ?";
							case 29:
								return "Je n'aime pas beaucoup votre ton.";
							case 30:
								return "Qu'est-ce que vous faites là ? Si vous ne saignez pas, sortez d'ici. Dehors !";
							case 31:
								return "Quoi ?";
							case 32:
								return "Vous avez vu ce vieil homme qui se pressait autour du donjon ? Il semblait avoir des ennuis.";
							case 33:
								return "J'aimerais bien que " + str2 + " fasse plus attention. J'en ai assez de lui faire des points de suture chaque jour.";
							case 34:
								return "Je me demande si " + text2 + " a dit qu'il avait besoin d'un docteur.";
							case 35:
								return "Il va falloir que je discute sérieusement avec " + str3 + ". Combien de fois par semaine allez-vous revenir ici avec des brûlures au second degré ?";
							case 36:
								return "Vous avez meilleure mine comme ça.";
							case 37:
								return "Que vous est-il arrivé au visage ?";
							case 38:
								return "Bon sang, je suis une bonne infirmière, mais pas à ce point.";
							case 39:
								return "Mes chers amis, nous sommes rassemblés aujourd'hui pour faire nos adieux... Bon, tout se passera bien.";
							case 40:
								return "Vous avez laissé votre bras là-bas. Laissez-moi arranger ça.";
							case 41:
								return "Arrêtez de vous comporter comme une mauviette. J'ai déjà vu bien pire.";
							case 42:
								return "Cela va demander quelques points de suture.";
							case 43:
								return "Encore des soucis avec ces brutes ?";
							case 44:
								return "Attendez, je dois avoir quelques pansements pour enfants quelque part.";
							case 45:
								return "Allez faire quelques pas, " + Main.player[Main.myPlayer].name + ", ça devrait aller. Allez, ouste !";
							case 46:
								return "Ça vous fait mal quand vous faites ça ? Eh bien, ne le faites pas.";
							case 47:
								return "On dirait qu'on a commencé à vous digérer. Vous avez encore chassé des slimes ?";
							case 48:
								return "Tournez votre tête et toussez.";
							case 49:
								return "Ce n'est pas la plus grave blessure que j'ai vue... Oui, j'ai déjà vu des blessures bien plus graves que ça.";
							case 50:
								return "Vous voulez une sucette ?";
							case 51:
								return "Montrez-moi où vous avez mal.";
							case 52:
								return "Je suis désolée, mais vous n'avez pas les moyens.";
							case 53:
								return "Il va me falloir plus d'or que cela.";
							case 54:
								return "Je ne travaille pas gratuitement, vous savez.";
							case 55:
								return "Je ne vous garantis pas le résultat.";
							case 56:
								return "Je ne peux rien faire de plus pour vous sans chirurgie esthétique.";
							case 57:
								return "Arrêtez de me faire perdre mon temps.";
							case 58:
								return "J'ai entendu dire qu'il y aurait une poupée qui ressemblerait beaucoup à " + str3 + " dans le monde inférieur. J'aimerais bien lui coller quelques pruneaux.";
							case 59:
								return "Dépêchez-vous, j'ai un rencard avec " + text + " d'ici une heure.";
							case 60:
								return "Je veux ce que vend" + text + ". Comment ça, elle ne vend rien !";
							case 61:
								return text3 + " est vraiment canon. Dommage qu'elle soit aussi prude.";
							case 62:
								return "Ne vous embêtez pas avec " + str2 + ", j'ai tout ce qu'il vous faut ici.";
							case 63:
								return "C'est quoi le problème de " + str2 + " ? Est-ce qu'il réalise seulement que l'on vend du matériel complètement différent ?";
							case 64:
								return "Eh bien, c'est la nuit idéale pour ne pas parler à n'importe qui, n'est-ce pas, " + Main.player[Main.myPlayer].name + " ?";
							case 65:
								return "J'adore les nuits comme celle-ci, car il y a toujours des choses à tuer.";
							case 66:
								return "Je vois que vous êtes en train de zieuter le minishark... Mieux vaut ne pas savoir comment c'est fabriqué.";
							case 67:
								return "Eh, c'est pas du cinéma. Les munitions sont superflues.";
							case 68:
								return "Retirez les mains de mon flingue.";
							case 69:
								return "Avez-vous essayé d'utiliser de la poudre de purification sur la pierre d'ébène de corruption ?";
							case 70:
								return "Ce serait bien si " + text2 + " cessait de me courtiser. J'ai quand même 500 ans, mais ça n'a pas l'air de lui faire peur.";
							case 71:
								return "Pourquoi " + str + " essaie-t-il toujours de me vendre des statues d'ange ? Tout le monde sait qu'elles sont sans intérêt.";
							case 72:
								return "Avez-vous vu le vieil homme en train de marcher autour du donjon ? Il n'avait vraiment pas l'air bien.";
							case 73:
								return "Je vends ce que je veux, et si cela ne vous plaît pas, tant pis pour vous.";
							case 74:
								return "Pourquoi adopter un comportement aussi conflictuel en cette période ?";
							case 75:
								return "Je ne veux pas que vous achetiez mes marchandises, je veux que vous vouliez acheter mes marchandises, vous saisissez la nuance ?";
							case 76:
								return "Dites, c'est moi ou il y a un million de zombies qui déambulent cette nuit ?";
							case 77:
								return "Je veux que vous purifiiez le monde de la corruption.";
							case 78:
								return "Soyez prudent, Terraria a besoin de vous.";
							case 79:
								return "Les sables du temps s'écoulent et il faut bien avouer que vous vieillissez plutôt mal.";
							case 80:
								return "Comment ça, j'aboie plus que je ne mords ?";
							case 81:
								return "C'est l'histoire de deux gobelins qui entrent dans une taverne et l'un dit à l'autre : « Tu veux un gobelet de bière ? »";
							case 82:
								return "Je ne peux pas vous laisser entrer tant que vous ne m'aurez pas débarrassé de ma malédiction.";
							case 83:
								return "Revenez à la nuit tombée si vous voulez entrer.";
							case 84:
								return "Mon maître ne peut pas être invoqué à la lumière du jour.";
							case 85:
								return "Vous êtes bien trop faible pour me débarrasser de ma malédiction. Revenez quand vous serez de taille.";
							case 86:
								return "C'est pathétique ! Vous n'espérez quand même pas affronter mon maître pour l'instant dans votre état.";
							case 87:
								return "J'espère que vous avez au moins six amis pour vous épauler.";
							case 88:
								return "Je vous en prie, ne faites pas ça. Vous allez vous faire tuer.";
							case 89:
								return "Votre puissance semble suffisante pour me débarrasser de ma malédiction.";
							case 90:
								return "Disposez-vous de la force nécessaire pour vaincre mon maître ?";
							case 91:
								return "S'il vous plaît, je vous en conjure, affrontez mon ravisseur et libérez-moi.";
							case 92:
								return "Terrassez mon maître et je vous ouvrirai la voie du donjon.";
							case 93:
								return "Vous essayez d'écouler cette pierre d'ébène, hein ? Pourquoi ne pas l'intégrer à l'un de ces explosifs ?";
							case 94:
								return "Dites donc, vous n'auriez pas vu un clown dans le coin ?";
							case 95:
								return "Il y avait une bombe juste là et je n'arrive plus à remettre la main dessus.";
							case 96:
								return "J'ai quelque chose dont les zombies raffolent.";
							case 97:
								return "Même " + text2 + " raffole de mes marchandises.";
							case 98:
								return "Vous préférez un trou de balle ou un trou de grenade ? C'est bien ce que je pensais.";
							case 99:
								return text + " vous aidera si jamais vous perdez un membre avec ça.";
							case 100:
								return "Pourquoi purifier le monde alors que vous pouvez tout faire sauter ?";
							case 101:
								return "Si vous lancez ça dans votre baignoire et que vous fermez les fenêtres, ça vous débouchera les sinus et les oreilles en moins de deux.";
							case 102:
								return "Vous voulez jouer au poulet-fusée ?";
							case 103:
								return "Pourriez-vous signer cette clause de non-responsabilité ?";
							case 104:
								return "INTERDICTION FORMELLE DE FUMER.";
							case 105:
								return "Les explosifs, c'est de la bombe en ce moment. Achetez-en dès maintenant.";
							case 106:
								return "C'est un bon jour pour mourir.";
							case 107:
								return "Je me demande ce qui va se passer si je... (BOUM !)... Désolé, vous aviez besoin de cette jambe ?";
							case 108:
								return "La dynamite, c'est mon remède spécial à tous vos petits problèmes.";
							case 109:
								return "Jetez un œil à mes marchandises, mes prix sont explosifs.";
							case 110:
								return "J'ai encore le vague souvenir d'avoir attaché une femme et de l'avoir balancée dans un donjon.";
							case 111:
								return "Il y a un problème, c'est la lune de sang.";
							case 112:
								return "Si j'avais été plus jeune, j'aurais proposé un rencard à " + text + ". J'étais un bourreau des cœurs dans le temps.";
							case 113:
								return "Ce chapeau rouge que vous portez me dit quelque chose.";
							case 114:
								return "Merci de m'avoir débarrassé de cette malédiction. J'avais l'impression que quelque chose m'avait mordu et ne me lâchait plus.";
							case 115:
								return "Ma mère m'a toujours dit que je ferais un bon tailleur.";
							case 116:
								return "La vie est comme le chapeau d'un magicien, on ne sait jamais ce qui va en sortir.";
							case 117:
								return "La broderie, c'est très difficile. Si ça ne l'était pas, personne n'en ferait. C'est ce qui la rend si intéressante.";
							case 118:
								return "Le commerce du prêt-à-porter n'a aucun secret pour moi.";
							case 119:
								return "Quand on est maudit, ça n’aide pas à se faire des amis. Alors un jour, je m'en suis fait un avec un morceau de cuir et je l'ai appelé Wilson.";
							case 120:
								return "Merci de m'avoir libéré, humain. J'ai été attaché et laissé ici par les autres gobelins. On peut dire qu'on ne s'entendait pas très bien, eux et moi.";
							case 121:
								return "Je n'arrive pas à croire qu'ils m'aient attaché et planté ici juste pour montrer qu'ils ne voulaient pas aller vers l'est.";
							case 122:
								return "Puisque je suis devenu un paria, puis-je jeter mes boules piquantes ? Mes poches me font mal.";
							case 123:
								return "Vous cherchez un expert en gadgets ? Je suis votre gobelin.";
							case 124:
								return "Merci de votre aide. À présent, je dois continuer à errer sans but dans les environs. Je suis sûr qu'on se reverra.";
							case 125:
								return "Je ne vous imaginais pas comme ça.";
							case 126:
								return "Et comment va " + text5 + "? Lui auriez-vous parlé, par hasard ?";
							case 127:
								return "Est-ce que votre chapeau a besoin d'un moteur ? Je crois en avoir un en stock qui ferait parfaitement l'affaire.";
							case 128:
								return "J'ai entendu dire que vous aimiez les bottes de course et les roquettes, du coup, j'ai installé des roquettes dans vos bottes de course.";
							case 129:
								return "Le silence est d'or, mais le chatterton reste très efficace.";
							case 130:
								return "Oui, l'or est plus précieux que le fer. Mais qu'est-ce qu'ils vous apprennent chez les humains ?";
							case 131:
								return "C'est vrai que ce casque de mineur combiné à une palme rendait mieux sur le papier.";
							case 132:
								return "Les gobelins sont étonnamment soupe au lait. Ils pourraient déclencher une guerre pour un mot de travers.";
							case 133:
								return "Il faut bien avouer que les gobelins n'ont pas inventé la poudre, mais il y a des exceptions à la règle.";
							case 134:
								return "Savez-vous pourquoi on trimballe toujours ces boules piquantes ? Parce que moi, je n'en sais fichtre rien.";
							case 135:
								return "Je viens de mettre la touche finale à ma dernière invention. Et ce modèle n'explosera pas si vous soufflez trop fort dessus.";
							case 136:
								return "Les voleurs gobelins sont des vrais manchots. Ils ne sont même pas capables de dérober le contenu d'un coffre non verrouillé.";
							case 137:
								return "Merci de m'avoir secouru. Ces liens commençaient à m'irriter la peau.";
							case 138:
								return "Mon héros !";
							case 139:
								return "Quel héroïsme ! Merci de m'avoir sauvé, belle dame.";
							case 140:
								return "Quel héroïsme ! Merci de m'avoir sauvé, fringant jeune homme.";
							case 141:
								return "Maintenant que nous avons fait connaissance, je peux venir avec vous, n'est-ce pas ?";
							case 142:
								return "Bonjour, " + str3 + "! Que puis-je pour vous, aujourd'hui ?";
							case 143:
								return "Bonjour, " + str2 + "! Que puis-je pour vous, aujourd'hui ?";
							case 144:
								return "Bonjour, " + text4 + "! Que puis-je pour vous, aujourd'hui ?";
							case 145:
								return "Bonjour, " + text + "! Que puis-je pour vous, aujourd'hui ?";
							case 146:
								return "Bonjour, " + text5 + "! Que puis-je pour vous, aujourd'hui ?";
							case 147:
								return "Bonjour, " + text3 + "! Que puis-je pour vous, aujourd'hui ?";
							case 148:
								return "Voulez-vous que je fasse apparaître une pièce de monnaie de derrière votre oreille ? Non ? Bon.";
							case 149:
								return "Est-ce qu'un berlingot magique vous ferait plaisir ? Non ? Bon.";
							case 150:
								return "Je peux concocter un merveilleux chocolat chaud magique, si cela vous intéresse... Non ? OK.";
							case 151:
								return "Souhaitez-vous jeter un œil à ma boule de cristal ?";
							case 152:
								return "N'avez-vous jamais rêvé de posséder un anneau magique qui transformerait les rochers en vase ? Moi non plus, à vrai dire.";
							case 153:
								return "Un jour, quelqu'un m'a dit que l'amitié était quelque chose de magique. C'est n'importe quoi. On ne peut pas transformer quelqu'un en grenouille avec l'amitié.";
							case 154:
								return "À présent, votre avenir m'apparaît clairement... Vous allez m'acheter de nombreux objets.";
							case 155:
								return "Une fois, j'ai tenté de ramener une statue d'ange à la vie. Il ne s'est rien passé.";
							case 156:
								return "Merci. C'était moins une, j'ai failli terminer comme tous ces squelettes.";
							case 157:
								return "Attention où vous mettez les pieds. J'étais encore là-bas il y a peu.";
							case 158:
								return "Attendez, je suis en train de perdre ma connexion Wi-Fi par ici.";
							case 159:
								return "Mais j'avais presque terminé d'installer des stroboscopes ici.";
							case 160:
								return "Que personne ne bouge ! J'ai perdu une lentille.";
							case 161:
								return "Tout ce que je veux, c'est que l'interrupteur... Quoi ?";
							case 162:
								return "Je parie que vous n'avez pas acheté assez de câbles. Décidément, vous n'êtes vraiment pas une lumière.";
							case 163:
								return "Est-ce que vous pourriez juste... S'il vous plaît ? OK ? OK.";
							case 164:
								return "Je n'aime pas trop la façon dont vous me regardez. Je suis en train de travailler, moi.";
							case 165:
								return string.Concat(new string[]
								{
									"Au fait, ",
									Main.player[Main.myPlayer].name,
									", vous venez de voir  ",
									text4,
									" ? Est-ce qu'il aurait parlé de moi, par hasard ?"
								});
							case 166:
								return text2 + " parle toujours de pressuriser mes plaques de pression. Je lui ai dit que c'était pour marcher dessus.";
							case 167:
								return "Il faut toujours acheter plus de câbles que prévu.";
							case 168:
								return "Vous vous êtes assuré que votre matériel était bien branché ?";
							case 169:
								return "Vous savez ce qu'il faudrait à cette maison ? Plus de stroboscopes.";
							case 170:
								return "La lune de sang se remarque lorsque le ciel vire au rouge et quelque chose fait que les monstres pullulent.";
							case 171:
								return "Dites donc, vous savez où je peux trouver de la mauvaise herbe morte. Non, pour rien, je me demandais, c'est tout.";
							case 172:
								return "Si vous regardiez en l'air, vous verriez que là,  la lune est toute rouge.";
							case 173:
								return "La nuit, vous devriez rester à l'intérieur. C'est très dangereux de se balader dans le noir.";
							case 174:
								return "Bienvenue, " + Main.player[Main.myPlayer].name + ". Je peux faire quelque chose pour vous ?";
							case 175:
								return "Je suis là pour vous conseiller et vous aider dans vos prochaines actions. Vous devriez venir me parler au moindre problème.";
							case 176:
								return "On dit qu'il y a une personne capable de vous aider à survivre sur ces terres... Oh, attendez, c'est moi.";
							case 177:
								return "Vous pouvez utiliser votre pioche pour creuser dans la terre, et votre hache pour abattre des arbres. Placez simplement le curseur à l'emplacement souhaité et cliquez.";
							case 178:
								return "Si vous voulez survivre, vous allez devoir fabriquer des armes et un abri. Commencez par abattre des arbres et récolter du bois.";
							case 179:
								return "Appuyez sur ÉCHAP pour accéder au menu d'artisanat. Lorsque vous avez assez de bois, créez un établi. Tant que vous vous tiendrez à proximité, il vous permettra de fabriquer des objets plus complexes.";
							case 180:
								return "Vous pouvez construire un abri en plaçant du bois ou d'autres blocs dans le monde. N'oubliez pas de créer des murs et de les placer.";
							case 181:
								return "Une fois que vous aurez une épée de bois, vous pourriez essayer de récupérer du gel grâce aux slimes. Combinez ensuite le bois et le gel pour faire une torche.";
							case 182:
								return "Pour interagir avec les arrière-plans et les objets placés, utilisez un marteau.";
							case 183:
								return "Vous devriez creuser pour trouver du minerai. Cela vous permet de fabriquer des objets très utiles.";
							case 184:
								return "Maintenant que vous avez du minerai, vous allez devoir le transformer en lingot pour pouvoir en faire des objets. Il vous faut un fourneau.";
							case 185:
								return "Vous pouvez fabriquer un fourneau avec des torches, du bois et de la pierre. Assurez-vous de vous tenir près d'un établi.";
							case 186:
								return "Vous aurez besoin d'une enclume pour pouvoir fabriquer la plupart des choses à partir des lingots de métal.";
							case 187:
								return "Une enclume peut être fabriquée avec du fer ou bien achetée chez les marchands.";
							case 188:
								return "Le souterrain est un cœur de cristal utilisé pour augmenter votre maximum de vie. Il vous faudra un marteau pour pouvoir en extraire.";
							case 189:
								return "Si vous récupérez dix étoiles filantes, elles peuvent être combinées pour fabriquer un objet qui augmentera votre capacité de magie.";
							case 190:
								return "Les étoiles tombent sur le monde durant la nuit. Elles peuvent être utilisées pour toutes sortes de choses utiles. Si vous en voyez une, dépêchez-vous de la ramasser, car elles disparaissent l'aube venue.";
							case 191:
								return "Il existe de nombreux moyens pour attirer du monde dans notre ville. Bien sûr, une fois sur place, ces nouveaux arrivants auront besoin d'une maison pour s'abriter.";
							case 192:
								return "Pour qu'une pièce puisse être considérée comme un foyer, elle doit comporter une porte, une chaise, une table et une source de lumière. Assurez-vous que la maison dispose également de murs.";
							case 193:
								return "Deux personnes distinctes ne vivront pas dans le même foyer. De plus, si leur foyer est détruit, ils chercheront un nouveau lieu où habiter.";
							case 194:
								return "Vous pouvez utiliser l'interface de logement pour attribuer des logements et les visualiser. Ouvrez votre inventaire et cliquez sur l'icône de maison.";
							case 195:
								return "Si vous souhaitez qu'un marchand emménage, vous devrez avoir une quantité d'argent suffisante. 50 pièces d'argent devraient suffire.";
							case 196:
								return "Pour qu'une infirmière emménage, vous pourriez augmenter votre maximum de vie.";
							case 197:
								return "Si vous avez un mousquet, il se peut qu'un marchand d'armes fasse son apparition pour vous vendre des munitions.";
							case 198:
								return "Vous devriez montrer de quoi vous êtes capable en triomphant d'un monstre. Cela attirera l'attention d'une dryade.";
							case 199:
								return "Assurez-vous d'explorer minutieusement les donjons. Il pourrait y avoir des prisonniers retenus captifs dans les profondeurs.";
							case 200:
								return "Peut-être que le vieil homme du donjon voudra se joindre à nous maintenant que sa malédiction a été levée.";
							case 201:
								return "Récupérez toutes les bombes que vous pourrez trouver. Un démolisseur voudra sûrement y jeter un œil.";
							case 202:
								return "Les gobelins sont-ils si différents de nous pour que nous ne puissions pas vivre ensemble de manière paisible ?";
							case 203:
								return "J'ai entendu dire qu'un puissant magicien vivait dans les environs. Assurez-vous de le trouver la prochaine fois que vous irez dans le souterrain.";
							case 204:
								return "Si vous combinez des lentilles à un autel de démon, vous pourrez trouver un moyen d'invoquer un monstre très puissant. Cependant, il vous faudra attendre la tombée de la nuit avant de pouvoir l'utiliser.";
							case 205:
								return "Vous pouvez fabriquer de la nourriture pour ver avec des morceaux pourris et de la poudre infecte. Assurez-vous de vous trouver dans une zone corrompue avant de l'utiliser.";
							case 206:
								return "Les autels démoniaques peuvent généralement être trouvés dans la corruption. Il vous faudra vous tenir près d'eux pour fabriquer certains objets.";
							case 207:
								return "Vous pouvez fabriquer un grappin avec un crochet et trois chaînes. Les squelettes trouvés dans les profondeurs portent souvent des crochets sur eux. Les chaînes peuvent être fabriquées à l'aide de lingots de fer.";
							case 208:
								return "Si vous voyez des pots, détruisez-les pour les ouvrir, car ils contiennent souvent des objets très utiles.";
							case 209:
								return "Des trésors sont disséminés un peu partout dans le monde et vous pouvez trouver des objets fantastiques dans les profondeurs.";
							case 210:
								return "Lorsqu'on écrase un orbe d'ombre, il arrive qu'une météorite tombe du ciel. Les orbes d'ombre peuvent généralement être trouvés dans les gouffres des zones corrompues.";
							case 211:
								return "Vous devriez vous employer à récolter davantage de cœurs de cristal pour augmenter votre maximum de vie.";
							case 212:
								return "Votre équipement actuel ne suffira pas. Il vous faut une meilleure armure.";
							case 213:
								return "Je crois que vous pouvez maintenant prendre part à votre première grande bataille. De nuit, rassemblez des lentilles récupérées à la mort des démons et portez-les sur un autel de démon.";
							case 214:
								return "Vous devriez augmenter votre vie avant votre prochaine épreuve. Quinze cœurs devraient suffire.";
							case 215:
								return "La pierre d'ébène dans la corruption peut être purifiée en utilisant de la poudre issue d'une dryade, ou bien peut être détruite avec des explosifs.";
							case 216:
								return "Votre prochaine épreuve sera d'explorer les gouffres corrompus. Trouvez et détruisez tous les orbes d'ombre que vous trouverez.";
							case 217:
								return "Il existe un vieux donjon situé pas très loin d'ici. Vous devriez aller y faire un tour dès maintenant.";
							case 218:
								return "Vous devriez essayer d'augmenter votre vie maximum. Essayez de rassembler vingt cœurs.";
							case 219:
								return "Si vous pouvez creuser assez profondément, il y a de nombreux trésors à découvrir dans la jungle.";
							case 220:
								return "Le monde inférieur est fait d'un matériau appelé pierre de l'enfer. Ce matériau est parfait pour la fabrication d'armes et d'armures.";
							case 221:
								return "Lorsque vous voudrez affronter le gardien du monde inférieur, vous devrez faire le sacrifice d'un être vivant. Tout ce dont vous avez besoin pour cela se trouve dans le monde inférieur.";
							case 222:
								return "Assurez-vous d'écraser tous les autels de démon que vous trouverez. Vous pourrez en tirer quelque chose de bénéfique.";
							case 223:
								return "Des âmes peuvent être parfois récupérées des créatures déchues dans des lieux de lumière ou d'ombre extrême.";
							case 224:
								return "Ho ho ho et une bouteille de ... Egg Nog!";
							case 225:
								return "Soins pour cuire des biscuits moi?";
							case 226:
								return "Qu'est-ce? Vous pensiez que je n'étais pas réel?";
							case 227:
								return "J'ai réussi à coudre votre visage sur le dos. Soyez plus prudent la prochaine fois.";
							case 228:
								return "Cela va probablement laisser une cicatrice.";
							case 229:
								return "Toutes les meilleures. Je ne veux pas vous voir sauter plus falaises.";
							case 230:
								return "Cela n'a pas fait trop de mal, maintenant c'est fait?";
							case 231:
								return "Comme si vivre souterrain n'était pas assez, saccades comme vous venez pendant que je dors et volé mes enfants.";
							case 232:
								return "Entre vous et moi, " + text3 + " est le seul en qui j'ai confiance. Elle est la seule personne ici qui n'a pas essayé de me manger ou m'utiliser dans une potion.";
							case 233:
								return "J'ai essayé de me lécher l'autre jour pour voir ce que le gros problème était, tout a commencé bleu éclatant.";
							case 234:
								return "Chaque fois que je vois la couleur bleue, ça me rend dépressif et paresseux.";
							case 235:
								return "Vous n'avez pas vu des porcs par ici vous? Mon frère a perdu sa jambe à un.";
							case 236:
								return "Tout le monde dans cette ville se sent un peu à l'écart. Je me suis réveillé au drapier à mâcher sur mon pied hier soir.";
							case 237:
								return "Je vais vous donner un rabais sur votre usures si vous pouvez convaincre " + str4 + " à venir pour un ... dimensionnement.";
							case 238:
								return "Je me sens comme " + str4 + " est un peu mal compris, il est vraiment un gars amusant.";
							case 240:
								return "Je ne sais pas le «Truffle Shuffle» pour cesser de demander!";
							case 241:
								return "Il ya eu une énorme rumeur qui a été répandu sur moi: «Si vous ne pouvez pas le battre, le manger!»";
							case 242:
								return "Oy, qu'est-ce que vous avez dans votre fluffer Jiminy?";
							case 243:
								return "Devrais-je devenir un pirate air? J'ai envisagé de devenir un pirate air.";
							case 244:
								return "Que ce soit ce que ce serait, un jetpack qui vous conviendrait bien!";
							case 245:
								return "Je me sens un peu maussade de la fin, assez pour vous avec votre palabre gueux!";
							case 246:
								return "Je suis curieux de savoir ce puissant " + str6 + " camarade. Par ce mode de consommation-t-il maintenir cette locomotion?";
							case 247:
								return "Ce garçon de capitaine me semble être «assez bien sur la baie» si vous savez ce que signifie!";
							case 248:
								return "Montrez-moi certains engins!";
							case 249:
								return "J'aime votre ... engrenages. Cela vient-il en laiton?";
							case 250:
								return "Une fois que vous entrez dans la terre sainte, et vous verrez un arc en ciel dans le ciel. Je peux vous aider avec de la peinture qui, si vous voulez.";
							case 251:
								return "Découvrez " + str5 + ". Maintenant, c'est une fille qui peut peindre la ville rouge!";
							case 252:
								return "Je connais la différence entre turquoise et bleu-vert. Mais je ne vais pas vous le dire.";
							case 253:
								return "Je suis tout de blanc de titane, alors ne vous demande même pas.";
							case 254:
								return "Essayez tourbillonnant rose et violet, cela fonctionne, je le jure!";
							case 255:
								return "Non, non, non ... Il ya des tonnes de différents gris! Ne me lancez pas ...";
							case 256:
								return "J'espère qu'il ne pleuve pas à nouveau jusqu'à ce que cette peinture sèche. Ce serait une catastrophe!";
							case 257:
								return "Je vous apporte les couleurs les plus riches en échange de vos richesses!";
							case 258:
								return "Mon cher, ce que vous portez est beaucoup trop terne. Vous devez absolument prendre une leçon de teinture de votre tenue vestimentaire fatigué!";
							case 259:
								return "Le seul type de bois je dérange teinture est acajou. Teinture tout autre bois est un tel gaspillage.";
							case 260:
								return "Vous devez faire quelque chose pour " + str7 + ".  Chaque fois qu'il vient ici, il me faut une semaine pour obtenir l'odeur off!";
							case 261:
								return "Quel médecin suis-je? Le sorcier je suis.";
							case 262:
								return "Le cœur de la magie est la nature. La nature des cœurs est magique.";
							case 263:
								return text + " peut aider à guérir votre corps, mais je peux vous faire incarner la guérison.";
							case 264:
								return "Choisissez judicieusement, " + Main.player[Main.myPlayer].name + ", mes produits sont volatils et ma magie noire, mystérieuse.";
							case 265:
								return "Nous devons parler. C'est ... il s'agit de parties.";
							case 266:
								return "Je ne peux pas décider ce que je veux de plus: les parties, ou l'après que les parties.";
							case 267:
								return "Nous devons mettre en place une partie blinkroot, et nous devrions également mettre en place une après la fête.";
							case 268:
								return "Wow, " + Main.player[Main.myPlayer].name + ", rencontrer un homme aventureux comme vous me donne envie de faire la fête!";
							case 269:
								return "Mettre en place une boule disco et puis je vais vous montrer comment faire la fête.";
							case 270:
								return "Je suis allé en Suède une fois, ils la fête dure, pourquoi n'êtes-vous pas comme ça?";
							case 271:
								return "Je m'appelle " + str5 + " mais les gens m'appellent Party Pooper. Ouais, je ne sais pas, c'est assez cool si";
							case 272:
								return "Pensez-vous parti? Parfois? Hm, ok alors nous pouvons parler ...";
							case 273:
								return "Je ne suis pas amoureux de la terre, mais c'est mieux d'avoir aimé et perdu que ne jamais aimer du tout.";
							case 274:
								return "Yo ho ho et une bouteille de ...blinkroots!";
							case 275:
								return "YAR!  C'est drôle que vous devriez être mentionnez perroquets parce que ... euh ... quoi parlions-nous sur?";
							case 276:
								return Main.player[Main.myPlayer].name + ", Vous être l'une des plus belles gamines qui cherchent ce ici le capitaine a vu dans beaucoup de quinze jours!";
							case 277:
								return "Restez en dehors de moi butin, vous voyou!";
							case 278:
								return "Quel en flammes êtes-vous parlez? Moby Dick est le mien!";
							case 279:
								return "*Yarr Blarr Harrdarr*";
							case 280:
								return "Et puis Unit 492-8 dit: «Qui pensez-vous que je suis, Unité 472-6?» HA. HA. HA.";
							case 281:
								return "Mon efficacité de l'expédition a été gravement réduite lorsqu'un projectile impact sur ma actionneur de locomotive.";
							case 282:
								return "Cette phrase est fausse, ou est-il?";
							case 283:
								return "Alors que «punk» poussin de lookin est un inventeur, hein? Je pense que je pourrais lui montrer une chose ou deux!";
							case 284:
								return "Bien sûr, " + str7 + " et moi sommes copains, mais je déteste quand son perroquet fait ses affaires sur moi. Le corrosif de ce genre de choses!";
							case 285:
								return "Je me suis construit un mécanisme de goût, donc je peux boire un soda!";
							case 286:
								return "Parfois, je me dégage un peu ... Get it? un peu?";
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								switch (l)
								{
								case 1:
									return "Espero que un canijo como tú no sea lo único que se interpone entre nosotros y el Ojo de Cthulu.";
								case 2:
									return "Vaya un arma más mal hecha que llevas. Te conviene comprar más pociones curativas.";
								case 3:
									return "Siento como si una presencia maligna me observara.";
								case 4:
									return "¡La espada siempre gana! Cómprate una ahora.";
								case 5:
									return "¿Quieres manzanas? ¿Zanahorias? ¿Unas piñas? Tenemos antorchas.";
								case 6:
									return "Una mañana estupenda, ¿verdad? ¿No necesitas nada?";
								case 7:
									return "La noche caerá pronto, amigo. Haz tus compras mientras puedas.";
								case 8:
									return "Ni te imaginas lo bien que se venden los Bloques de tierra en el extranjero.";
								case 9:
									return "Oh, algún día narrarán las aventuras de " + Main.player[Main.myPlayer].name + "... y seguro que acaban bien.";
								case 10:
									return "Echa un vistazo a estos Bloques de tierra; tienen extra de tierra.";
								case 11:
									return "¡Oye, cómo pega el sol! Pero yo tengo una armadura totalmente ventilada.";
								case 12:
									return "El sol está alto, al contrario que mis precios.";
								case 13:
									return string.Concat(new string[]
									{
										"¡Vaya! Desde aquí se oye cómo discuten ",
										text5,
										" y ",
										text,
										"."
									});
								case 14:
									return "¿Has visto a Chith... esto... Shith... eh... Chat...? Vamos, ¿al gran Ojo?";
								case 15:
									return "Oye, esta casa es segura, ¿verdad? ¿Verdad? " + Main.player[Main.myPlayer].name + "...";
								case 16:
									return "Ni siquiera una luna sangrienta detendría el capitalismo. Así que vamos a hacer negocios.";
								case 17:
									return "¡Fíjate bien en el premio, compra una lente!";
								case 18:
									return "Kosh, kapleck Mog. Lo siento, hablaba en klingon... quiere decir \"Compra algo o muere\".";
								case 19:
									return "¿Eres tú, " + Main.player[Main.myPlayer].name + "? ¡Me han hablado bien de ti, amigo!";
								case 20:
									return "Dicen que aquí hay un tesoro escondido... oh, olvídalo...";
								case 21:
									return "¿La estatua de un ángel? Lo siento pero no vendo cosas de segunda mano.";
								case 22:
									return "El último tipo que estuvo aquí me dejó algunos trastos viejos... ¡bueno, en realidad eran tesoros!";
								case 23:
									return "Me pregunto si la luna estará hecha de queso... Eh... esto. ¡Ah, claro, compre aquí!";
								case 24:
									return "¿Has dicho oro? Me lo quedo.";
								case 25:
									return "Será mejor que no me manches de sangre.";
								case 26:
									return "Date prisa... y deja ya de sangrar.";
								case 27:
									return "Si te vas a morir, hazlo fuera por favor.";
								case 28:
									return "¿Y eso qué quiere decir?";
								case 29:
									return "No me gusta el tono que empleas.";
								case 30:
									return "¿Por qué sigues aquí? Si no te estás desangrando, aquí no pintas nada. Lárgate.";
								case 31:
									return "¡CÓMO!";
								case 32:
									return "¿Has visto a ese anciano deambulando por la mazmorra? Parece que tiene problemas.";
								case 33:
									return "Ojalá " + str2 + " tuviera más cuidado. Ya me estoy hartando de tener que coserle las extremidades todos los días.";
								case 34:
									return "Oye, por curiosidad, ¿ha dicho " + text2 + " por qué tiene que ir al médico?";
								case 35:
									return "Debo hablar en serio con " + str3 + ". ¿Cuántas veces crees que puedes venir en una semana con quemaduras de lava graves?";
								case 36:
									return "Creo que así estarás mejor.";
								case 37:
									return "Eh... ¿Qué te ha pasado en la cara?";
								case 38:
									return "¡DIOS MÍO! Soy buena, pero no tanto.";
								case 39:
									return "Queridos amigos, nos hemos reunido hoy aquí para decir adiós a... Vaya, te vas a poner bien.";
								case 40:
									return "Te dejaste el brazo por ahí. Deja que te ayude...";
								case 41:
									return "¡Deja de comportarte como un bebé! He visto cosas peores.";
								case 42:
									return "¡Voy a tener que darte puntos!";
								case 43:
									return "¿Ya te has vuelto a meter en líos?";
								case 44:
									return "Aguanta, por aquí tengo unas tiritas infantiles chulísimas.";
								case 45:
									return "Anda ya, " + Main.player[Main.myPlayer].name + ", te pondrás bien. Serás nenaza...";
								case 46:
									return "¿Así que te duele cuando haces eso? ... Pues no lo hagas.";
								case 47:
									return "Parece un corte de digestión. ¿Has estado cazando babosas otra vez?";
								case 48:
									return "Gira la cabeza y tose.";
								case 49:
									return "No es de las peores heridas que he visto... Sin duda, he visto heridas más grandes que esta.";
								case 50:
									return "¿Quieres una piruleta, chiquitín?";
								case 51:
									return "A ver... ¿dónde te duele?";
								case 52:
									return "Lo siento, pero no puedes pagarme.";
								case 53:
									return "Vas a necesitar más oro del que traes.";
								case 54:
									return "Oye, yo no trabajo gratis.";
								case 55:
									return "No tengo una varita mágica.";
								case 56:
									return "Esto es todo lo que puedo hacer por ti... necesitas cirugía plástica.";
								case 57:
									return "No me hagas perder el tiempo.";
								case 58:
									return "Dicen que en alguna parte del Inframundo hay una muñeca que se parece mucho a" + str3 + " Me gustaría dejarme caer por ahí.";
								case 59:
									return "¡Date prisa! Tengo una cita con " + text + " dentro de una hora.";
								case 60:
									return "Quiero lo que vende " + text + ". ¿Cómo dices? ¿Que no vende nada?";
								case 61:
									return text3 + " es una monada. Es una lástima que sea tan mojigata.";
								case 62:
									return "Olvídate de " + str2 + ", yo tengo todo lo que necesitas aquí y ahora.";
								case 63:
									return "¿Qué mosca le ha picado a " + str2 + "? ¿Aún no sabe que vendemos cosas totalmente distintas?";
								case 64:
									return "Oye, hace una noche magnífica para no hablar con nadie, ¿no crees, " + Main.player[Main.myPlayer].name + "?";
								case 65:
									return "Me encantan estas noches. ¡Siempre encuentras algo que matar!";
								case 66:
									return "Sé que le has echado el ojo al Minitiburón. Será mejor que no sepas de qué está hecho.";
								case 67:
									return "Eh, amigo, que esto no es una película. La munición va aparte.";
								case 68:
									return "¡Aparta esas manos de mi pistola, colega!";
								case 69:
									return "¿Has probado a usar polvos de purificación sobre la piedra de ébano corrupta?";
								case 70:
									return "Ojalá " + text2 + " dejara de flirtear conmigo. ¿No se da cuenta de que tengo 500 años?";
								case 71:
									return "¿Por qué se empeña " + str + " en intentar venderme una estatua de ángel? Todo el mundo sabe que no hacen nada.";
								case 72:
									return "¿Has visto a ese anciano deambulando por la mazmorra? No tiene muy buen aspecto...";
								case 73:
									return "¡Yo vendo lo que quiero! Si no te gusta, mala suerte.";
								case 74:
									return "¿Por qué tienes que ser tan polémico en estos tiempos que corren?";
								case 75:
									return "No quiero que compres mis artículos. Quiero que desees comprar mis artículos, ¿entiendes?";
								case 76:
									return "Tío, ¿soy yo o esta noche han salido de juerga un millón de zombis?";
								case 77:
									return "Debes erradicar la corrupción de este mundo.";
								case 78:
									return "Ponte a salvo; ¡Terraria te necesita!";
								case 79:
									return "Fluyen las arenas del tiempo. Y la verdad... no estás envejeciendo con mucha elegancia.";
								case 80:
									return "¿Qué tiene que ver conmigo eso de perro ladrador?";
								case 81:
									return "Entra un duende en un bar y dice el dueño: \"A ver, quiero control, ¿eh?\". Y dice el duende: \"No, sin trol, sin trol\".";
								case 82:
									return "No puedo dejarte entrar hasta que me liberes de esta maldición.";
								case 83:
									return "Si quieres entrar, vuelve por la noche.";
								case 84:
									return "No se puede invocar al maestro a la luz del día.";
								case 85:
									return "Eres demasiado débil para romper esta maldición. Vuelve cuando seas de más utilidad.";
								case 86:
									return "Eres patético. No esperes presentarte ante el maestro tal como eres.";
								case 87:
									return "Espero que hayas venido con varios amigos...";
								case 88:
									return "Extraño, no, por favor. Esto es un suicidio.";
								case 89:
									return "Debes ser lo bastante fuerte para poder librarme de esta maldición...";
								case 90:
									return "Extraño, ¿te crees con fuerzas para derrotar al maestro?";
								case 91:
									return "¡Por favor! ¡Lucha con mi raptor y libérame! ¡Te lo suplico!";
								case 92:
									return "Derrota al maestro y te garantizaré la entrada a la Mazmorra.";
								case 93:
									return "¿Conque intentando dominar esa piedra de ébano, eh? ¿Por qué no la metes en uno de estos explosivos?";
								case 94:
									return "Eh, ¿has visto a un payaso por aquí?";
								case 95:
									return "Había una bomba aquí mismo, y ahora no soy capaz de encontrarla...";
								case 96:
									return "¡Yo les daré a esos zombis lo que necesitan!";
								case 97:
									return "¡Incluso " + text2 + " quiere lo que vendo!";
								case 98:
									return "Y pensé: ¿Qué prefieres? ¿Un agujero de bala o de granada?";
								case 99:
									return "Seguro que " + text + " te ayudará si pierdes una extremidad con uno de estos por accidente.";
								case 100:
									return "¿Por qué purificar el mundo cuando puedes volarlo en pedazos?";
								case 101:
									return "¡Si los lanzas a la bañera y cierras todas las ventanas, te despejará la nariz y los oídos!";
								case 102:
									return "¿Quieres jugar con fuego, gallina?";
								case 103:
									return "Oye, ¿firmarías esta renuncia de daños y perjuicios?";
								case 104:
									return "¡AQUÍ NO SE PUEDE FUMAR!";
								case 105:
									return "Los explosivos están de moda hoy en día. ¡Llévate algunos!";
								case 106:
									return "¡Es un buen día para morir!";
								case 107:
									return "Y qué pasa si... (¡BUM!)... Oh, lo siento, ¿usabas mucho esa pierna?";
								case 108:
									return "Dinamita, mi propia panacea para todos los males.";
								case 109:
									return "Echa un vistazo a este género; ¡los precios son una bomba!";
								case 110:
									return "Recuerdo vagamente haber atado a una mujer y haberla arrojado a una mazmorra.";
								case 111:
									return "¡Tenemos un problema! ¡Hoy tenemos luna sangrienta!";
								case 112:
									return "Si fuera más joven, invitaría a " + text + " a salir. Yo antes era todo un galán.";
								case 113:
									return "Ese sombrero rojo me resulta familiar...";
								case 114:
									return "Gracias otra vez por librarme de esta maldición. Sentí como si algo me hubiera saltado encima y me hubiera mordido.";
								case 115:
									return "Mamá siempre dijo que yo sería un buen sastre.";
								case 116:
									return "La vida es como un cajón de la ropa; ¡nunca sabes qué te vas a poner!";
								case 117:
									return "¡Desde luego bordar es una tarea difícil! ¡Si no fuera así, nadie lo haría! Eso es lo que la hace tan genial.";
								case 118:
									return "Sé todo lo que hay que saber sobre el negocio de la confección.";
								case 119:
									return "La maldición me ha convertido en un ser solitario; una vez me hice amigo de un muñeco de cuero. Lo llamaba Wilson.";
								case 120:
									return "Gracias por liberarme, humano. Otros duendes me ataron y me dejaron aquí. Te puedes imaginar que no nos llevamos muy bien.";
								case 121:
									return "¡No puedo creer que me ataran y me dejaran aquí solo por decirles que no se dirigían al este!";
								case 122:
									return "Ahora que soy un proscrito, ¿puedo tirar ya estas bolas de pinchos? Tengo los bolsillos destrozados.";
								case 123:
									return "¿Buscas un experto en artilugios? ¡Yo soy tu duende!";
								case 124:
									return "Gracias por tu ayuda. Tengo que dejar de vagar por ahí sin rumbo. Seguro que nos volvemos a ver.";
								case 125:
									return "Creía que eras más alto.";
								case 126:
									return "Oye... ¿Qué trama " + text5 + "? ¿Tú... has hablado con ella, por un casual?";
								case 127:
									return "Eh, ¿quieres un motor para tu sombrero? Creo que tengo un motor que quedaría de perlas en ese sombrero.";
								case 128:
									return "Ey, he oído que te gustan los cohetes y las bota de correr, ¿por qué no te pongo unos cohetes en las botas?";
								case 129:
									return "El silencio es oro. Lo que daría por un poco de cinta adhesiva...";
								case 130:
									return "Pues claro, el oro es más resistente que el hierro. ¿Pero qué os enseñan estos humanos de hoy?";
								case 131:
									return "En fin, la idea de un casco de minero con alas quedaba mucho mejor sobre el papel.";
								case 132:
									return "Los duendes tienen un increíble predisposición al enfado. ¡De hecho, podrían declarar una guerra por una discusión sobre ropa!";
								case 133:
									return "Sinceramente, la mayoría de los duendes no son precisamente ingenieros de cohetes. Bueno, algunos sí.";
								case 134:
									return "¿Tú sabes por qué llevamos estas bolas con pinchos? Porque yo no.";
								case 135:
									return "¡Acabo de terminar mi última creación! Esta versión no explota con violencia si respiras encima con fuerza.";
								case 136:
									return "Los duendes ladrones no son muy buenos en lo suyo. ¡Ni siquiera saben robar un cofre abierto!";
								case 137:
									return "¡Gracias por salvarme, amigo! Estas ataduras me estaban haciendo rozaduras.";
								case 138:
									return "¡Oh, mi héroe!";
								case 139:
									return "¡Oh, qué heroico! ¡Gracias por salvarme, jovencita!";
								case 140:
									return "¡Oh, qué heroico por su parte! ¡Gracias por salvarme, jovencito!";
								case 141:
									return "Ahora que nos conocemos, ¿me puedo ir a vivir contigo, verdad?";
								case 142:
									return "¡Eh, hola, " + str3 + " ! ¿Qué puedo hacer hoy por ti?";
								case 143:
									return "¡Eh, hola, " + str2 + "! ¿Qué puedo hacer hoy por ti?";
								case 144:
									return "¡Eh, hola, " + text4 + "! ¿Qué puedo hacer hoy por ti?";
								case 145:
									return "¡Eh, hola, " + text + "! ¿Qué puedo hacer hoy por ti?";
								case 146:
									return "¡Eh, hola, " + text5 + "! ¿Qué puedo hacer hoy por ti?";
								case 147:
									return "¡Eh, hola, " + text3 + "! ¿Qué puedo hacer hoy por ti?";
								case 148:
									return "¿Quieres que saque una moneda de detrás de tu oreja? ¿No? Está bien.";
								case 149:
									return "¿Quieres un caramelo mágico? ¿No? Vale.";
								case 150:
									return "Si te gusta, mejor te hago un delicioso chocolate calentito... ¿Tampoco? Vale, está bien.";
								case 151:
									return "¿Has venido a echar un ojo a mi bola de cristal?";
								case 152:
									return "¿Nunca has deseado tener un anillo mágico que convierta las piedras en babosas? La verdad es que yo tampoco.";
								case 153:
									return "Una vez me dijeron que la amistad es algo mágico. ¡Ridículo! No puedes convertir a nadie en rana con la amistad.";
								case 154:
									return "Veo tu futuro... ¡Vas a comprarme un montón de artículos!";
								case 155:
									return "En cierta ocasión intenté devolverle la vida a una estatua de ángel. Pero no pasó nada.";
								case 156:
									return "¡Gracias! Era cuestión de tiempo que acabar como los demás esqueletos de ahí abajo.";
								case 157:
									return "¡Eh, mira por donde vas! ¡Llevo ahí desde hace... un rato!";
								case 158:
									return "Espera un momento, más abajo tengo wifi.";
								case 159:
									return "¡Casi había acabado de poner luces intermitentes aquí arriba!";
								case 160:
									return "NO TE MUEVAS. DEJÉ CAER MI LENTE DE CONTACTO.";
								case 161:
									return "Lo único que quiero es que el conmutador haga... ¿Qué?";
								case 162:
									return "A ver si lo adivino. No has comprado suficiente cable. ¡Serás tonto!";
								case 163:
									return "¿Podrías...? Solo... ¿Por favor...? ¿Vale? Está bien. Arrg.";
								case 164:
									return "No me gusta cómo me miras. Ahora estoy TRABAJANDO.";
								case 165:
									return string.Concat(new string[]
									{
										"Eh, ",
										Main.player[Main.myPlayer].name,
										"¿acabas de llegar de la casa de ",
										text4,
										"? ¿Por casualidad no te hablaría de mí?"
									});
								case 166:
									return text2 + " sigue insistiendo en pulir mi chapa de presión. Ya le he dicho que funciona pisándola.";
								case 167:
									return "¡Siempre compras más cable del que necesitas!";
								case 168:
									return "¿Has comprobado que ese dispositivo esté enchufado?";
								case 169:
									return "Oh, ¿sabes lo que necesita esta casa? Más luces intermitentes.";
								case 170:
									return "Sabrás que se avecina una luna sangrienta cuando el cielo se tiña de rojo. Hay algo en ella que hace que los monstruos ataquen en grupo.";
								case 171:
									return "Eh, amigo, ¿sabes dónde hay por aquí malahierba? Oh, no es por nada, solo preguntaba, nada más.";
								case 172:
									return "Si miraras hacia arriba, verías que ahora mismo la luna está roja.";
								case 173:
									return "Deberías quedarte en casa por la noche. Es muy peligroso andar por ahí en la oscuridad.";
								case 174:
									return "Saludos, " + Main.player[Main.myPlayer].name + ". ¿Te puedo ayudar en algo?";
								case 175:
									return "Estoy aquí para aconsejarte sobre lo que debes ir haciendo. Te aconsejo que hables conmigo cuando estés atascado.";
								case 176:
									return "Dicen que hay una persona que te dirá cómo sobrevivir en esta tierra... oh, espera, sí soy yo.";
								case 177:
									return "Puedes usar el pico para cavar en la tierra y el hacha para talar árboles. Sitúa el cursor sobre el ladrillo y haz clic.";
								case 178:
									return "Si quieres sobrevivir, tendrás que crear armas y un refugio. Empieza talando árboles y recogiendo madera.";
								case 179:
									return "Pulsa ESC para acceder al menú de producción. Cuando tengas suficiente madera, crea un banco de trabajo, de este modo podrás crear otros objetos más elaborados siempre que permanezcas cerca del banco.";
								case 180:
									return "Puedes construir un refugio juntando madera y otros bloques que hay por el mundo. No olvides levantar y colocar paredes.";
								case 181:
									return "En cuanto tengas una espada de madera, puedes intentar recoger la baba de las babosas. Mezcla madera y baba para hacer una antorcha.";
								case 182:
									return "Para interactuar con el entorno y colocar objetos usa un martillo.";
								case 183:
									return "Deberías cavar una mina para encontrar mena de oro, con ella puedes crear objetos muy útiles.";
								case 184:
									return "Ahora que tienes un poco de oro, tendrás que convertirlo en un lingote para poder hacer objetos con él. Para ello necesitas un horno.";
								case 185:
									return "Puedes construir un horno con antorchas, madera y piedra. Asegúrate de no alejarte del banco de trabajo.";
								case 186:
									return "Necesitarás un yunque para crear objetos con los lingotes de metal.";
								case 187:
									return "Los yunques se pueden hacer de hierro o bien comprarse a un mercader.";
								case 188:
									return "En el Subsuelo hay corazones de cristal que puedes usar para aumentar al máximo tu vida. Para recogerlos, necesitarás un martillo.";
								case 189:
									return "Si recoges 10 estrellas caídas, podrás combinarlas para crear un objeto que aumente tu poder mágico.";
								case 190:
									return "Las estrellas caen del cielo a la tierra por la noche. Se pueden utilizar para toda clase de objetos útiles. Si ves una, date prisa en cogerla ya que desaparecen al amanecer.";
								case 191:
									return "Hay muchas formas de hacer que los demás se muden a nuestra ciudad. Por supuesto, necesitarán una casa en la que vivir.";
								case 192:
									return "Para que una habitación pueda ser considerada un hogar, debe tener una puerta, una silla, una mesa y una fuente de luz. No te olvides de las paredes de la casa.";
								case 193:
									return "En la misma casa no pueden vivir dos personas. Además, si se destruye una casa, esa persona deberá buscar un nuevo lugar donde vivir.";
								case 194:
									return "En la interfaz de vivienda puedes ver y asignar viviendas. Abre tu inventario y haz clic en el icono de casa.";
								case 195:
									return "Si quieres que un mercader se mude a una casa, deberás recoger una gran cantidad de dinero. Bastarán con 50 monedas de plata.";
								case 196:
									return "Para que se mude una enfermera, tendrías que aumentar al máximo tu nivel de vida.";
								case 197:
									return "Si tuvieras alguna pistola, seguro que aparecería algún traficante de armas para venderte municiones.";
								case 198:
									return "Deberías ponerte a prueba y derrotar a un monstruo corpulento. Eso llamaría la atención de una dríada.";
								case 199:
									return "Asegúrate de explorar la mazmorra a fondo. Podría haber prisioneros retenidos en la parte más profunda.";
								case 200:
									return "Quizás el anciano de la mazmorra quiera unirse a nosotros ahora que su maldición ha desaparecido.";
								case 201:
									return "Guarda bien las bombas que encuentres. Algún dinamitero querrá echarles un vistazo.";
								case 202:
									return "¿En realidad los duendes son tan distintos a nosotros que no podríamos vivir juntos en paz?";
								case 203:
									return "He oído que por esta región vive un poderoso mago. Estate muy atento por si lo ves la próxima vez que viajes al Subsuelo.";
								case 204:
									return "Si juntas varios lentes en un altar demoníaco, probablemente encuentres la forma de invocar a un monstruo poderoso. Aunque te conviene esperar hasta la noche para hacerlo.";
								case 205:
									return "Puedes hacer cebo de gusanos con trozos podridos y polvo vil. Asegúrate de estar en una zona corrompida antes de usarlo.";
								case 206:
									return "Los altares demoníacos se suelen encontrar en La Corrupción. Deberás estar cerca de los altares para crear objetos nuevos.";
								case 207:
									return "Puedes hacerte un garfio extensible con un garfio y 3 cadenas. Los esqueletos se encuentran en las profundidades del Subsuelo y suelen llevar garfios; se pueden hacer cadenas con lingotes de hierro.";
								case 208:
									return "Si ves un jarron, ábrelo aunque sea a golpes. Contienen toda clase de suministros de utilidad.";
								case 209:
									return "Hay un tesoro escondido por el mundo. ¡En las profundidades del Subsuelo se pueden encontrar objetos maravillosos!";
								case 210:
									return "Romper un orbe de las sombras a veces provoca la caída de un meteorito del cielo. Los orbes de las sombras se suelen encontrar en los abismos que rodean las zonas corrompidas";
								case 211:
									return "Deberías dedicarte a recoger más corazones de cristal para aumentar tu nivel de vida hasta el máximo.";
								case 212:
									return "El equipo que llevas sencillamente no sirve. Debes mejorar tu armadura.";
								case 213:
									return "Creo que ya estás listo para tu primer gran batalla. Recoge de noche algunas lentes de los ojos y llévalas a un altar demoníaco.";
								case 214:
									return "Te conviene aumentar tu nivel de vida antes de enfrentarte al siguiente desafío. Con 15 corazones bastará.";
								case 215:
									return "La piedra de ébano que se encuentra en La Corrupción se puede purificar usando un poco de polvo de una dríada, o bien puedes destruirla con explosivos.";
								case 216:
									return "El siguiente paso debería ser explorar los abismos corrompidos. Encuentra y destruye todos los orbes de las sombras que encuentres.";
								case 217:
									return "No muy lejos de aquí hay una antigua mazmorra. Ahora sería un buen momento para ir a echar un vistazo.";
								case 218:
									return "Deberías intentar aumentar al máximo el nivel de vida que te queda. Prueba con 20 corazones.";
								case 219:
									return "Hay muchos tesoros por descubrir en la selva si estás dispuesto a cavar a suficiente profundidad.";
								case 220:
									return "El Inframundo se compone de un material llamado piedra infernal, perfecta para hacer armas y armaduras.";
								case 221:
									return "Cuando estés preparado para desafiar al guardián del Inframundo, tendrás que hacer un sacrificio viviente. Todo lo que necesitas para hacerlo lo encontrarás en el Inframundo.";
								case 222:
									return "No dejes de destruir todos los altares demoníacos que encuentres. ¡Algo bueno te sucederá si lo haces!";
								case 223:
									return "A veces las almas se congregan en las criaturas caídas, en lugares de extrema luminosidad u oscuridad.";
								case 224:
									return "Ho ho ho y una botella de ... Ponche de huevo!";
								case 225:
									return "Cuidado que me galletitas?";
								case 226:
									return "¿Qué? Pensaste que no era real?";
								case 227:
									return "Me las arreglé para coser la cara de nuevo. Tener más cuidado la próxima vez.";
								case 228:
									return "Que probablemente va a dejar una cicatriz.";
								case 229:
									return "Todos los mejores. No quiero verte saltar ya los acantilados.";
								case 230:
									return "Que no le dolía demasiado malo, ya lo hizo?";
								case 231:
									return "Como si vivir bajo tierra no fuera suficientemente malo, idiotas como tú vienes mientras duermo y robar mis hijos.";
								case 232:
									return "Entre tú y yo, " + text3 + " es el único en quien confío. Ella es el único aquí que no se ha probado a comer o me utilice en una poción.";
								case 233:
									return "Traté de lamer mi mismo el otro día para ver lo que era la gran cosa, todo empezó azul brillante.";
								case 234:
									return "Cada vez que veo el color azul, que me hace deprimido y perezoso.";
								case 235:
									return "Usted no ha visto ningún cerdo de por aquí tienen ustedes? Mi hermano perdió la pierna a uno.";
								case 236:
									return "Todo el mundo en esta ciudad se siente un poco fuera. Me desperté a la fabricante de ropa de mascar en mi pie anoche.";
								case 237:
									return "Te voy a dar un descuento en su desgastes si se puede convencer a " + str4 + " venir a un ... tamaño.";
								case 238:
									return "Me siento como " + str4 + " es un poco incomprendido, que realmente es un tipo divertido.";
								case 240:
									return "No sé la Truffle Shuffle, así que deja de preguntar!";
								case 241:
									return "Ha habido un enorme rumor de tal manera que está siendo difundida por mí, 'Si no puedes vencerlo, comérselo!";
								case 242:
									return "Oy, ¿qué tienes en tu fluffer jiminy?";
								case 243:
									return "Debería convertirse en un pirata del aire? He pensado en convertirse en un pirata del aire.";
								case 244:
									return "Ya se trate de lo que sería, un jetpack que se adapte muy bien!";
								case 245:
									return "Me siento un poco mal humor en los últimos tiempos, por lo que basta con su palabrería que ragamuffin!";
								case 246:
									return "Estoy muy curioso acerca de ese tipo " + str6 + ". ¿Con qué tipo de consumo no se mantiene como la locomoción?";
								case 247:
									return "Ese tipo capitán me parece ser bastante bien a la bahía si sabes lo que significa!";
								case 248:
									return "Muéstrame algunas artes!";
								case 249:
									return "Me gusta su ... engranajes. ¿Viene en bronce?";
								case 250:
									return "Una vez que ingrese la tierra santificada, verá un arco iris en el cielo. Te puedo ayudar con la pintura que, si lo desea.";
								case 251:
									return "Echa un vistazo a " + str5 + ". Eso sí que es una chica que es capaz de pintar la ciudad de rojo!";
								case 252:
									return "Conozco la diferencia entre turquesa y azul-verde. Pero no voy a decirte.";
								case 253:
									return "Estoy de blanco de titanio, por lo que ni siquiera preguntar.";
								case 254:
									return "Pruebe swirly rosa y púrpura, que funciona, lo juro!";
								case 255:
									return "No, no, no ... Hay toneladas de diferentes grises! No me refiero a ...";
								case 256:
									return "Espero que no llueva otra vez hasta que esta pintura seca. Eso sería un desastre!";
								case 257:
									return "Les traigo los colores más ricos a cambio de sus riquezas!";
								case 258:
									return "Querida, lo que llevas puesto es demasiado monótono. Es absolutamente necesario tomar una lección en el teñido de su traje cansado!";
								case 259:
									return "El único tipo de madera me molesta es teñido de caoba. Teñido cualquier otra madera es un desperdicio.";
								case 260:
									return "Tienes que hacer algo con " + str7 + ".  Cada vez que venga por aquí, me lleva una semana para conseguir el olor de descuento!";
								case 261:
									return "¿Qué médico soy yo? El médico brujo que soy.";
								case 262:
									return "El corazón de la magia es la naturaleza. La naturaleza de los corazones es magia.";
								case 263:
									return text + " puede ayudar a sanar su cuerpo, pero puedo hacer que encarnan la curación.";
								case 264:
									return "Elija con cuidado, " + Main.player[Main.myPlayer].name + ", mis productos son volátiles y mi arte oscuro, misterioso.";
								case 265:
									return "Tenemos que hablar. Es ... se trata de los partidos.";
								case 266:
									return "No puedo decidir lo que me gusta más: las partes, o después de los partidos.";
								case 267:
									return "Debemos crear un grupo de blinkroot, y también hay que establecer un después de la fiesta.";
								case 268:
									return "Wow, " + Main.player[Main.myPlayer].name + ", encontrarse con un hombre aventurero como tú me da ganas de fiesta!";
								case 269:
									return "Ponga una bola de discoteca y luego te voy a mostrar cómo divertirse.";
								case 270:
									return "Fui a Suecia una vez, el partido duro, ¿por qué no te parece?";
								case 271:
									return "Mi nombre es " + str5 + " pero la gente me llama partido popper. Sí. No sé, suena guay";
								case 272:
									return "¿Es usted parte? A veces? Hm, bien entonces podemos hablar ...";
								case 273:
									return "No soy un amante de la tierra, pero es mejor haber amado y perdido que nunca de amar a todos.";
								case 274:
									return "Yo ho ho y una botella de ...blinkroots!";
								case 275:
									return "YAR!  Es curioso que lo mencionaremos loros porque ... um ... ¿De qué estábamos hablando?";
								case 276:
									return Main.player[Main.myPlayer].name + ", Vosotros sois una de las mejores jovencitas buscan esto aquí capitán ha visto en muchas de quince días!";
								case 277:
									return "Manténgase fuera de mí botín, que Canalla!";
								case 278:
									return "Lo que en llamas estás hablando? Moby Dick es la mía!";
								case 279:
									return "*Yarr Blarr Harrdarr*";
								case 280:
									return "Y entonces Unidad 492-8 dijo: Quién te crees que soy, Unidad 472-6? HA. HA. HA.";
								case 281:
									return "Mi eficiencia expedición se redujo crítica cuando un proyectil impactó mi locomotora actuador.";
								case 282:
									return "Esta oración es falsa, ¿o no?";
								case 283:
									return "Así que 'punk chick buscando es un inventor, eh? Creo que ella pudiera mostrarle una cosa o dos!";
								case 284:
									return "Claro, " + str7 + " y yo somos amigos, pero no me gusta cuando su loro hace su negocio en mí. Corrosiva es esa cosa!";
								case 285:
									return "Yo mismo construí un mecanismo gusto, así que me puedo beber un poco de cerveza!";
								case 286:
									return "A veces salgo un poco ... ¿Lo entiendes? un poco?";
								}
							}
						}
					}
				}
			}
			if (!english && Lang.lang > 1)
			{
				return Lang.dialog(l, true);
			}
			return "";
		}
		public static string setBonus(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
				case 0:
					return "2 defense";
				case 1:
					return "3 defense";
				case 2:
					return "15% increased movement speed";
				case 3:
					return "Space Gun costs 0 mana";
				case 4:
					return "20% chance to not consume ammo";
				case 5:
					return "16% reduced mana usage";
				case 6:
					return "17% extra melee damage";
				case 7:
					return "30% increased mining speed";
				case 8:
					return "14% reduced mana usage";
				case 9:
					return "15% increased melee speed";
				case 10:
					return "20% chance to not consume ammo";
				case 11:
					return "17% reduced mana usage";
				case 12:
					return "5% increased melee critical strike chance";
				case 13:
					return "20% chance to not consume ammo";
				case 14:
					return "19% reduced mana usage";
				case 15:
					return "18% increased melee and movement speed";
				case 16:
					return "25% chance to not consume ammo";
				case 17:
					return "20% reduced mana usage";
				case 18:
					return "19% increased melee and movement speed";
				case 19:
					return "25% chance to not consume ammo";
				case 20:
					return "1 defense";
				case 21:
					return "Greatly increased life regen";
				case 22:
					return "Melee and ranged attacks cause frostburn";
				case 23:
					return "Increases your max number of minions";
				case 24:
					return "Greatly increases life regeneration after striking an enemy";
				case 25:
					return "Flower petals will fall on your target for extra damage";
				case 26:
					return "Become immune after striking an enemy";
				case 27:
					return "Summons a powerful leaf crystal to shoot at nearby enemies";
				case 28:
					return "10% increased magic critical strike chance";
				case 29:
					return "Attackers also take full damage";
				case 30:
					return "Magic damage done to enemies heals the player with lowest health";
				case 31:
					return "Not moving puts you stealth, increasing ranged ability and reducing chance for enemies to target you";
				case 32:
					return "4 defense";
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					switch (l)
					{
					case 0:
						return "2 Abwehr";
					case 1:
						return "3 Abwehr";
					case 2:
						return "Um 15% erhoehtes Bewegungstempo";
					case 3:
						return "Astralpistole kostet 0 Mana";
					case 4:
						return "20%ige Chance, Munition nicht zu verbrauchen";
					case 5:
						return "Um 16% reduzierte Mananutzung";
					case 6:
						return "17% Extra Nahkampfschaden";
					case 7:
						return "Um 20% erhoehtes Abbautempo";
					case 8:
						return "Um 14% reduzierte Mananutzung";
					case 9:
						return "Um 15% erhoehtes Nahkampftempo";
					case 10:
						return "20%ige Chance, Munition nicht zu verbrauchen";
					case 11:
						return "Um 17% reduzierte Mananutzung";
					case 12:
						return "5% Erhoehte kritische Nahkampf-Trefferchance";
					case 13:
						return "20%ige Chance, Munition nicht zu verbrauchen";
					case 14:
						return "Um 19% reduzierte Mananutzung";
					case 15:
						return "18% Erhoehtes Nahkampf-und Bewegungstempo";
					case 16:
						return "25%ige Chance, Munition nicht zu verbrauchen";
					case 17:
						return "Um 20% reduzierte Mananutzung";
					case 18:
						return "19% Erhoehtes Nahkampf-und Bewegungstempo";
					case 19:
						return "25%ige Chance, Munition nicht zu verbrauchen";
					case 20:
						return "4 defense";
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						switch (l)
						{
						case 0:
							return "2 difesa";
						case 1:
							return "3 difesa";
						case 2:
							return "Velocità di movimento aumentata del 15%";
						case 3:
							return "La pistola spaziale costa 0 mana";
						case 4:
							return "20% di possibilità di non consumare munizioni";
						case 5:
							return "Consumo mana ridotto del 16%";
						case 6:
							return "17% i danni melee in più";
						case 7:
							return "Velocità di estrazione aumentata del 20%";
						case 8:
							return "Consumo mana ridotto del 14%";
						case 9:
							return "Velocità del corpo a corpo aumentata del 15%";
						case 10:
							return "20% di possibilità di non consumare munizioni";
						case 11:
							return "Consumo mana ridotto del 17%";
						case 12:
							return "5% Possibilità di colpo critico nel corpo a corpo aumentata";
						case 13:
							return "20% di possibilità di non consumare munizioni";
						case 14:
							return "Consumo mana ridotto del 19%";
						case 15:
							return "18% Velocità di corpo a corpo e movimento aumentata";
						case 16:
							return "25% di possibilità di non consumare munizioni";
						case 17:
							return "Consumo mana ridotto del 20%";
						case 18:
							return "19% Velocità di corpo a corpo e movimento aumentata";
						case 19:
							return "25% di possibilità di non consumare munizioni";
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							switch (l)
							{
							case 0:
								return "2 de défense";
							case 1:
								return "3 de défense";
							case 2:
								return "Vitesse de déplacement augmentée de 15 %";
							case 3:
								return "Le fusil de l'espace coûte 0 mana";
							case 4:
								return "20 % de chance de n'utiliser aucune munition";
							case 5:
								return "Utilisation de mana réduite de 16 %";
							case 6:
								return "17% de dégâts de mêlée supplémentaires";
							case 7:
								return "Vitesse d'extraction minière augmentée de 20 %";
							case 8:
								return "Utilisation de mana réduite de 14 %";
							case 9:
								return "Vitesse de mêlée augmentée de 15 %";
							case 10:
								return "20 % de chance de n'utiliser aucune munition";
							case 11:
								return "Utilisation de mana réduite de 17 %";
							case 12:
								return "5% Chance de coup critique de mêlée augmentée";
							case 13:
								return "20 % de chance de n'utiliser aucune munition";
							case 14:
								return "Utilisation de mana réduite de 19 %";
							case 15:
								return "18% Vitesse de mouvement et de mêlée augmentée";
							case 16:
								return "25 % de chance de n'utiliser aucune munition";
							case 17:
								return "Utilisation de mana réduite de 20 %";
							case 18:
								return "19% Vitesse de mouvement et de mêlée augmentée";
							case 19:
								return "25 % de chance de n'utiliser aucune munition";
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								switch (l)
								{
								case 0:
									return "2 defensa";
								case 1:
									return "3 defensa";
								case 2:
									return "Aumenta en un 15% la velocidad de movimiento";
								case 3:
									return "La pistola espacial no cuesta maná";
								case 4:
									return "Probabilidad del 20% de no gastar munición";
								case 5:
									return "Reduce el uso de maná en un 16%";
								case 6:
									return "17% de daño cuerpo a cuerpo adicional";
								case 7:
									return "Aumenta en un 20% la velocidad de excavación";
								case 8:
									return "Reduce el uso de maná en un 14%";
								case 9:
									return "Aumenta un 15% la velocidad en el cuerpo a cuerpo";
								case 10:
									return "Probabilidad del 20% de no gastar munición";
								case 11:
									return "Reduce el uso de maná en un 17%";
								case 12:
									return "Aumenta la probabilidad de ataque crítico en el cuerpo a cuerpo";
								case 13:
									return "Probabilidad del 20% de no gastar munición";
								case 14:
									return "Reduce el uso de maná en un 19%";
								case 15:
									return "18% Aumenta la velocidad de movimiento y en el cuerpo a cuerpo";
								case 16:
									return "Probabilidad del 25% de no gastar munición";
								case 17:
									return "Reduce el uso de maná en un 20%";
								case 18:
									return "19% Aumenta la velocidad de movimiento y en el cuerpo a cuerpo";
								case 19:
									return "Probabilidad del 25% de no gastar munición";
								}
							}
						}
					}
				}
			}
			if (!english && Lang.lang > 1)
			{
				return Lang.setBonus(l, true);
			}
			return "";
		}
		public static string npcName(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
				case -65:
					return "Hornet";
				case -64:
					return "Hornet";
				case -63:
					return "Hornet";
				case -62:
					return "Hornet";
				case -61:
					return "Hornet";
				case -60:
					return "Hornet";
				case -59:
					return "Hornet";
				case -58:
					return "Hornet";
				case -57:
					return "Hornet";
				case -56:
					return "Hornet";
				case -55:
					return "Zombie";
				case -54:
					return "Zombie";
				case -53:
					return "Skeleton";
				case -52:
					return "Skeleton";
				case -51:
					return "Skeleton";
				case -50:
					return "Skeleton";
				case -49:
					return "Skeleton";
				case -48:
					return "Skeleton";
				case -47:
					return "Skeleton";
				case -46:
					return "Skeleton";
				case -45:
					return "Zombie";
				case -44:
					return "Zombie";
				case -43:
					return "Demon Eye";
				case -42:
					return "Demon Eye";
				case -41:
					return "Demon Eye";
				case -40:
					return "Demon Eye";
				case -39:
					return "Demon Eye";
				case -38:
					return "Demon Eye";
				case -37:
					return "Zombie";
				case -36:
					return "Zombie";
				case -35:
					return "Zombie";
				case -34:
					return "Zombie";
				case -33:
					return "Zombie";
				case -32:
					return "Zombie";
				case -31:
					return "Zombie";
				case -30:
					return "Zombie";
				case -29:
					return "Zombie";
				case -28:
					return "Zombie";
				case -27:
					return "Zombie";
				case -26:
					return "Zombie";
				case -25:
					return "Crimslime";
				case -24:
					return "Crimslime";
				case -23:
					return "Crimera";
				case -22:
					return "Crimera";
				case -21:
					return "Moss Hornet";
				case -20:
					return "Moss Hornet";
				case -19:
					return "Moss Hornet";
				case -18:
					return "Moss Hornet";
				case -17:
					return "Hornet";
				case -16:
					return "Hornet";
				case -15:
					return "Armored Skeleton";
				case -14:
					return "Angry Bones";
				case -13:
					return "Angry Bones";
				case -12:
					return "Eater of Souls";
				case -11:
					return "Eater of Souls";
				case -10:
					return "Jungle Slime";
				case -9:
					return "Yellow Slime";
				case -8:
					return "Red Slime";
				case -7:
					return "Purple Slime";
				case -6:
					return "Black Slime";
				case -5:
					return "Baby Slime";
				case -4:
					return "Pinky";
				case -3:
					return "Green Slime";
				case -2:
					return "Slimer";
				case -1:
					return "Slimeling";
				case 1:
					return "Blue Slime";
				case 2:
					return "Demon Eye";
				case 3:
					return "Zombie";
				case 4:
					return "Eye of Cthulhu";
				case 5:
					return "Servant of Cthulhu";
				case 6:
					return "Eater of Souls";
				case 7:
					return "Devourer";
				case 8:
					return "Devourer";
				case 9:
					return "Devourer";
				case 10:
					return "Giant Worm";
				case 11:
					return "Giant Worm";
				case 12:
					return "Giant Worm";
				case 13:
					return "Eater of Worlds";
				case 14:
					return "Eater of Worlds";
				case 15:
					return "Eater of Worlds";
				case 16:
					return "Mother Slime";
				case 17:
					return "Merchant";
				case 18:
					return "Nurse";
				case 19:
					return "Arms Dealer";
				case 20:
					return "Dryad";
				case 21:
					return "Skeleton";
				case 22:
					return "Guide";
				case 23:
					return "Meteor Head";
				case 24:
					return "Fire Imp";
				case 25:
					return "Burning Sphere";
				case 26:
					return "Goblin Peon";
				case 27:
					return "Goblin Thief";
				case 28:
					return "Goblin Warrior";
				case 29:
					return "Goblin Sorcerer";
				case 30:
					return "Chaos Ball";
				case 31:
					return "Angry Bones";
				case 32:
					return "Dark Caster";
				case 33:
					return "Water Sphere";
				case 34:
					return "Cursed Skull";
				case 35:
					return "Skeletron";
				case 36:
					return "Skeletron";
				case 37:
					return "Old Man";
				case 38:
					return "Demolitionist";
				case 39:
					return "Bone Serpent";
				case 40:
					return "Bone Serpent";
				case 41:
					return "Bone Serpent";
				case 42:
					return "Hornet";
				case 43:
					return "Man Eater";
				case 44:
					return "Undead Miner";
				case 45:
					return "Tim";
				case 46:
					return "Bunny";
				case 47:
					return "Corrupt Bunny";
				case 48:
					return "Harpy";
				case 49:
					return "Cave Bat";
				case 50:
					return "King Slime";
				case 51:
					return "Jungle Bat";
				case 52:
					return "Doctor Bones";
				case 53:
					return "The Groom";
				case 54:
					return "Clothier";
				case 55:
					return "Goldfish";
				case 56:
					return "Snatcher";
				case 57:
					return "Corrupt Goldfish";
				case 58:
					return "Piranha";
				case 59:
					return "Lava Slime";
				case 60:
					return "Hellbat";
				case 61:
					return "Vulture";
				case 62:
					return "Demon";
				case 63:
					return "Blue Jellyfish";
				case 64:
					return "Pink Jellyfish";
				case 65:
					return "Shark";
				case 66:
					return "Voodoo Demon";
				case 67:
					return "Crab";
				case 68:
					return "Dungeon Guardian";
				case 69:
					return "Antlion";
				case 70:
					return "Spike Ball";
				case 71:
					return "Dungeon Slime";
				case 72:
					return "Blazing Wheel";
				case 73:
					return "Goblin Scout";
				case 74:
					return "Bird";
				case 75:
					return "Pixie";
				case 77:
					return "Armored Skeleton";
				case 78:
					return "Mummy";
				case 79:
					return "Dark Mummy";
				case 80:
					return "Light Mummy";
				case 81:
					return "Corrupt Slime";
				case 82:
					return "Wraith";
				case 83:
					return "Cursed Hammer";
				case 84:
					return "Enchanted Sword";
				case 85:
					return "Mimic";
				case 86:
					return "Unicorn";
				case 87:
					return "Wyvern";
				case 88:
					return "Wyvern";
				case 89:
					return "Wyvern";
				case 90:
					return "Wyvern";
				case 91:
					return "Wyvern";
				case 92:
					return "Wyvern";
				case 93:
					return "Giant Bat";
				case 94:
					return "Corruptor";
				case 95:
					return "Digger";
				case 96:
					return "Digger";
				case 97:
					return "Digger";
				case 98:
					return "World Feeder";
				case 99:
					return "World Feeder";
				case 100:
					return "World Feeder";
				case 101:
					return "Clinger";
				case 102:
					return "Angler Fish";
				case 103:
					return "Green Jellyfish";
				case 104:
					return "Werewolf";
				case 105:
					return "Bound Goblin";
				case 106:
					return "Bound Wizard";
				case 107:
					return "Goblin Tinkerer";
				case 108:
					return "Wizard";
				case 109:
					return "Clown";
				case 110:
					return "Skeleton Archer";
				case 111:
					return "Goblin Archer";
				case 112:
					return "Vile Spit";
				case 113:
					return "Wall of Flesh";
				case 114:
					return "Wall of Flesh";
				case 115:
					return "The Hungry";
				case 116:
					return "The Hungry";
				case 117:
					return "Leech";
				case 118:
					return "Leech";
				case 119:
					return "Leech";
				case 120:
					return "Chaos Elemental";
				case 121:
					return "Slimer";
				case 122:
					return "Gastropod";
				case 123:
					return "Bound Mechanic";
				case 124:
					return "Mechanic";
				case 125:
					return "Retinazer";
				case 126:
					return "Spazmatism";
				case 127:
					return "Skeletron Prime";
				case 128:
					return "Prime Cannon";
				case 129:
					return "Prime Saw";
				case 130:
					return "Prime Vice";
				case 131:
					return "Prime Laser";
				case 132:
					return "Zombie";
				case 133:
					return "Wandering Eye";
				case 134:
					return "The Destroyer";
				case 135:
					return "The Destroyer";
				case 136:
					return "The Destroyer";
				case 137:
					return "Illuminant Bat";
				case 138:
					return "Illuminant Slime";
				case 139:
					return "Probe";
				case 140:
					return "Possessed Armor";
				case 141:
					return "Toxic Sludge";
				case 142:
					return "Santa Claus";
				case 143:
					return "Snowman Gangsta";
				case 144:
					return "Mister Stabby";
				case 145:
					return "Snow Balla";
				case 147:
					return "Ice Slime";
				case 148:
					return "Penguin";
				case 149:
					return "Penguin";
				case 150:
					return "Ice Bat";
				case 151:
					return "Lava Bat";
				case 152:
					return "Giant Flying Fox";
				case 153:
					return "Giant Tortoise";
				case 154:
					return "Ice Tortoise";
				case 155:
					return "Wolf";
				case 156:
					return "Red Devil";
				case 157:
					return "Arapaima";
				case 158:
					return "Vampire";
				case 159:
					return "Vampire";
				case 160:
					return "Truffle";
				case 161:
					return "Zombie Eskimo";
				case 162:
					return "Frankenstein";
				case 163:
					return "Black Recluse";
				case 164:
					return "Wall Creeper";
				case 165:
					return "Wall Creeper";
				case 166:
					return "Swamp Thing";
				case 167:
					return "Undead Viking";
				case 168:
					return "Corrupt Penguin";
				case 169:
					return "Ice Elemental";
				case 170:
					return "Pigron";
				case 171:
					return "Pigron";
				case 172:
					return "Rune Wizard";
				case 173:
					return "Crimera";
				case 174:
					return "Herpling";
				case 175:
					return "Angry Trapper";
				case 176:
					return "Moss Hornet";
				case 177:
					return "Derpling";
				case 178:
					return "Steampunker";
				case 179:
					return "Crimson Axe";
				case 180:
					return "Pigron";
				case 181:
					return "Face Monster";
				case 182:
					return "Floaty Gross";
				case 183:
					return "Crimslime";
				case 184:
					return "Spiked Ice Slime";
				case 185:
					return "Snow Flinx";
				case 186:
					return "Zombie";
				case 187:
					return "Zombie";
				case 188:
					return "Zombie";
				case 189:
					return "Zombie";
				case 190:
					return "Demon Eye";
				case 191:
					return "Demon Eye";
				case 192:
					return "Demon Eye";
				case 193:
					return "Demon Eye";
				case 194:
					return "Demon Eye";
				case 195:
					return "Lost Girl";
				case 196:
					return "Nymph";
				case 197:
					return "Armored Viking";
				case 198:
					return "Lihzahrd";
				case 199:
					return "Lihzahrd";
				case 200:
					return "Zombie";
				case 201:
					return "Skeleton";
				case 202:
					return "Skeleton";
				case 203:
					return "Skeleton";
				case 204:
					return "Spiked Jungle Slime";
				case 205:
					return "Moth";
				case 206:
					return "Icy Merman";
				case 207:
					return "Dye Trader";
				case 208:
					return "Party Girl";
				case 209:
					return "Cyborg";
				case 210:
					return "Bee";
				case 211:
					return "Bee";
				case 212:
					return "Pirate Deckhand";
				case 213:
					return "Pirate Corsair";
				case 214:
					return "Pirate Deadeye";
				case 215:
					return "Pirate Crossbower";
				case 216:
					return "Pirate Captain";
				case 217:
					return "Cochineal Beetle";
				case 218:
					return "Cyan Beetle";
				case 219:
					return "Lac Beetle";
				case 220:
					return "Sea Snail";
				case 221:
					return "Squid";
				case 222:
					return "Queen Bee";
				case 223:
					return "Zombie";
				case 224:
					return "Flying Fish";
				case 225:
					return "Umbrella Slime";
				case 226:
					return "Flying Snake";
				case 227:
					return "Painter";
				case 228:
					return "Witch Doctor";
				case 229:
					return "Pirate";
				case 230:
					return "Goldfish";
				case 231:
					return "Hornet";
				case 232:
					return "Hornet";
				case 233:
					return "Hornet";
				case 234:
					return "Hornet";
				case 235:
					return "Hornet";
				case 236:
					return "Jungle Creeper";
				case 237:
					return "Jungle Creeper";
				case 238:
					return "Black Recluse";
				case 239:
					return "Blood Crawler";
				case 240:
					return "Blood Crawler";
				case 241:
					return "Blood Feeder";
				case 242:
					return "Blood Jelly";
				case 243:
					return "Ice Golem";
				case 244:
					return "Rainbow Slime";
				case 245:
					return "Golem";
				case 246:
					return "Golem Head";
				case 247:
					return "Golem Fist";
				case 248:
					return "Golem Fist";
				case 249:
					return "Golem Head";
				case 250:
					return "Angry Nimbus";
				case 251:
					return "Eyezor";
				case 252:
					return "Parrot";
				case 253:
					return "Reaper";
				case 254:
					return "Zombie";
				case 255:
					return "Zombie";
				case 256:
					return "Fungo Fish";
				case 257:
					return "Anomura Fungus";
				case 258:
					return "Mushi Ladybug";
				case 259:
					return "Fungi Bulb";
				case 260:
					return "Giant Fungi Bulb";
				case 261:
					return "Fungi Spore";
				case 262:
					return "Plantera";
				case 263:
					return "Plantera's Hook";
				case 264:
					return "Plantera's Tentacle";
				case 265:
					return "Spore";
				case 266:
					return "Brain of Cthulhu";
				case 267:
					return "Creeper";
				case 268:
					return "Ichor Sticker";
				case 269:
					return "Rusty Armored Bones";
				case 270:
					return "Rusty Armored Bones";
				case 271:
					return "Rusty Armored Bones";
				case 272:
					return "Rusty Armored Bones";
				case 273:
					return "Blue Armored Bones";
				case 274:
					return "Blue Armored Bones";
				case 275:
					return "Blue Armored Bones";
				case 276:
					return "Blue Armored Bones";
				case 277:
					return "Hell Armored Bones";
				case 278:
					return "Hell Armored Bones";
				case 279:
					return "Hell Armored Bones";
				case 280:
					return "Hell Armored Bones";
				case 281:
					return "Ragged Caster";
				case 282:
					return "Ragged Caster";
				case 283:
					return "Necromancer";
				case 284:
					return "Necromancer";
				case 285:
					return "Diabolist";
				case 286:
					return "Diabolist";
				case 287:
					return "Bone Lee";
				case 288:
					return "Dungeon Spirit";
				case 289:
					return "Giant Cursed Skull";
				case 290:
					return "Paladin";
				case 291:
					return "Skeleton Sniper";
				case 292:
					return "Tactical Skeleton";
				case 293:
					return "Skeleton Commando";
				case 294:
					return "Angry Bones";
				case 295:
					return "Angry Bones";
				case 296:
					return "Angry Bones";
				case 297:
					return "Blue Jay";
				case 298:
					return "Cardinal";
				case 299:
					return "Squirrel";
				case 300:
					return "Mouse";
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					switch (l)
					{
					case -17:
						return "Riesenhornisse";
					case -16:
						return "Minihornisse";
					case -15:
						return "Mammutskelett";
					case -14:
						return "Grossknochen";
					case -13:
						return "Kleinknochen";
					case -12:
						return "Maxifresser";
					case -11:
						return "Minifresser";
					case -10:
						return "Dschungelschleimi";
					case -9:
						return "Gelbschleimi";
					case -8:
						return "Rotschleimi";
					case -7:
						return "Lila Schleimi";
					case -6:
						return "Schwarzschleimi";
					case -5:
						return "Schleimbaby";
					case -4:
						return "Pinky";
					case -3:
						return "Gruenschleimi";
					case -2:
						return "Flugschleimi";
					case -1:
						return "Schleimling";
					case 1:
						return "Blauschleimi";
					case 2:
						return "Daemonenauge";
					case 3:
						return "Zombie";
					case 4:
						return "Auge von Cthulhu";
					case 5:
						return "Diener von Cthulhu";
					case 6:
						return "Seelenfresser";
					case 7:
						return "Verschlinger";
					case 8:
						return "Verschlinger";
					case 9:
						return "Verschlinger";
					case 10:
						return "Riesenwurm";
					case 11:
						return "Riesenwurm";
					case 12:
						return "Riesenwurm";
					case 13:
						return "Weltenfresser";
					case 14:
						return "Weltenfresser";
					case 15:
						return "Weltenfresser";
					case 16:
						return "Schleimmami";
					case 17:
						return "Haendler";
					case 18:
						return "Krankenschwester";
					case 19:
						return "Waffenhaendler";
					case 20:
						return "Dryade";
					case 21:
						return "Skelett";
					case 22:
						return "Fremdenfuehrer";
					case 23:
						return "Meteorenkopf";
					case 24:
						return "Feuer-Imp";
					case 25:
						return "Flammenkugel";
					case 26:
						return "Goblin-Arbeiter";
					case 27:
						return "Goblin-Dieb";
					case 28:
						return "Goblin-Krieger";
					case 29:
						return "Goblin-Hexer";
					case 30:
						return "Chaoskugel";
					case 31:
						return "Wutknochen";
					case 32:
						return "Duestermagier";
					case 33:
						return "Wasserkugel";
					case 34:
						return "Fluchschaedel";
					case 35:
						return "Skeletron";
					case 36:
						return "Skeletron";
					case 37:
						return "Greis";
					case 38:
						return "Sprengmeister";
					case 39:
						return "Knochenschlange";
					case 40:
						return "Knochenschlange";
					case 41:
						return "Knochenschlange";
					case 42:
						return "Hornisse";
					case 43:
						return "Menschenfresser";
					case 44:
						return "Bergmann-Untoter";
					case 45:
						return "Tim";
					case 46:
						return "Haeschen";
					case 47:
						return "Verderbnishaeschen";
					case 48:
						return "Harpyie";
					case 49:
						return "Hoehlenfledermaus";
					case 50:
						return "Schleimi-Koenig";
					case 51:
						return "Dschungelfledermaus";
					case 52:
						return "Doktor Bones";
					case 53:
						return "Braeutigam";
					case 54:
						return "Kleiderhaendler";
					case 55:
						return "Goldfisch";
					case 56:
						return "Schnapper";
					case 57:
						return "Verderbnisgoldfisch";
					case 58:
						return "Piranha";
					case 59:
						return "Lava-Schleimi";
					case 60:
						return "Hoellenfledermaus";
					case 61:
						return "Geier";
					case 62:
						return "Daemon";
					case 63:
						return "Blauqualle";
					case 64:
						return "Pinkqualle";
					case 65:
						return "Hai";
					case 66:
						return "Voodoo-Daemon";
					case 67:
						return "Krabbe";
					case 68:
						return "Dungeon-Waechter";
					case 69:
						return "Ameisenloewe";
					case 70:
						return "Nagelball";
					case 71:
						return "Dungeon-Schleimi";
					case 72:
						return "Flammenrad";
					case 73:
						return "Goblin-Spaeher";
					case 74:
						return "Vogel";
					case 75:
						return "Pixie";
					case 76:
						return "";
					case 77:
						return "Ruestungsskelett";
					case 78:
						return "Mumie";
					case 79:
						return "Finstermumie";
					case 80:
						return "Lichtmumie";
					case 81:
						return "Verderbnisschleimi";
					case 82:
						return "Monstergeist";
					case 83:
						return "Fluchhammer";
					case 84:
						return "Zauberschwert";
					case 85:
						return "Imitator";
					case 86:
						return "Einhorn";
					case 87:
						return "Lindwurm";
					case 88:
						return "Lindwurm";
					case 89:
						return "Lindwurm";
					case 90:
						return "Lindwurm";
					case 91:
						return "Lindwurm";
					case 92:
						return "Lindwurm";
					case 93:
						return "Riesenfledermaus";
					case 94:
						return "Verderber";
					case 95:
						return "Wuehler";
					case 96:
						return "Wuehler";
					case 97:
						return "Wuehler";
					case 98:
						return "Weltspeiser";
					case 99:
						return "Weltspeiser";
					case 100:
						return "Weltspeiser";
					case 101:
						return "Klette";
					case 102:
						return "Seeteufel";
					case 103:
						return "Gruenqualle";
					case 104:
						return "Werwolf";
					case 105:
						return "Gebundener Goblin";
					case 106:
						return "Gebundener Zauberer";
					case 107:
						return "Goblin-Tueftler";
					case 108:
						return "Zauberer";
					case 109:
						return "Clown";
					case 110:
						return "Skelettbogenschuetze";
					case 111:
						return "Goblin-Bogenschuetze";
					case 112:
						return "Ekelspeichel";
					case 113:
						return "Fleischwand";
					case 114:
						return "Fleischwand";
					case 115:
						return "Fressmaul";
					case 116:
						return "Fressmaul";
					case 117:
						return "Blutegel";
					case 118:
						return "Blutegel";
					case 119:
						return "Blutegel";
					case 120:
						return "Elementarchaos";
					case 121:
						return "Flugschleimi";
					case 122:
						return "Bauchfuessler";
					case 123:
						return "Gebundene Mechanikerin";
					case 124:
						return "Mechanikerin";
					case 125:
						return "Retinator";
					case 126:
						return "Spasmator";
					case 127:
						return "Super-Skeletron";
					case 128:
						return "Super-Kanone";
					case 129:
						return "Super-Saege";
					case 130:
						return "Super-Zange";
					case 131:
						return "Super-Laser";
					case 132:
						return "Zombie";
					case 133:
						return "Wanderauge";
					case 134:
						return "Zerstoerer";
					case 135:
						return "Zerstoerer";
					case 136:
						return "Zerstoerer";
					case 137:
						return "Leuchtledermaus";
					case 138:
						return "Leuchtschleimi";
					case 139:
						return "Sonde";
					case 140:
						return "Geisterruestung";
					case 141:
						return "Giftschlamm";
					case 142:
						return "Weihnachtsmann";
					case 143:
						return "Snowman Gangsta";
					case 144:
						return "Herr Stabby";
					case 145:
						return "Schnee Balla";
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						switch (l)
						{
						case -17:
							return "Vespa grande";
						case -16:
							return "Vespa piccola";
						case -15:
							return "Scheletro pesante";
						case -14:
							return "Disossato";
						case -13:
							return "Ossa corte";
						case -12:
							return "Grande mangiatore";
						case -11:
							return "Piccolo mangiatore";
						case -10:
							return "Slime della giungla";
						case -9:
							return "Slime giallo";
						case -8:
							return "Slime rosso";
						case -7:
							return "Slime viola";
						case -6:
							return "Slime nero";
						case -5:
							return "Slime baby";
						case -4:
							return "Mignolo";
						case -3:
							return "Slime verde";
						case -2:
							return "Slimer";
						case -1:
							return "Slimeling";
						case 1:
							return "Slime blu";
						case 2:
							return "Occhio demoniaco";
						case 3:
							return "Zombi";
						case 4:
							return "Occhio di Cthulhu";
						case 5:
							return "Servo di Cthulhu";
						case 6:
							return "Mangiatore di anime";
						case 7:
							return "Divoratore";
						case 8:
							return "Divoratore";
						case 9:
							return "Divoratore";
						case 10:
							return "Verme gigante";
						case 11:
							return "Verme gigante";
						case 12:
							return "Verme gigante";
						case 13:
							return "Mangiatore di mondi";
						case 14:
							return "Mangiatore di mondi";
						case 15:
							return "Mangiatore di mondi";
						case 16:
							return "Slime madre";
						case 17:
							return "Mercante";
						case 18:
							return "Infermiera";
						case 19:
							return "Mercante di armi";
						case 20:
							return "Driade";
						case 21:
							return "Scheletro";
						case 22:
							return "Guida";
						case 23:
							return "Testa di meteorite";
						case 24:
							return "Diavoletto di fuoco";
						case 25:
							return "Sfera infuocata";
						case 26:
							return "Goblin operaio";
						case 27:
							return "Goblin ladro";
						case 28:
							return "Goblin guerriero";
						case 29:
							return "Goblin stregone";
						case 30:
							return "Palla del caos";
						case 31:
							return "Ossa arrabbiate";
						case 32:
							return "Lanciatore oscuro";
						case 33:
							return "Sfera d'acqua";
						case 34:
							return "Teschio maledetto";
						case 35:
							return "Skeletron";
						case 36:
							return "Skeletron";
						case 37:
							return "Vecchio";
						case 38:
							return "Esperto in demolizioni";
						case 39:
							return "Serpente di ossa";
						case 40:
							return "Serpente di ossa";
						case 41:
							return "Serpente di ossa";
						case 42:
							return "Calabrone";
						case 43:
							return "Mangiauomini";
						case 44:
							return "Minatore non-morto";
						case 45:
							return "Tim";
						case 46:
							return "Coniglio";
						case 47:
							return "Coniglio distrutto";
						case 48:
							return "Arpia";
						case 49:
							return "Pipistrello della caverna";
						case 50:
							return "Slime re";
						case 51:
							return "Pipistrello della giungla";
						case 52:
							return "Dottor ossa";
						case 53:
							return "Lo sposo";
						case 54:
							return "Mercante di abiti";
						case 55:
							return "Pesce rosso";
						case 56:
							return "Pianta afferratrice";
						case 57:
							return "Pesce rosso distrutto";
						case 58:
							return "Piranha";
						case 59:
							return "Slime di lava";
						case 60:
							return "Pipistrello dell'inferno";
						case 61:
							return "Avvoltoio";
						case 62:
							return "Demone";
						case 63:
							return "Medusa blu";
						case 64:
							return "Medusa rosa";
						case 65:
							return "Squalo";
						case 66:
							return "Demone voodoo";
						case 67:
							return "Granchio";
						case 68:
							return "Guardiano delle segrete";
						case 69:
							return "Formicaleone";
						case 70:
							return "Sfera con spuntoni";
						case 71:
							return "Slime delle segrete";
						case 72:
							return "Ruota ardente";
						case 73:
							return "Goblin ricognitore";
						case 74:
							return "Uccello";
						case 75:
							return "Folletto";
						case 76:
							return "";
						case 77:
							return "Scheletro corazzato";
						case 78:
							return "Mummia";
						case 79:
							return "Mummia oscura";
						case 80:
							return "Mummia chiara";
						case 81:
							return "Slime distrutto";
						case 82:
							return "Fantasma";
						case 83:
							return "Martello maledetto";
						case 84:
							return "Spada incantata";
						case 85:
							return "Sosia";
						case 86:
							return "Unicorno";
						case 87:
							return "Viverna";
						case 88:
							return "Viverna";
						case 89:
							return "Viverna";
						case 90:
							return "Viverna";
						case 91:
							return "Viverna";
						case 92:
							return "Viverna";
						case 93:
							return "Pipistrello gigante";
						case 94:
							return "Distruttore";
						case 95:
							return "Scavatore";
						case 96:
							return "Scavatore";
						case 97:
							return "Scavatore";
						case 98:
							return "Alimentatore del mondo";
						case 99:
							return "Alimentatore del mondo";
						case 100:
							return "Alimentatore del mondo";
						case 101:
							return "Appiccicoso";
						case 102:
							return "Rana pescatrice";
						case 103:
							return "Medusa verde";
						case 104:
							return "Lupo mannaro";
						case 105:
							return "Goblin legato";
						case 106:
							return "Stregone legato";
						case 107:
							return "Goblin inventore";
						case 108:
							return "Stregone";
						case 109:
							return "Clown";
						case 110:
							return "Scheletro arciere";
						case 111:
							return "Goblin arciere";
						case 112:
							return "Bava disgustosa";
						case 113:
							return "Muro di carne";
						case 114:
							return "Muro di carne";
						case 115:
							return "L'Affamato";
						case 116:
							return "L'Affamato";
						case 117:
							return "Sanguisuga";
						case 118:
							return "Sanguisuga";
						case 119:
							return "Sanguisuga";
						case 120:
							return "Elementale del caos";
						case 121:
							return "Slimer";
						case 122:
							return "Gasteropodo";
						case 123:
							return "Meccanico legata";
						case 124:
							return "Meccanico";
						case 125:
							return "Retinazer";
						case 126:
							return "Spazmatism";
						case 127:
							return "Skeletron primario";
						case 128:
							return "Cannone primario";
						case 129:
							return "Sega primaria";
						case 130:
							return "Morsa primaria";
						case 131:
							return "Laser primario";
						case 132:
							return "Zombi";
						case 133:
							return "Occhio errante";
						case 134:
							return "Il Distruttore";
						case 135:
							return "Il Distruttore";
						case 136:
							return "Il Distruttore";
						case 137:
							return "Pipistrello illuminante";
						case 138:
							return "Slime illuminante";
						case 139:
							return "Sonda";
						case 140:
							return "Armatura posseduta";
						case 141:
							return "Fango tossico";
						case 142:
							return "Babbo Natale";
						case 143:
							return "pupazzo di neve Gangsta";
						case 144:
							return "signor Stabby";
						case 145:
							return "neve Balla";
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							switch (l)
							{
							case -17:
								return "Gros frelon";
							case -16:
								return "Petit frelon";
							case -15:
								return "Squelette lourd";
							case -14:
								return "Grand squelette";
							case -13:
								return "Petit squelette";
							case -12:
								return "Grand dévoreur";
							case -11:
								return "Petit dévoreur";
							case -10:
								return "Slime de la jungle";
							case -9:
								return "Slime jaune";
							case -8:
								return "Slime rouge";
							case -7:
								return "Slime violet";
							case -6:
								return "Slime noir";
							case -5:
								return "Bébé slime";
							case -4:
								return "Pinky";
							case -3:
								return "Slime vert";
							case -2:
								return "Slimer";
							case -1:
								return "Slimeling";
							case 1:
								return "Slime bleu";
							case 2:
								return "Œil de démon";
							case 3:
								return "Zombie";
							case 4:
								return "Œil de Cthulhu";
							case 5:
								return "Servant de Cthulhu";
							case 6:
								return "Dévoreur d'âmes";
							case 7:
								return "Dévoreur";
							case 8:
								return "Dévoreur";
							case 9:
								return "Dévoreur";
							case 10:
								return "Ver géant";
							case 11:
								return "Ver géant";
							case 12:
								return "Ver géant";
							case 13:
								return "Dévoreur de mondes";
							case 14:
								return "Dévoreur de mondes";
							case 15:
								return "Dévoreur de mondes";
							case 16:
								return "Mère slime";
							case 17:
								return "Marchand";
							case 18:
								return "Infirmière";
							case 19:
								return "Marchand d'armes";
							case 20:
								return "Dryade";
							case 21:
								return "Squelette";
							case 22:
								return "Guide";
							case 23:
								return "Tête de météorite";
							case 24:
								return "Diablotin de feu";
							case 25:
								return "Sphère brûlante";
							case 26:
								return "Péon gobelin";
							case 27:
								return "Voleur gobelin";
							case 28:
								return "Guerrier gobelin";
							case 29:
								return "Sorcier gobelin";
							case 30:
								return "Boule de chaos";
							case 31:
								return "Squelette furieux";
							case 32:
								return "Magicien noir";
							case 33:
								return "Sphère d'eau";
							case 34:
								return "Crâne maudit";
							case 35:
								return "Squeletron";
							case 36:
								return "Squeletron";
							case 37:
								return "Vieil homme";
							case 38:
								return "Démolisseur";
							case 39:
								return "Serpent d'os";
							case 40:
								return "Serpent d'os";
							case 41:
								return "Serpent d'os";
							case 42:
								return "Frelon";
							case 43:
								return "Mangeur d'hommes";
							case 44:
								return "Mineur mort-vivant";
							case 45:
								return "Tim";
							case 46:
								return "Lapin";
							case 47:
								return "Lapin corrompu";
							case 48:
								return "Harpie";
							case 49:
								return "Chauve-souris";
							case 50:
								return "Roi slime";
							case 51:
								return "Chauve-souris de la jungle";
							case 52:
								return "Docteur Bones";
							case 53:
								return "Le jeune marié";
							case 54:
								return "Tailleur";
							case 55:
								return "Poisson doré";
							case 56:
								return "Ravisseur";
							case 57:
								return "Poisson doré corrompu";
							case 58:
								return "Piranha";
							case 59:
								return "Slime de l'enfer";
							case 60:
								return "Chauve-souris de l'enfer";
							case 61:
								return "Vautour";
							case 62:
								return "Démon";
							case 63:
								return "Méduse bleue";
							case 64:
								return "Méduse rose";
							case 65:
								return "Requin";
							case 66:
								return "Démon vaudou";
							case 67:
								return "Crabe";
							case 68:
								return "Gardien du donjon";
							case 69:
								return "Fourmilion";
							case 70:
								return "Boule piquante";
							case 71:
								return "Slime des donjons";
							case 72:
								return "Roue de feu";
							case 73:
								return "Scout gobelin";
							case 74:
								return "Oiseau";
							case 75:
								return "Lutin";
							case 76:
								return "";
							case 77:
								return "Squelette en armure";
							case 78:
								return "Momie";
							case 79:
								return "Momie de l'ombre";
							case 80:
								return "Momie de lumière";
							case 81:
								return "Slime corrompu";
							case 82:
								return "Spectre";
							case 83:
								return "Marteau maudit";
							case 84:
								return "Épée enchantée";
							case 85:
								return "Imitateur";
							case 86:
								return "Licorne";
							case 87:
								return "Wyverne";
							case 88:
								return "Wyverne";
							case 89:
								return "Wyverne";
							case 90:
								return "Wyverne";
							case 91:
								return "Wyverne";
							case 92:
								return "Wyverne";
							case 93:
								return "Chauve-souris géante";
							case 94:
								return "Corrupteur";
							case 95:
								return "Fouisseur";
							case 96:
								return "Fouisseur";
							case 97:
								return "Fouisseur";
							case 98:
								return "Nourricier";
							case 99:
								return "Nourricier";
							case 100:
								return "Nourricier";
							case 101:
								return "Cracheur";
							case 102:
								return "Baudroie";
							case 103:
								return "Méduse verte";
							case 104:
								return "Loup-garou";
							case 105:
								return "Gobelin attaché";
							case 106:
								return "Magicien attaché";
							case 107:
								return "Gobelin bricoleur";
							case 108:
								return "Magicien";
							case 109:
								return "Clown";
							case 110:
								return "Archer squelette";
							case 111:
								return "Archer gobelin";
							case 112:
								return "Immonde crachat";
							case 113:
								return "Mur de chair";
							case 114:
								return "Mur de chair";
							case 115:
								return "L'affamé";
							case 116:
								return "L'affamé";
							case 117:
								return "Sangsue";
							case 118:
								return "Sangsue";
							case 119:
								return "Sangsue";
							case 120:
								return "Élémentaire du chaos";
							case 121:
								return "Slimer";
							case 122:
								return "Gastropode";
							case 123:
								return "Mécanicienne attachée";
							case 124:
								return "Mécanicienne";
							case 125:
								return "Rétinazer";
							case 126:
								return "Spazmatisme";
							case 127:
								return "Squeletron primaire";
							case 128:
								return "Canon primaire";
							case 129:
								return "Scie primaire";
							case 130:
								return "Étau principal";
							case 131:
								return "Laser principal";
							case 132:
								return "Zombie";
							case 133:
								return "Œil vagabond";
							case 134:
								return "Le destructeur";
							case 135:
								return "Le destructeur";
							case 136:
								return "Le destructeur";
							case 137:
								return "Chauve-souris illuminée";
							case 138:
								return "Slime illuminé";
							case 139:
								return "Sonde";
							case 140:
								return "Armure possédée";
							case 141:
								return "Boue toxique";
							case 142:
								return "Père Noël";
							case 143:
								return "Snowman Gangsta";
							case 144:
								return "Monsieur Stabby";
							case 145:
								return "neige Balla";
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								switch (l)
								{
								case -17:
									return "Gran avispa";
								case -16:
									return "Avispa pequeña";
								case -15:
									return "Esqueleto pesado";
								case -14:
									return "Gran deshuesado";
								case -13:
									return "Pequeño deshuesado";
								case -12:
									return "Gran devorador";
								case -11:
									return "Pequeño devorador";
								case -10:
									return "Babosa de selva";
								case -9:
									return "Babosa amarilla";
								case -8:
									return "Babosa roja";
								case -7:
									return "Babosa morada";
								case -6:
									return "Babosa negra";
								case -5:
									return "Bebé babosa";
								case -4:
									return "Babosa rosa";
								case -3:
									return "Babosa verde";
								case -2:
									return "Baboseadora";
								case -1:
									return "Babosas";
								case 1:
									return "Babosa azul";
								case 2:
									return "Ojo demoníaco";
								case 3:
									return "Zombi";
								case 4:
									return "Ojo Cthulhu";
								case 5:
									return "Siervo de Cthulhu";
								case 6:
									return "Devoraalmas";
								case 7:
									return "Gusano devorador";
								case 8:
									return "Gusano devorador";
								case 9:
									return "Gusano devorador";
								case 10:
									return "Gusano gigante";
								case 11:
									return "Gusano gigante";
								case 12:
									return "Gusano gigante";
								case 13:
									return "Devoramundos";
								case 14:
									return "Devoramundos";
								case 15:
									return "Devoramundos";
								case 16:
									return "Mamá babosa";
								case 17:
									return "Mercader";
								case 18:
									return "Enfermera";
								case 19:
									return "Traficante de armas";
								case 20:
									return "Dríada";
								case 21:
									return "Esqueleto";
								case 22:
									return "Guía";
								case 23:
									return "Cabeza meteorito";
								case 24:
									return "Diablillo de fuego";
								case 25:
									return "Esfera ardiente";
								case 26:
									return "Duende Peón";
								case 27:
									return "Duende ladrón";
								case 28:
									return "Duende guerrero";
								case 29:
									return "Duende hechicero";
								case 30:
									return "Bola del caos";
								case 31:
									return "Deshuesado furioso";
								case 32:
									return "Fundidor siniestro";
								case 33:
									return "Esfera de agua";
								case 34:
									return "Cráneo maldito";
								case 35:
									return "Esqueletrón";
								case 36:
									return "Esqueletrón";
								case 37:
									return "Anciano";
								case 38:
									return "Dinamitero";
								case 39:
									return "Esqueleto de serpiente";
								case 40:
									return "Esqueleto de serpiente";
								case 41:
									return "Esqueleto de serpiente";
								case 42:
									return "Avispón";
								case 43:
									return "Devorahombres";
								case 44:
									return "Minero zombi";
								case 45:
									return "Tim";
								case 46:
									return "Conejito";
								case 47:
									return "Conejito corrompido";
								case 48:
									return "Arpía";
								case 49:
									return "Murciélago de cueva";
								case 50:
									return "Babosa rey";
								case 51:
									return "Murciélago de selva";
								case 52:
									return "Doctor Látigo";
								case 53:
									return "El novio zombi";
								case 54:
									return "Buhonero";
								case 55:
									return "Pececillo";
								case 56:
									return "Atrapadora";
								case 57:
									return "Pececillo corrompido";
								case 58:
									return "Piraña";
								case 59:
									return "Babosa de lava";
								case 60:
									return "Murciélago infernal";
								case 61:
									return "Buitre";
								case 62:
									return "Demonio";
								case 63:
									return "Medusa azul";
								case 64:
									return "Medusa rosa";
								case 65:
									return "Tiburón";
								case 66:
									return "Demonio vudú";
								case 67:
									return "Cangrejo";
								case 68:
									return "Guardián de la mazmorra";
								case 69:
									return "Hormiga león";
								case 70:
									return "Bola Gancho";
								case 71:
									return "Babosa de la mazmorra";
								case 72:
									return "Rueda ardiente";
								case 73:
									return "Duende explorador";
								case 74:
									return "Pájaro";
								case 75:
									return "Duendecillo";
								case 76:
									return "";
								case 77:
									return "Esqueleto con armadura";
								case 78:
									return "Momia";
								case 79:
									return "Momia de la oscuridad";
								case 80:
									return "Momia de la luz";
								case 81:
									return "Babosa corrompida";
								case 82:
									return "Espectro";
								case 83:
									return "Martillo maldito";
								case 84:
									return "Espada encantada";
								case 85:
									return "Cofre falso";
								case 86:
									return "Unicornio";
								case 87:
									return "Guiverno";
								case 88:
									return "Guiverno";
								case 89:
									return "Guiverno";
								case 90:
									return "Guiverno";
								case 91:
									return "Guiverno";
								case 92:
									return "Guiverno";
								case 93:
									return "Murciélago gigante";
								case 94:
									return "Corruptor";
								case 95:
									return "Excavador";
								case 96:
									return "Excavador";
								case 97:
									return "Excavador";
								case 98:
									return "Tragamundos";
								case 99:
									return "Tragamundos";
								case 100:
									return "Tragamundos";
								case 101:
									return "Lapa";
								case 102:
									return "Rape";
								case 103:
									return "Medusa verde";
								case 104:
									return "Hombre lobo";
								case 105:
									return "Duende cautivo";
								case 106:
									return "Mago cautivo";
								case 107:
									return "Duende reparador";
								case 108:
									return "Mago";
								case 109:
									return "Payaso";
								case 110:
									return "Esqueleto arquero";
								case 111:
									return "Duende arquero";
								case 112:
									return "Escupitajo vil";
								case 113:
									return "Muro carnoso";
								case 114:
									return "Muro carnoso";
								case 115:
									return "El Famélico";
								case 116:
									return "El Famélico";
								case 117:
									return "Sanguijuela";
								case 118:
									return "Sanguijuela";
								case 119:
									return "Sanguijuela";
								case 120:
									return "Caos elemental";
								case 121:
									return "Baboseadora";
								case 122:
									return "Gasterópodo";
								case 123:
									return "Mecánico cautivo";
								case 124:
									return "Mecánico";
								case 125:
									return "Retinator";
								case 126:
									return "Espasmatizador";
								case 127:
									return "Esqueleto mayor";
								case 128:
									return "Cañón mayor";
								case 129:
									return "Sierra mayor";
								case 130:
									return "Torno mayor";
								case 131:
									return "Láser mayor";
								case 132:
									return "Zombi";
								case 133:
									return "Ojo errante";
								case 134:
									return "El Destructor";
								case 135:
									return "El Destructor";
								case 136:
									return "El Destructor";
								case 137:
									return "Murciélago luminoso";
								case 138:
									return "Babosa luminosa";
								case 139:
									return "Sonda";
								case 140:
									return "Armadura poseída";
								case 141:
									return "Fango tóxico";
								case 142:
									return "Papá Noel";
								case 143:
									return "muñeco de nieve Gangsta";
								case 144:
									return "señor Stabby";
								case 145:
									return "Balla nieve";
								}
							}
						}
					}
				}
			}
			if (!english && Lang.lang > 1)
			{
				return Lang.npcName(l, true);
			}
			return "";
		}
		public static void tTip()
		{
			for (int i = 1; i < 1725; i++)
			{
				Item item = new Item();
				item.SetDefaults(i, false);
				if (item.toolTip2 != "" && item.toolTip2 != null)
				{
					string.Concat(new object[]
					{
						"case ",
						i,
						": return \"",
						item.toolTip2,
						"\";"
					});
				}
			}
		}
		public static string toolTip(int l, bool english = false)
		{
			if (l == 1372)
			{
				return "'W. Garner'";
			}
			if (l == 1373)
			{
				return "'W. Garner'";
			}
			if (l == 1374)
			{
				return "'W. Garner'";
			}
			if (l == 1375)
			{
				return "'W. Garner'";
			}
			if (l == 1419)
			{
				return "'W. Garner'";
			}
			if (l == 1420)
			{
				return "'W. Garner'";
			}
			if (l == 1421)
			{
				return "'W. Garner'";
			}
			if (l == 1425)
			{
				return "'W. Garner'";
			}
			if (l == 1426)
			{
				return "'W. Garner'";
			}
			if (l == 1427)
			{
				return "'W. Garner'";
			}
			if (l == 1428)
			{
				return "'W. Garner'";
			}
			if (l == 1443)
			{
				return "'W. Garner'";
			}
			if (l == 1501)
			{
				return "'W. Garner'";
			}
			if (l == 1573)
			{
				return "'W. Garner'";
			}
			if (l == 1574)
			{
				return "'W. Garner'";
			}
			if (l == 1575)
			{
				return "'W. Garner'";
			}
			if (l == 1422)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1423)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1435)
			{
				return "'R. Moosdijk'";
			}
			if (l == 1424)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1436)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1437)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1438)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1439)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1440)
			{
				return "'V. Costa Moura'";
			}
			if (l == 1442)
			{
				return "'V. Costa Moura'";
			}
			if (l >= 1481 && l <= 1494)
			{
				return "'V. Costa Moura'";
			}
			if (l >= 1476 && l <= 1480)
			{
				return "'J. T. Myhre'";
			}
			if (l >= 1496 && l <= 1499)
			{
				return "'J. T. Myhre'";
			}
			if (l == 1538)
			{
				return "'J. T. Myhre'";
			}
			if (l >= 1539 && l <= 1542)
			{
				return "'A. Craig'";
			}
			if (l == 1433)
			{
				return "'K. Wright'";
			}
			if (l == 1441)
			{
				return "'A. G. Kolf'";
			}
			if (l == 1500)
			{
				return "'A. G. Kolf'";
			}
			if (l == 1495)
			{
				return "'A. G. Kolf'";
			}
			if (l == 1576)
			{
				return "'D. Phelps'";
			}
			if (l == 1577)
			{
				return "'M. J. Duncan'";
			}
			if (l == 1434)
			{
				return "'C. J. Ness'";
			}
			if (l == 1502)
			{
				return "'C. Burczyk'";
			}
			if (Lang.lang <= 1 || english)
			{
				if (l <= 332)
				{
					if (l <= 128)
					{
						if (l <= 29)
						{
							if (l <= -1)
							{
								if (l == -43)
								{
									return "Can mine Meteorite";
								}
								if (l == -37)
								{
									return "Can mine Meteorite";
								}
								if (l == -1)
								{
									return "Can mine Meteorite";
								}
							}
							else
							{
								if (l == 8)
								{
									return "Provides light";
								}
								switch (l)
								{
								case 15:
									return "Tells the time";
								case 16:
									return "Tells the time";
								case 17:
									return "Tells the time";
								case 18:
									return "Shows depth";
								case 19:
								case 20:
								case 21:
								case 22:
									break;
								case 23:
									return "'Both tasty and flammable'";
								default:
									if (l == 29)
									{
										return "Permanently increases maximum life by 20";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 70)
							{
								switch (l)
								{
								case 33:
									return "Used for smelting ore";
								case 34:
									break;
								case 35:
									return "Used to craft items from metal bars";
								case 36:
									return "Used for basic crafting";
								default:
									if (l == 43)
									{
										return "Summons the Eye of Cthulhu";
									}
									switch (l)
									{
									case 49:
										return "Slowly regenerates life";
									case 50:
										return "Gaze in the mirror to return home";
									case 53:
										return "Allows the holder to double jump";
									case 54:
										return "The wearer can run super fast";
									case 56:
										return "'Pulsing with dark energy'";
									case 57:
										return "'Pulsing with dark energy'";
									case 64:
										return "Summons a vile thorn";
									case 65:
										return "Causes stars to rain from the sky";
									case 66:
										return "Cleanses the corruption";
									case 67:
										return "Removes the Hallow";
									case 68:
										return "'Looks tasty!'";
									case 70:
										return "Summons the Eater of Worlds";
									}
									break;
								}
							}
							else
							{
								if (l == 75)
								{
									return "Disappears after the sunrise";
								}
								switch (l)
								{
								case 84:
									return "'Get over here!'";
								case 85:
									return "Can be climbed on";
								case 86:
								case 87:
									break;
								case 88:
									return "Provides light when worn";
								default:
									switch (l)
									{
									case 98:
										return "33% chance to not consume ammo";
									case 100:
										return "7% increased melee speed";
									case 101:
										return "7% increased melee speed";
									case 102:
										return "7% increased melee speed";
									case 103:
										return "Able to mine Hellstone";
									case 109:
										return "Permanently increases maximum mana by 20";
									case 111:
										return "Increases maximum mana by 20";
									case 112:
										return "Throws balls of fire";
									case 113:
										return "Casts a controllable missile";
									case 114:
										return "Magically moves dirt";
									case 115:
										return "Creates a magical shadow orb";
									case 117:
										return "'Warm to the touch'";
									case 118:
										return "Sometimes dropped by Skeletons and Piranha";
									case 120:
										return "Lights wooden arrows ablaze";
									case 121:
										return "'It's made out of fire!'";
									case 123:
										return "7% increased magic damage";
									case 124:
										return "7% increased magic damage";
									case 125:
										return "7% increased magic damage";
									case 128:
										return "Allows flight";
									}
									break;
								}
							}
						}
					}
					else
					{
						if (l <= 218)
						{
							if (l <= 190)
							{
								switch (l)
								{
								case 148:
									return "Holding this may attract unwanted attention";
								case 149:
									return "'It contains strange symbols'";
								case 150:
								case 154:
								case 155:
								case 160:
								case 161:
								case 162:
								case 163:
								case 164:
									break;
								case 151:
									return "4% increased ranged damage.";
								case 152:
									return "4% increased ranged damage.";
								case 153:
									return "4% increased ranged damage.";
								case 156:
									return "Grants immunity to knockback";
								case 157:
									return "Sprays out a shower of water";
								case 158:
									return "Negates fall damage";
								case 159:
									return "Increases jump height";
								case 165:
									return "Casts a slow moving bolt of water";
								case 166:
									return "A small explosion that will destroy some tiles";
								case 167:
									return "A large explosion that will destroy most tiles";
								case 168:
									return "A small explosion that will not destroy tiles";
								default:
									if (l == 175)
									{
										return "'Hot to the touch'";
									}
									switch (l)
									{
									case 186:
										return "Increases breath time and allows breathing in water";
									case 187:
										return "Grants the ability to swim";
									case 190:
										return "Has a chance to poison enemies";
									}
									break;
								}
							}
							else
							{
								if (l == 193)
								{
									return "Grants immunity to fire blocks";
								}
								if (l == 197)
								{
									return "Shoots fallen stars";
								}
								switch (l)
								{
								case 208:
									return "'It's pretty, oh so pretty'";
								case 211:
									return "12% increased melee speed";
								case 212:
									return "10% increased movement speed";
								case 213:
									return "Creates grass on dirt";
								case 215:
									return "'May annoy others'";
								case 218:
									return "Summons a controllable ball of fire";
								}
							}
						}
						else
						{
							if (l <= 305)
							{
								switch (l)
								{
								case 222:
									return "Grows plants";
								case 223:
									return "6% reduced mana usage";
								case 224:
								case 225:
								case 226:
								case 227:
									break;
								case 228:
									return "Increases maximum mana by 20";
								case 229:
									return "Increases maximum mana by 20";
								case 230:
									return "Increases maximum mana by 20";
								default:
									switch (l)
									{
									case 235:
										return "'Tossing may be difficult.'";
									case 236:
										break;
									case 237:
										return "'Makes you look cool!'";
									case 238:
										return "15% increased magic damage";
									default:
										switch (l)
										{
										case 261:
											return "'It's smiling, might be a good snack'";
										case 266:
											return "'This is a good idea!'";
										case 267:
											return "'You are a terrible person.'";
										case 268:
											return "Greatly extends underwater breathing";
										case 272:
											return "Casts a demon scythe";
										case 281:
											return "Allows the collection of seeds for ammo";
										case 282:
											return "Works when wet";
										case 283:
											return "For use with Blowpipe";
										case 285:
											return "5% increased movement speed";
										case 288:
											return "Provides immunity to lava";
										case 289:
											return "Provides life regeneration";
										case 290:
											return "25% increased movement speed";
										case 291:
											return "Breathe water instead of air";
										case 292:
											return "Increase defense by 8";
										case 293:
											return "Increased mana regeneration";
										case 294:
											return "20% increased magic damage";
										case 295:
											return "Slows falling speed";
										case 296:
											return "Shows the location of treasure and ore";
										case 297:
											return "Grants invisibility";
										case 298:
											return "Emits an aura of light";
										case 299:
											return "Increases night vision";
										case 300:
											return "Increases enemy spawn rate";
										case 301:
											return "Attackers also take damage";
										case 302:
											return "Allows the ability to walk on water";
										case 303:
											return "20% increased arrow speed and damage";
										case 304:
											return "Shows the location of enemies";
										case 305:
											return "Allows the control of gravity";
										}
										break;
									}
									break;
								}
							}
							else
							{
								if (l == 324)
								{
									return "'Banned in most places'";
								}
								switch (l)
								{
								case 327:
									return "Opens one Gold Chest";
								case 328:
									break;
								case 329:
									return "Opens all Shadow Chests";
								default:
									if (l == 332)
									{
										return "Used for crafting cloth";
									}
									break;
								}
							}
						}
					}
				}
				else
				{
					if (l <= 749)
					{
						if (l <= 669)
						{
							if (l <= 425)
							{
								if (l == 352)
								{
									return "Used for brewing ale";
								}
								switch (l)
								{
								case 357:
									return "Minor improvements to all stats";
								case 358:
								case 359:
								case 360:
								case 362:
								case 364:
								case 365:
								case 366:
								case 368:
								case 369:
								case 370:
								case 374:
								case 375:
								case 379:
								case 380:
								case 381:
								case 382:
								case 383:
								case 384:
								case 387:
								case 388:
								case 390:
								case 391:
								case 392:
								case 406:
									break;
								case 361:
									return "Summons a Goblin Army";
								case 363:
									return "Used for advanced wood crafting";
								case 367:
									return "Strong enough to destroy Demon Altars";
								case 371:
									return "Increases maximum mana by 40";
								case 372:
									return "7% increased movement speed";
								case 373:
									return "10% increased ranged damage";
								case 376:
									return "Increases maximum mana by 60";
								case 377:
									return "5% increased melee critical strike chance";
								case 378:
									return "12% increased ranged damage";
								case 385:
									return "Can mine Mythril and Orichalcum";
								case 386:
									return "Can mine Adamantite and Titanium";
								case 389:
									return "Has a chance to confuse";
								case 393:
									return "Shows horizontal position";
								case 394:
									return "Grants the ability to swim";
								case 395:
									return "Shows position";
								case 396:
									return "Negates fall damage";
								case 397:
									return "Grants immunity to knockback";
								case 398:
									return "Allows the combining of some accessories";
								case 399:
									return "Allows the holder to double jump";
								case 400:
									return "Increases maximum mana by 80";
								case 401:
									return "7% increased melee critical strike chance";
								case 402:
									return "14% increased ranged damage";
								case 403:
									return "6% increased damage";
								case 404:
									return "4% increased critical strike chance";
								case 405:
									return "Allows flight";
								case 407:
									return "Increases block placement range";
								default:
									switch (l)
									{
									case 422:
										return "Spreads the Hallow to some blocks";
									case 423:
										return "Spreads the corruption to some blocks";
									case 425:
										return "Summons a magical fairy";
									}
									break;
								}
							}
							else
							{
								if (l == 434)
								{
									return "Three round burst";
								}
								switch (l)
								{
								case 485:
									return "Turns the holder into a werewolf at night";
								case 486:
									return "Creates a grid on screen for block placement";
								case 487:
								case 488:
								case 494:
								case 498:
								case 499:
								case 500:
								case 501:
								case 502:
								case 503:
								case 504:
								case 505:
								case 507:
								case 508:
								case 511:
								case 512:
								case 513:
								case 514:
								case 530:
								case 537:
								case 538:
								case 539:
								case 540:
								case 545:
								case 546:
								case 550:
								case 562:
								case 563:
								case 564:
								case 565:
								case 566:
								case 567:
								case 568:
								case 569:
								case 570:
								case 571:
								case 572:
								case 573:
								case 574:
								case 577:
								case 578:
								case 586:
								case 587:
								case 588:
								case 589:
								case 590:
								case 591:
								case 592:
								case 593:
								case 594:
								case 595:
								case 596:
								case 597:
								case 598:
									break;
								case 489:
									return "15% increased magic damage";
								case 490:
									return "15% increased melee damage";
								case 491:
									return "15% increased ranged damage";
								case 492:
									return "Allows flight and slow fall";
								case 493:
									return "Allows flight and slow fall";
								case 495:
									return "Casts a controllable rainbow";
								case 496:
									return "Summons a block of ice";
								case 497:
									return "Transforms the holder into merfolk when entering water";
								case 506:
									return "Uses gel for ammo";
								case 509:
									return "Places red wire";
								case 510:
									return "Removes wire";
								case 515:
									return "Creates several crystal shards on impact";
								case 516:
									return "Summons falling stars on impact";
								case 517:
									return "A magical returning dagger";
								case 518:
									return "Summons rapid fire crystal shards";
								case 519:
									return "Summons unholy fire balls";
								case 520:
									return "'The essence of light creatures'";
								case 521:
									return "'The essence of dark creatures'";
								case 522:
									return "'Not even water can put the flame out'";
								case 523:
									return "Can be placed in water";
								case 524:
									return "Used to smelt adamantite and titanium ore";
								case 525:
									return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
								case 526:
									return "'Sharp and magical!'";
								case 527:
									return "'Sometimes carried by creatures in corrupt deserts'";
								case 528:
									return "'Sometimes carried by creatures in light deserts'";
								case 529:
									return "Activates when stepped on";
								case 531:
									return "Can be enchanted";
								case 532:
									return "Causes stars to fall when injured";
								case 533:
									return "50% chance to not consume ammo";
								case 534:
									return "Fires a spread of bullets";
								case 535:
									return "Reduces the cooldown of healing potions";
								case 536:
									return "Increases melee knockback";
								case 541:
									return "Activates when stepped on";
								case 542:
									return "Activates when a player steps on it";
								case 543:
									return "Activates when a player steps on it";
								case 544:
									return "Summons The Twins";
								case 547:
									return "'The essence of pure terror'";
								case 548:
									return "'The essence of the destroyer'";
								case 549:
									return "'The essence of omniscient watchers'";
								case 551:
									return "7% increased critical strike chance";
								case 552:
									return "7% increased damage";
								case 553:
									return "15% increased ranged damage";
								case 554:
									return "Increases length of invincibility after taking damage";
								case 555:
									return "8% reduced mana usage";
								case 556:
									return "Summons Destroyer";
								case 557:
									return "Summons Skeletron Prime";
								case 558:
									return "Increases maximum mana by 100";
								case 559:
									return "10% increased melee damage and critical strike chance";
								case 560:
									return "Summons King Slime";
								case 561:
									return "Stacks up to 5";
								case 575:
									return "'The essence of powerful flying creatures'";
								case 576:
									return "Has a chance to record songs";
								case 579:
									return "'Not to be confused with a picksaw'";
								case 580:
									return "Explodes when activated";
								case 581:
									return "Sends water to outlet pumps";
								case 582:
									return "Receives water from inlet pumps";
								case 583:
									return "Activates every second";
								case 584:
									return "Activates every 3 seconds";
								case 585:
									return "Activates every 5 seconds";
								case 599:
									return "Right click to open";
								case 600:
									return "Right click to open";
								case 601:
									return "Right click to open";
								case 602:
									return "Summons the Frost Legion";
								case 603:
									return "Summons a pet bunny";
								default:
									switch (l)
									{
									case 665:
										return "You shouldn't have this";
									case 666:
										return "You shouldn't have this";
									case 667:
										return "You shouldn't have this";
									case 668:
										return "You shouldn't have this";
									case 669:
										return "Summons a baby penguin";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 709)
							{
								if (l == 676)
								{
									return "Shoots an icy bolt";
								}
								switch (l)
								{
								case 683:
									return "Summons the Devil's trident";
								case 684:
									return "16% increased melee and ranged damage";
								case 685:
									return "11% increased melee and ranged critical strike chance";
								case 686:
									return "8% increased movement speed";
								default:
									switch (l)
									{
									case 707:
										return "Tells the time";
									case 708:
										return "Tells the time";
									case 709:
										return "Tells the time";
									}
									break;
								}
							}
							else
							{
								if (l == 716)
								{
									return "Used to craft items from metal bars";
								}
								switch (l)
								{
								case 723:
									return "Shoots a beam of light";
								case 724:
									return "Shoots an icy bolt";
								case 725:
									return "Shoots frost arrows";
								case 726:
									return "Shoots a stream of frost";
								default:
									switch (l)
									{
									case 748:
										return "Allows flight and slow fall";
									case 749:
										return "Allows flight and slow fall";
									}
									break;
								}
							}
						}
					}
					else
					{
						if (l <= 1006)
						{
							if (l <= 798)
							{
								if (l == 753)
								{
									return "Summons a pet turtle";
								}
								if (l == 761)
								{
									return "Allows flight and slow fall";
								}
								switch (l)
								{
								case 779:
									return "Creates and destroys biomes when sprayed";
								case 780:
									return "Used by the Clentaminator";
								case 781:
									return "Used by the Clentaminator";
								case 782:
									return "Used by the Clentaminator";
								case 783:
									return "Used by the Clentaminator";
								case 784:
									return "Used by the Clentaminator";
								case 785:
									return "Allows flight and slow fall";
								case 786:
									return "Allows flight and slow fall";
								case 787:
									return "Strong enough to destroy Demon Altars";
								case 788:
									return "Summons a thorn spear";
								case 792:
									return "2% increased damage";
								case 793:
									return "2% increased damage";
								case 794:
									return "2% increased damage";
								case 798:
									return "Able to mine Hellstone";
								}
							}
							else
							{
								switch (l)
								{
								case 821:
									return "Allows flight and slow fall";
								case 822:
									return "Allows flight and slow fall";
								case 823:
									return "Allows flight and slow fall";
								default:
									if (l == 832)
									{
										return "Places living wood";
									}
									switch (l)
									{
									case 849:
										return "Enables solid blocks to be toggled on and off";
									case 850:
										return "Places blue wire";
									case 851:
										return "Places green wire";
									case 852:
										return "Activates when a player steps on it";
									case 853:
										return "Activates when anything but a player steps on it";
									case 854:
										return "Shops have lower prices";
									case 855:
										return "Hitting enemies will sometimes drop extra coins";
									case 856:
										return "'Having a wonderful time!'";
									case 857:
										return "Allows the holder to do an improved double jump";
									case 860:
										return "Provides life regeneration and reduces the cooldown of healing potions";
									case 861:
										return "Turns the holder into a werewolf at night and a merfolk when entering water";
									case 862:
										return "Causes stars to fall and increases length of invincibility after taking damage";
									case 863:
										return "Provides the ability to walk on water";
									case 885:
										return "Immunity to Bleeding";
									case 886:
										return "Immunity to Broken Armor";
									case 887:
										return "Immunity to Poison";
									case 888:
										return "Immunity to Darkness";
									case 889:
										return "Immunity to Slow";
									case 890:
										return "Immunity to Silence";
									case 891:
										return "Immunity to Curse";
									case 892:
										return "Immunity to Weakness";
									case 893:
										return "Immunity to Confusion";
									case 897:
										return "Increases melee knockback";
									case 898:
										return "Allows flight";
									case 899:
										return "Increases all stats if worn during the day";
									case 900:
										return "Increases all stats if worn during the night";
									case 901:
										return "Immunity to Weakness and Broken Armor";
									case 902:
										return "Immunity to Poison and Bleeding";
									case 903:
										return "Immunity to Slow and Confusion";
									case 904:
										return "Immunity to Silence and Curse";
									case 905:
										return "Uses coins for ammo";
									case 906:
										return "Provides 7 seconds of immunity to lava";
									case 907:
										return "Provides the ability to walk on water";
									case 908:
										return "Provides the ability to walk on water and lava";
									case 932:
										return "Places bone";
									case 933:
										return "Places leaves";
									case 934:
										return "Allows the owner to float for a few seconds";
									case 935:
										return "12% increased damage";
									case 936:
										return "Increases melee knockback";
									case 937:
										return "Explodes when stepped on";
									case 938:
										return "Absorbs 25% of damage done to players on your team";
									case 946:
										return "You will fall slower while holding this";
									case 947:
										return "Reacts to the light";
									case 948:
										return "Allows flight and slowfall";
									case 950:
										return "Provides extra mobility on ice";
									case 951:
										return "Rapidly launches snowballs";
									case 953:
										return "Allows the ability to slide down walls";
									case 956:
										return "7% increased melee speed";
									case 957:
										return "7% increased melee speed";
									case 958:
										return "7% increased melee speed";
									case 959:
										return "4% increased ranged damage.";
									case 960:
										return "Increases maximum mana by 20";
									case 961:
										return "Increases maximum mana by 20";
									case 962:
										return "Increases maximum mana by 20";
									case 963:
										return "Gives a chance to dodge attacks";
									case 964:
										return "Fires a spread of bullets";
									case 965:
										return "Can be climbed on";
									case 966:
										return "Life regen is increased when near a campfire";
									case 967:
										return "Put it on a stick and roast over a campfire";
									case 968:
										return "Roast it over a campfire!";
									case 969:
										return "Minor improvements to all stats";
									case 975:
										return "Allows the ability to slide down walls";
									case 976:
										return "Allows the ability to climb walls";
									case 977:
										return "Allows the ability to dash";
									case 982:
										return "Increases maximum mana by 20";
									case 983:
										return "Allows the holder to double jump";
									case 984:
										return "Allows the ability to climb walls and dash";
									case 985:
										return "Throw to create a climbable line of rope";
									case 986:
										return "Allows the collection of seeds for ammo";
									case 987:
										return "Allows the holder to double jump";
									case 989:
										return "Shoots an enchanted sword beam";
									case 990:
										return "'Not to be confused with a hamdrill'";
									case 994:
										return "Summons a Baby Eater of Souls";
									case 995:
										return "Used to craft objects";
									case 996:
										return "Used to craft objects";
									case 997:
										return "Turns silt/slush into something more useful";
									case 998:
										return "Used to craft objects";
									case 1000:
										return "Shoots confetti everywhere!";
									case 1001:
										return "16% increased melee damage";
									case 1002:
										return "16% increased ranged damage";
									case 1003:
										return "Increases maximum mana by 80 and reduces mana usage by 17%";
									case 1004:
										return "5% increased damage";
									case 1005:
										return "8% increased critical strike chance";
									case 1006:
										return "Reacts to the light";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 1432)
							{
								switch (l)
								{
								case 1071:
									return "Used with paint to color blocks";
								case 1072:
									return "Used with paint to color walls";
								default:
									switch (l)
									{
									case 1100:
										return "Used to remove paint";
									case 1101:
									case 1102:
									case 1103:
									case 1104:
									case 1105:
									case 1106:
									case 1124:
									case 1125:
									case 1126:
									case 1127:
									case 1128:
									case 1134:
									case 1135:
									case 1136:
									case 1137:
									case 1138:
									case 1139:
									case 1140:
									case 1142:
									case 1143:
									case 1144:
									case 1146:
									case 1147:
									case 1148:
									case 1149:
									case 1150:
									case 1152:
									case 1153:
									case 1154:
									case 1155:
									case 1166:
									case 1168:
									case 1173:
									case 1174:
									case 1175:
									case 1176:
									case 1177:
									case 1184:
									case 1185:
									case 1186:
									case 1187:
									case 1190:
									case 1191:
									case 1192:
									case 1193:
									case 1194:
									case 1197:
									case 1198:
									case 1199:
									case 1200:
									case 1201:
									case 1202:
									case 1203:
									case 1204:
									case 1222:
									case 1223:
									case 1224:
									case 1225:
									case 1229:
									case 1230:
									case 1231:
									case 1232:
									case 1233:
									case 1234:
									case 1236:
									case 1237:
									case 1238:
									case 1239:
									case 1240:
									case 1241:
									case 1243:
									case 1245:
									case 1246:
									case 1257:
									case 1262:
									case 1263:
									case 1266:
									case 1267:
									case 1268:
									case 1269:
									case 1270:
									case 1271:
									case 1272:
									case 1273:
									case 1274:
									case 1275:
									case 1276:
									case 1277:
									case 1278:
									case 1279:
									case 1280:
									case 1281:
									case 1288:
									case 1289:
									case 1292:
									case 1298:
									case 1302:
									case 1304:
									case 1305:
									case 1319:
									case 1320:
									case 1324:
									case 1325:
									case 1328:
									case 1329:
									case 1330:
									case 1337:
									case 1338:
									case 1339:
									case 1340:
									case 1341:
									case 1342:
										break;
									case 1107:
										return "Used to make Teal Dye";
									case 1108:
										return "Used to make Green Dye";
									case 1109:
										return "Used to make Sky Blue Dye";
									case 1110:
										return "Used to make Yellow Dye";
									case 1111:
										return "Used to make Blue Dye";
									case 1112:
										return "Used to make Lime Dye";
									case 1113:
										return "Used to make Pink Dye";
									case 1114:
										return "Used to make Orange Dye";
									case 1115:
										return "Used to make Red Dye";
									case 1116:
										return "Used to make Cyan Dye";
									case 1117:
										return "Used to make Violet Dye";
									case 1118:
										return "Used to make Purple Dye";
									case 1119:
										return "Used to make Black Dye";
									case 1120:
										return "Used to Craft Dyes";
									case 1121:
										return "Shoots bees that will chase your enemy";
									case 1122:
										return "Chases after your enemy";
									case 1123:
										return "Summons killer bees after striking your foe";
									case 1129:
										return "Places Hives";
									case 1130:
										return "Explodes into a swarm of bees";
									case 1131:
										return "Allows the holder to reverse gravity";
									case 1132:
										return "Releases bees when damaged";
									case 1133:
										return "Summons the Queen Bee";
									case 1141:
										return "Opens the jungle temple door";
									case 1145:
										return "Used for basic crafting";
									case 1151:
										return "Activates when a player steps on it";
									case 1156:
										return "Latches on to enemies for continuous damage";
									case 1157:
										return "Summons a Pygmy to fight for you";
									case 1158:
										return "Increases your max number of minions";
									case 1159:
										return "Increases your max number of minions";
									case 1160:
										return "Increases your max number of minions";
									case 1161:
										return "Increases your max number of minions";
									case 1162:
										return "Allows flight and slow fall";
									case 1163:
										return "Allows the holder to double jump";
									case 1164:
										return "Allows the holder to quadruple jump";
									case 1165:
										return "Allows flight and slow fall";
									case 1167:
										return "Increases the damage of your minions by 15";
									case 1169:
										return "Summons a Baby Skeletron Head";
									case 1170:
										return "Summons a Baby Hornet";
									case 1171:
										return "Summons a Tiki Spirit";
									case 1172:
										return "Summons a Pet Lizard";
									case 1178:
										return "Rapidly shoots razor sharp leaves";
									case 1179:
										return "Chases after your enemy";
									case 1180:
										return "Summons a Pet Parrot";
									case 1181:
										return "Summons a Baby Truffle";
									case 1182:
										return "Summons a Pet Sapling";
									case 1183:
										return "Summons a Wisp to provide light";
									case 1188:
										return "Can mine Mythril, Orichalcum, Adamantite, and Titanium";
									case 1189:
										return "Can mine Mythril, Orichalcum, Adamantite, and Titanium";
									case 1195:
										return "Can mine Adamantite and Titanium";
									case 1196:
										return "Can mine Adamantite and Titanium";
									case 1205:
										return "8% increased melee damage";
									case 1206:
										return "9% increased ranged damage";
									case 1207:
										return "7% increased magic damage and critical strike chance";
									case 1208:
										return "3% increased damage";
									case 1209:
										return "2% increased damage";
									case 1210:
										return "7% increased melee damage";
									case 1211:
										return "15% increased ranged critical strike chance";
									case 1212:
										return "18% increased magic critical strike chance";
									case 1213:
										return "6% increased critical strike chance";
									case 1214:
										return "11% increased movement speed";
									case 1215:
										return "8% increased melee damage and critical strike chance";
									case 1216:
										return "16% increased ranged damage";
									case 1217:
										return "16% increased magic damage and 7% increased magic critical strike chance";
									case 1218:
										return "4% increased damage";
									case 1219:
										return "3% increased damage and critical strike chance";
									case 1220:
										return "Used to craft items from mythril, orichalcum, adamantite, and titanium bars";
									case 1221:
										return "Used to smelt adamantite and titanium ore";
									case 1226:
										return "Shoots a powerful orb";
									case 1227:
										return "Shoots a spore cloud";
									case 1228:
										return "Shoots a spore cloud";
									case 1235:
										return "Bounces back after hitting a wall";
									case 1242:
										return "Summons a Baby Dinosaur";
									case 1244:
										return "Summons a cloud to rain down on your foes";
									case 1247:
										return "Causes stars to fall and releases bees when injured";
									case 1248:
										return "10% increased critical strike chance";
									case 1249:
										return "Increases jump height";
									case 1250:
										return "Allows the holder to double jump";
									case 1251:
										return "Allows the holder to double jump";
									case 1252:
										return "Allows the holder to double jump";
									case 1253:
										return "Puts a shell around the owner when below 25% life that reduces damage";
									case 1254:
										return "Shoots a powerful, high velocity bullet";
									case 1255:
										return "Shoots a powerful, high velocity bullet";
									case 1256:
										return "Summons a cloud to rain blood on your foes";
									case 1258:
										return "Shoots an explosive bolt";
									case 1259:
										return "Shoots razor sharp flower petals at nearby enemies";
									case 1260:
										return "Shoots a rainbow that does continuous damage";
									case 1261:
										return "Explodes into deadly shrapnel";
									case 1264:
										return "Shoots a ball of frost";
									case 1265:
										return "Shoots a powerful, high velocity bullet";
									case 1282:
										return "Increases maximum mana by 20";
									case 1283:
										return "Increases maximum mana by 40";
									case 1284:
										return "Increases maximum mana by 40";
									case 1285:
										return "Increases maximum mana by 60";
									case 1286:
										return "Increases maximum mana by 60";
									case 1287:
										return "Increases maximum mana by 80";
									case 1290:
										return "Increases movement speed after being struck";
									case 1291:
										return "Permanently increases maximum life by 5";
									case 1293:
										return "Used at the Lihzahrd Altar";
									case 1294:
										return "Capable of mining Lihzahrd Bricks";
									case 1295:
										return "Shoots a piercing ray of heat";
									case 1296:
										return "Summons a powerful boulder";
									case 1297:
										return "Punches with the force of a golem";
									case 1299:
										return "Increases view range when held";
									case 1300:
										return "Increases view range for guns";
									case 1301:
										return "10% increased damage";
									case 1303:
										return "Provides light under water";
									case 1306:
										return "Shoots an icy sickle";
									case 1307:
										return "'You are a terrible person'";
									case 1308:
										return "Shoots a poison fang that pierces multiple enemies";
									case 1309:
										return "Summons a baby slime to fight for you";
									case 1310:
										return "Inflicts poison on enemies";
									case 1311:
										return "Summons an eyeball spring";
									case 1312:
										return "Summons a baby snowman";
									case 1313:
										return "Shoots a skull";
									case 1314:
										return "Shoots a boxing glove";
									case 1315:
										return "Summons a pirate invasion";
									case 1316:
										return "6% increased melee damage";
									case 1317:
										return "8% increased melee damage and critical strike chance";
									case 1318:
										return "4% increased melee critical strike chance";
									case 1321:
										return "Increase arrow speed and damage by 10%";
									case 1322:
										return "Inflicts fire damage on attack";
									case 1323:
										return "Reduces damage from touching lava";
									case 1326:
										return "Teleports to the position of the mouse";
									case 1327:
										return "Shoots a deathly sickle";
									case 1331:
										return "Summons the Brain of Cthulhu";
									case 1332:
										return "'The blood of gods'";
									case 1333:
										return "Can be placed in water";
									case 1334:
										return "Decreases target's defense";
									case 1335:
										return "Decreases target's defense";
									case 1336:
										return "Sprays a shower of ichor";
									case 1343:
										return "Increases melee knockback and inflicts fire damage on attack";
									default:
										switch (l)
										{
										case 1430:
											return "Used to craft weapon imbuement flasks";
										case 1432:
											return "Used to craft various types of ammo";
										}
										break;
									}
									break;
								}
							}
							else
							{
								switch (l)
								{
								case 1444:
									return "Creates a shadow beam that bounces off walls";
								case 1445:
									return "Launches a ball of fire that explodes into a raging inferno";
								case 1446:
									return "Summons a lost soul to chase your foes";
								case 1447:
								case 1448:
									break;
								case 1449:
									return "Blows bubbles";
								case 1450:
									return "Blows bubbles";
								default:
									switch (l)
									{
									case 1503:
										return "Increases maximum mana by 80 and reduces mana usage by 17%";
									case 1504:
										return "7% increased magic damage and critical strike chance";
									case 1505:
										return "8% increased magic damage";
									case 1506:
									case 1507:
									case 1508:
									case 1509:
									case 1510:
									case 1511:
									case 1512:
									case 1514:
									case 1516:
									case 1517:
									case 1518:
									case 1519:
									case 1520:
									case 1521:
									case 1528:
									case 1529:
									case 1530:
									case 1531:
									case 1532:
									case 1538:
									case 1539:
									case 1540:
									case 1541:
									case 1542:
									case 1552:
									case 1570:
									case 1573:
									case 1574:
									case 1575:
									case 1576:
									case 1577:
									case 1589:
									case 1590:
									case 1591:
									case 1592:
									case 1593:
									case 1594:
									case 1596:
									case 1597:
									case 1598:
									case 1599:
									case 1600:
									case 1601:
									case 1602:
									case 1603:
									case 1604:
									case 1605:
									case 1606:
									case 1607:
									case 1608:
									case 1609:
									case 1610:
									case 1611:
										break;
									case 1513:
										return "A powerful returning hammer";
									case 1515:
										return "Allows flight and slow fall";
									case 1522:
										return "For Capture the Gem. It drops when you die";
									case 1523:
										return "For Capture the Gem. It drops when you die";
									case 1524:
										return "For Capture the Gem. It drops when you die";
									case 1525:
										return "For Capture the Gem. It drops when you die";
									case 1526:
										return "For Capture the Gem. It drops when you die";
									case 1527:
										return "For Capture the Gem. It drops when you die";
									case 1533:
										return "Unlocks a Jungle Chest in the dungeon";
									case 1534:
										return "Unlocks a Corruption Chest in the dungeon";
									case 1535:
										return "Unlocks a Crimson Chest in the dungeon";
									case 1536:
										return "Unlocks a Hallowed Chest in the dungeon";
									case 1537:
										return "Unlocks a Frozen Chest in the dungeon";
									case 1543:
										return "Used with paint to color blocks";
									case 1544:
										return "Used with paint to color walls";
									case 1545:
										return "Used to remove paint";
									case 1546:
										return "15% increased arrow damage";
									case 1547:
										return "15% increased bullet damage";
									case 1548:
										return "15% increased rocket damage";
									case 1549:
										return "13% increased ranged critical strike chance";
									case 1550:
										return "7% increased ranged critical strike chance";
									case 1551:
										return "Converts Chlorophyte Bars into Shroomite Bars";
									case 1553:
										return "50% chance to not consume ammo";
									case 1554:
										return "You shouldn't have this";
									case 1555:
										return "You shouldn't have this";
									case 1556:
										return "You shouldn't have this";
									case 1557:
										return "You shouldn't have this";
									case 1558:
										return "You shouldn't have this";
									case 1559:
										return "You shouldn't have this";
									case 1560:
										return "You shouldn't have this";
									case 1561:
										return "You shouldn't have this";
									case 1562:
										return "You shouldn't have this";
									case 1563:
										return "You shouldn't have this";
									case 1564:
										return "You shouldn't have this";
									case 1565:
										return "You shouldn't have this";
									case 1566:
										return "You shouldn't have this";
									case 1567:
										return "You shouldn't have this";
									case 1568:
										return "You shouldn't have this";
									case 1569:
										return "Rapidly throw life stealing daggers";
									case 1571:
										return "A powerful javalin that unleashes tiny eaters";
									case 1572:
										return "Summons a powerful frost hydra to spit ice at your enemies";
									case 1578:
										return "Releases bees and increases movement speed when damaged";
									case 1579:
										return "The wearer can run super fast";
									case 1580:
										return "You shouldn't have this";
									case 1581:
										return "You shouldn't have this";
									case 1582:
										return "You shouldn't have this";
									case 1583:
										return "You shouldn't have this";
									case 1584:
										return "You shouldn't have this";
									case 1585:
										return "You shouldn't have this";
									case 1586:
										return "You shouldn't have this";
									case 1587:
										return "You shouldn't have this";
									case 1588:
										return "You shouldn't have this";
									case 1595:
										return "Increases maximum mana by 20";
									case 1612:
										return "Grants immunity to most debuffs";
									case 1613:
										return "Grants immunity to knockback and fire blocks";
									default:
										if (l == 1724)
										{
											return "Allows the holder to double jump";
										}
										break;
									}
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					if (l <= 332)
					{
						if (l <= 128)
						{
							if (l <= 36)
							{
								if (l <= 8)
								{
									if (l == -1)
									{
										return "Kann Meteorite abbauen";
									}
									if (l == 8)
									{
										return "Verstroemt Licht";
									}
								}
								else
								{
									switch (l)
									{
									case 15:
										return "Zeigt die Zeit an";
									case 16:
										return "Zeigt die Zeit an";
									case 17:
										return "Zeigt die Zeit an";
									case 18:
										return "Zeigt die Tiefe an";
									case 19:
									case 20:
									case 21:
									case 22:
										break;
									case 23:
										return "'Lecker und brennbar'";
									default:
										if (l == 29)
										{
											return "Erhoeht dauerhaft die maximale Lebensspanne um 20";
										}
										switch (l)
										{
										case 33:
											return "Wird fuer die Verhuettung von Erz verwendet";
										case 35:
											return "Wird verwendet, um Items aus Metallbarren herzustellen";
										case 36:
											return "Wird zur einfachen Herstellung verwendet";
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 75)
								{
									if (l == 43)
									{
										return "Ruft das Auge von Cthulhu herbei";
									}
									switch (l)
									{
									case 49:
										return "Belebt langsam wieder";
									case 50:
										return "Ein Blick in den Spiegel bringt einen nach Hause zurueck";
									case 51:
									case 52:
									case 55:
									case 58:
									case 59:
									case 60:
									case 61:
									case 62:
									case 63:
									case 69:
										break;
									case 53:
										return "Berechtigt den Inhaber zum Doppelsprung";
									case 54:
										return "Der Traeger kann superschnell rennen";
									case 56:
										return "'Durchpulst von dunkler Energie'";
									case 57:
										return "'Durchpulst von dunkler Energie'";
									case 64:
										return "Ruft einen Ekeldorn herbei";
									case 65:
										return "Laesst Sterne vom Himmel regen";
									case 66:
										return "Reinigt das Verderben";
									case 67:
										return "Entfernt den Segen";
									case 68:
										return "'Sieht lecker aus!'";
									case 70:
										return "Ruft den Weltenfresser herbei";
									default:
										if (l == 75)
										{
											return "Verschwindet nach Sonnenaufgang";
										}
										break;
									}
								}
								else
								{
									if (l == 84)
									{
										return "'Komm hier rueber!'";
									}
									if (l == 88)
									{
										return "Verstroemt beim Tragen Licht";
									}
									switch (l)
									{
									case 98:
										return "33%ige Chance, Munition nicht zu verbrauchen";
									case 100:
										return "Um 7% erhoehtes Nahkampftempo";
									case 101:
										return "Um 7% erhoehtes Nahkampftempo";
									case 102:
										return "Um 7% erhoehtes Nahkampftempo";
									case 103:
										return "Kann Hoellenstein abbauen";
									case 109:
										return "Erhoeht maximales Mana um 20";
									case 111:
										return "Erhoeht die maximale Mana um 20";
									case 112:
										return "Schiesst Feuerbaelle ab";
									case 113:
										return "Wirft eine steuerbare Rakete aus";
									case 114:
										return "Bewegt magisch Dreck";
									case 115:
										return "Erschafft eine magische Lichtkugel";
									case 117:
										return "'Fuehlt sich warm an'";
									case 118:
										return "Faellt mitunter von Skeletten und Piranhas herab";
									case 120:
										return "Entfacht lodernde Holzpfeile";
									case 121:
										return "'Ist ganz aus Feuer!'";
									case 123:
										return "Um 5% erhoehter magischer Schaden";
									case 124:
										return "Um 5% erhoehter magischer Schaden";
									case 125:
										return "Um 5% erhoehter magischer Schaden";
									case 128:
										return "Laesst fliegen";
									}
								}
							}
						}
						else
						{
							if (l <= 218)
							{
								if (l <= 187)
								{
									switch (l)
									{
									case 148:
										return "Kann unerwuenschte Aufmerksamkeit erwecken";
									case 149:
										return "'Es enthaelt seltsame Symbole'";
									case 150:
									case 154:
									case 155:
									case 160:
									case 161:
									case 162:
									case 163:
									case 164:
										break;
									case 151:
										return "Um 4% erhoehter Fernkampf-Schaden";
									case 152:
										return "Um 4% erhoehter Fernkampf-Schaden";
									case 153:
										return "Um 4% erhoehter Fernkampf-Schaden";
									case 156:
										return "Macht immun gegen Rueckstoss";
									case 157:
										return "Versprueht eine Wasserdusche";
									case 158:
										return "Hebt Sturzschaden auf";
									case 159:
										return "Vergroessert die Sprunghoehe";
									case 165:
										return "Wirft einen sich langsam bewegenden Wasserbolzen aus";
									case 166:
										return "Eine kleine Explosion, die einige Felder zerstoeren wird";
									case 167:
										return "Eine grosse Explosion, die die meisten Felder zerstoert";
									case 168:
										return "Eine kleine Explosion, die keine Felder zerstoert";
									default:
										if (l == 175)
										{
											return "'Heiss, heiss, heiss!'";
										}
										switch (l)
										{
										case 186:
											return "'Ganz nett, nicht ertrinken zu muessen'";
										case 187:
											return "Befaehigt zum Schwimmen";
										}
										break;
									}
								}
								else
								{
									if (l == 193)
									{
										return "Macht immun gegen Feuer-Bloecke";
									}
									if (l == 197)
									{
										return "Schiesst Sternschnuppen herunter";
									}
									switch (l)
									{
									case 208:
										return "'Oh, ist die huebsch!'";
									case 211:
										return "Um 12% erhoehtes Nahkampftempo";
									case 212:
										return "Um 10% erhoehtes Bewegungstempo";
									case 213:
										return "Laesst Gras auf Schmutz wachsen";
									case 215:
										return "'Kann Aerger erregen'";
									case 218:
										return "Ruft einen steuerbaren Feuerball herbei";
									}
								}
							}
							else
							{
								if (l <= 305)
								{
									switch (l)
									{
									case 222:
										return "Laesst Pflanzen wachsen";
									case 223:
										return "Um 6% reduzierte Mana-Nutzung";
									case 224:
									case 225:
									case 226:
									case 227:
										break;
									case 228:
										return "Erhoeht die maximale Mana um 20";
									case 229:
										return "Erhoeht die maximale Mana um 20";
									case 230:
										return "Erhoeht die maximale Mana um 20";
									default:
										switch (l)
										{
										case 235:
											return "'Werfen koennte schwierig werden.'";
										case 236:
											break;
										case 237:
											return "'Damit siehst du cool aus!'";
										case 238:
											return "Um 15% erhoehter magischer Schaden";
										default:
											switch (l)
											{
											case 261:
												return "'Er laechelt - vielleicht schmeckt er auch gut...'";
											case 266:
												return "'Das ist eine gute Idee!'";
											case 267:
												return "'Du bist ein schrecklicher Mensch.'";
											case 268:
												return "Verlaengert das Atmen unter Wasser deutlich";
											case 272:
												return "Wirft eine Daemonensense aus";
											case 281:
												return "Zum Erstellen einer Saatsammlung als Munition";
											case 282:
												return "Funktioniert bei Naesse";
											case 283:
												return "Zur Verwendung im Blasrohr";
											case 285:
												return "Um 5% erhoehtes Bewegungstempo";
											case 288:
												return "Macht immun gegen Lava";
											case 289:
												return "Belebt wieder";
											case 290:
												return "Erhoeht Bewegungstempo um 25%";
											case 291:
												return "Wasser statt Luft atmen";
											case 292:
												return "Erhoeht die Abwehr um 8";
											case 293:
												return "Erhoehte Mana-Wiederherstellung";
											case 294:
												return "Erhoeht magischen Schaden um 20%";
											case 295:
												return "Verlangsamt das Sturztempo";
											case 296:
												return "Zeigt den Fundort von Schatz und Erz";
											case 297:
												return "Macht unsichtbar";
											case 298:
												return "Verstroemt eine Aura aus Licht";
											case 299:
												return "Erhoeht die Nachtsicht";
											case 300:
												return "Erhoeht Feind-Spawnquote";
											case 301:
												return "Auch die Angreifer erleiden Schaden";
											case 302:
												return "Befaehigt, auf dem Wasser zu gehen";
											case 303:
												return "Erhoeht Pfeiltempo und Schaden um 20%";
											case 304:
												return "Zeigt die Position von Feinden";
											case 305:
												return "Zur Steuerung der Schwerkraft";
											}
											break;
										}
										break;
									}
								}
								else
								{
									if (l == 324)
									{
										return "'An den meisten Orten verboten'";
									}
									switch (l)
									{
									case 327:
										return "Oeffnet eine Goldtruhe";
									case 328:
										break;
									case 329:
										return "Oeffnet alle Schattentruhen";
									default:
										if (l == 332)
										{
											return "Verwendet fuer die Tuchherstellung ";
										}
										break;
									}
								}
							}
						}
					}
					else
					{
						if (l <= 726)
						{
							if (l <= 603)
							{
								if (l <= 407)
								{
									if (l == 352)
									{
										return "Zum Bierbrauen";
									}
									switch (l)
									{
									case 357:
										return "Geringe Anhebung aller Werte";
									case 361:
										return "Ruft eine Goblin-Armee herbei";
									case 363:
										return "Fuer fortgeschrittene Holzherstellung";
									case 367:
										return "Stark genug, um Daemonenaltaere zu zerstoeren";
									case 371:
										return "Erhoeht die maximale Mana um 40";
									case 372:
										return "Um 7% erhoehtes Bewegungstempo";
									case 373:
										return "Um 10% erhoehter Fernkampfschaden";
									case 376:
										return "Erhoeht die maximale Mana um 60";
									case 377:
										return "Um 5% erhoehte kritische Nahkampf-Trefferchance";
									case 378:
										return "Um 12% erhoehter Fernkampf-Schaden";
									case 385:
										return "Kann Mithril abbauen";
									case 386:
										return "Kann Adamantit abbauen";
									case 389:
										return "Kann Verwirrung stiften";
									case 393:
										return "Zeigt horizontale Position";
									case 394:
										return "Befaehigt zum Schwimmen";
									case 395:
										return "Zeigt Position an";
									case 396:
										return "Hebt Sturzschaden auf";
									case 397:
										return "Macht immun gegen Rueckstoss";
									case 398:
										return "Ermoeglicht die Kombination von Zubehoer";
									case 399:
										return "Berechtigt den Inhaber zum Doppelsprung";
									case 400:
										return "Erhoeht die maximale Mana um 80";
									case 401:
										return "Um 7% erhoehte kritische Nahkampf-Trefferchance";
									case 402:
										return "Um 14% erhoehter Fernkampfschaden";
									case 403:
										return "Um 6% erhoehter Schaden";
									case 404:
										return "Um 4% erhoehte kritische Trefferchance";
									case 405:
										return "Laesst fliegen";
									case 407:
										return "Erweitert den Platzierbereich von Bloecken";
									}
								}
								else
								{
									switch (l)
									{
									case 422:
										return "Verspritzt Segen auf einige Bloecke";
									case 423:
										return "Verteilt Verderben auf einige Bloecke";
									case 424:
										break;
									case 425:
										return "Ruft eine magische Fee herbei";
									default:
										if (l == 434)
										{
											return "Dreifachschuss";
										}
										switch (l)
										{
										case 485:
											return "Verwandelt den Inhaber bei Vollmond in einen Werwolf";
										case 486:
											return "Erstellt ein Raster auf dem Bildschirm zum Platzieren der Bloecke";
										case 489:
											return "Um 15% erhoehter magischer Schaden";
										case 490:
											return "Um 15% erhoehter Nahkampfschaden";
										case 491:
											return "Um 15% erhoehter Fernkampfschaden";
										case 492:
											return "Ermoeglicht Flug und langsamen Fall";
										case 493:
											return "Ermoeglicht Flug und langsamen Fall";
										case 495:
											return "Wirft einen steuerbaren Regenbogen aus";
										case 496:
											return "Ruft einen Eisblock herbei";
										case 497:
											return "Verwandelt den Besitzer beim Hineingehen ins Wasser in Meermenschen";
										case 506:
											return "Verwendet Glibber als Munition";
										case 509:
											return "Platziert Kabel";
										case 510:
											return "Entfernt Kabel";
										case 515:
											return "Erzeugt beim Aufprall mehrere Kristallscherben";
										case 516:
											return "Ruft beim Aufprall Sternschnuppen herbei";
										case 517:
											return "Ein Dolch, der magisch zurueckkehrt";
										case 518:
											return "Ruft schnelle Feuerkristallscherben herbei";
										case 519:
											return "Ruft unheilige Feuerbaelle herbei";
										case 520:
											return "'Die Essenz von Lichtkreaturen'";
										case 521:
											return "'Die Essenz von Finsterkreaturen'";
										case 522:
											return "'Nicht einmal Wasser loescht diese Flamme'";
										case 523:
											return "Kann in Wasser platziert werden";
										case 524:
											return "Zum Schmelzen von Adamantiterz";
										case 525:
											return "Zur Herstellung von Items aus Mithril- und Adamantitbarren";
										case 526:
											return "'Scharf und magisch!'";
										case 527:
											return "'Kreaturen in verderbten Wuesten tragen sie mitunter'";
										case 528:
											return "'Werden mitunter von Kreaturen in Lichtwuesten getragen'";
										case 529:
											return "Wird beim Betreten aktiviert";
										case 531:
											return "Zum Zaubern";
										case 532:
											return "Laesst Sterne bei Verletzung herabfallen";
										case 533:
											return "50%ige Chance, Munition nicht zu verbrauchen";
										case 534:
											return "Feuert einen Kugelregen ab";
										case 535:
											return "Verringert die Abklingzeit von Heiltraenken";
										case 536:
											return "Erhoeht Nahkampf-Rueckstoss";
										case 541:
											return "Wird beim Betreten aktiviert";
										case 542:
											return "Wird beim Betreten aktiviert";
										case 543:
											return "Wird beim Betreten aktiviert";
										case 544:
											return "Ruft die Zwillinge herbei";
										case 547:
											return "'Die Essenz reinen Schreckens'";
										case 548:
											return "'Die Essenz des Zerstoerers'";
										case 549:
											return "'Die Essenz der allwissenden Beobachter'";
										case 551:
											return "Um 7% erhoehte kritische Trefferchance";
										case 552:
											return "Um 7% erhoehter Schaden";
										case 553:
											return "Um 15% erhoehter Fernkampfschaden";
										case 554:
											return "Verlaengert die Unbesiegbarkeit nach erlittenem Schaden";
										case 555:
											return "Um 8% reduzierte Mananutzung";
										case 556:
											return "Ruft den Zerstoerer";
										case 557:
											return "Ruft Super-Skeletron herbei";
										case 558:
											return "Erhoeht die maximale Mana um 100";
										case 559:
											return "Nahkampfschaden und kritische Trefferchance um 10% erhoeht";
										case 560:
											return "Ruft Schleimi-Koenig herbei";
										case 561:
											return "Kann bis zu 5 stapeln";
										case 575:
											return "'Essenz maechtiger fliegender Kreaturen'";
										case 576:
											return "Kann Songs aufzeichnen";
										case 579:
											return "'Nicht mit einer Hamsaege zu verwechseln'";
										case 580:
											return "Explodiert bei Aktivierung";
										case 581:
											return "Sendet Wasser zu Auslasspumpen";
										case 582:
											return "Empfaengt Wasser vom Einlasspumpen";
										case 583:
											return "Aktiviert jede Sekunde";
										case 584:
											return "Aktiviert alle 3 Sekunden";
										case 585:
											return "Aktiviert alle 5 Sekunden";
										case 599:
											return "Rechter Mausklick zu öffnen";
										case 600:
											return "Rechter Mausklick zu öffnen";
										case 601:
											return "Rechter Mausklick zu öffnen";
										case 602:
											return "Beschwört den Frost Legion";
										case 603:
											return "Vorladung ein Haustier Hase";
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 686)
								{
									switch (l)
									{
									case 665:
										return "Sie sollten nicht diese";
									case 666:
										return "Sie sollten nicht diese";
									case 667:
										return "Sie sollten nicht diese";
									case 668:
										return "Sie sollten nicht diese";
									case 669:
										return "Beschwört einen Baby-Pinguin";
									default:
										if (l == 676)
										{
											return "Schießt ein eisiger Bolzen";
										}
										switch (l)
										{
										case 683:
											return "Summons des Teufels Dreizack";
										case 684:
											return "16% erhöht Nahkampf-und Fernkampf Schaden";
										case 685:
											return "11% erhöht Nahkampf-und Fernkampf kritische Trefferchance";
										case 686:
											return "8% erhöht Bewegungsgeschwindigkeit";
										}
										break;
									}
								}
								else
								{
									switch (l)
									{
									case 707:
										return "Teilt die Zeit";
									case 708:
										return "Teilt die Zeit";
									case 709:
										return "Teilt die Zeit";
									default:
										if (l == 716)
										{
											return "Wird verwendet, um kunstgewerbliche Gegenstände aus Metall Bars";
										}
										switch (l)
										{
										case 723:
											return "Schießt einen Lichtstrahl";
										case 724:
											return "Schießt ein eisiger Bolzen";
										case 725:
											return "Shoots frost Pfeile";
										case 726:
											return "Schießt einen Strom von frost";
										}
										break;
									}
								}
							}
						}
						else
						{
							if (l <= 832)
							{
								if (l <= 761)
								{
									switch (l)
									{
									case 748:
										return "Ermöglicht Flug und langsam fallen";
									case 749:
										return "Ermöglicht Flug und langsam fallen";
									default:
										if (l == 753)
										{
											return "Beschwört ein Haustier Schildkröte";
										}
										if (l == 761)
										{
											return "Ermöglicht Flug und langsam fallen";
										}
										break;
									}
								}
								else
								{
									switch (l)
									{
									case 779:
										return "Erstellt und zerstört Biome beim Sprühen";
									case 780:
										return "Wird von der Clentaminator";
									case 781:
										return "Wird von der Clentaminator";
									case 782:
										return "Wird von der Clentaminator";
									case 783:
										return "Wird von der Clentaminator";
									case 784:
										return "Wird von der Clentaminator";
									case 785:
										return "Ermöglicht Flug und langsam fallen";
									case 786:
										return "Ermöglicht Flug und langsam fallen";
									case 787:
										return "Stark genug, um Dämonen Altare zerstören";
									case 788:
										return "Summons ein Dorn Speer";
									case 789:
									case 790:
									case 791:
									case 795:
									case 796:
									case 797:
										break;
									case 792:
										return "2% mehr Schaden";
									case 793:
										return "2% mehr Schaden";
									case 794:
										return "2% mehr Schaden";
									case 798:
										return "Kann Hellstone abbauen";
									default:
										switch (l)
										{
										case 821:
											return "Ermöglicht Flug und langsam fallen";
										case 822:
											return "Ermöglicht Flug und langsam fallen";
										case 823:
											return "Ermöglicht Flug und langsam fallen";
										default:
											if (l == 832)
											{
												return "Orte lebendes Holz";
											}
											break;
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 1343)
								{
									switch (l)
									{
									case 849:
										return "Ermöglicht feste Blöcke auf umgeschaltet werden und ausschalten";
									case 850:
										return "Orte blauen Draht";
									case 851:
										return "Orte grünen Draht";
									case 852:
										return "Aktiviert, wenn ein Spieler auf sie";
									case 853:
										return "Aktiviert, wenn alles andere als ein Spieler auf sie";
									case 854:
										return "Shops haben niedrigere Preise";
									case 855:
										return "Schlagen Feinde manchmal fallen zusätzliche Münzen";
									case 856:
										return "'Nachdem eine wunderbare Zeit!'";
									case 857:
										return "Ermöglicht dem Halter, einen verbesserten doppelten Sprung tun";
									case 858:
									case 859:
									case 864:
									case 865:
									case 866:
									case 867:
									case 868:
									case 869:
									case 870:
									case 871:
									case 872:
									case 873:
									case 874:
									case 875:
									case 876:
									case 877:
									case 878:
									case 879:
									case 880:
									case 881:
									case 882:
									case 883:
									case 884:
									case 894:
									case 895:
									case 896:
									case 909:
									case 910:
									case 911:
									case 912:
									case 913:
									case 914:
									case 915:
									case 916:
									case 917:
									case 918:
									case 919:
									case 920:
									case 921:
									case 922:
									case 923:
									case 924:
									case 925:
									case 926:
									case 927:
									case 928:
									case 929:
									case 930:
									case 931:
									case 939:
									case 940:
									case 941:
									case 942:
									case 943:
									case 944:
									case 945:
									case 949:
									case 952:
									case 954:
									case 955:
									case 970:
									case 971:
									case 972:
									case 973:
									case 974:
									case 978:
									case 979:
									case 980:
									case 981:
									case 988:
									case 991:
									case 992:
									case 993:
									case 999:
										break;
									case 860:
										return "Bietet das Leben Regeneration und verringert die Abklingzeit Heiltränke";
									case 861:
										return "Schaltet den Halter in einen Werwolf in der Nacht und einem merfolk beim Betreten Wasser";
									case 862:
										return "Verursacht Sternen zu fallen und steigt Länge der Unbesiegbarkeit nach Schaden zu nehmen";
									case 863:
										return "Bietet die Möglichkeit, auf dem Wasser gehen";
									case 885:
										return "Immunität gegen Blutungen";
									case 886:
										return "Immunität gegen gebrochene Rüstung";
									case 887:
										return "Immunität gegen Gift";
									case 888:
										return "Immunität gegen dunklen";
									case 889:
										return "Immunität zu verlangsamen";
									case 890:
										return "Immunität zum Schweigen";
									case 891:
										return "Immunität zu verfluchen";
									case 892:
										return "Immunität gegen Schwäche";
									case 893:
										return "Immunität Verwirrung";
									case 897:
										return "Erhöht Nahkampf knockback";
									case 898:
										return "ermöglicht Flug";
									case 899:
										return "Erhöht alle Statistiken, wenn tagsüber getragen";
									case 900:
										return "Erhöht alle Statistiken, wenn während der Nacht getragen";
									case 901:
										return "Immunität gegen Schwäche und zerbrochene Rüstung";
									case 902:
										return "Immunität gegen Gift und Blutung";
									case 903:
										return "Immunität zu verlangsamen und Verwirrung";
									case 904:
										return "Immunität zum Schweigen zu bringen und fluchen";
									case 905:
										return "Verwendet Münzen für Munition";
									case 906:
										return "Bietet 7 Sekunden Immunität gegen Lava";
									case 907:
										return "Bietet die Möglichkeit, auf dem Wasser gehen";
									case 908:
										return "Bietet die Möglichkeit, auf dem Wasser und Lava zu Fuß";
									case 932:
										return "Orte Knochen";
									case 933:
										return "Orte verlässt";
									case 934:
										return "Ermöglicht der Besitzer für ein paar Sekunden schweben";
									case 935:
										return "12% mehr Schaden";
									case 936:
										return "Erhöht Nahkampf knockback";
									case 937:
										return "Explodiert beim Betreten";
									case 938:
										return "Absorbiert 25% Schaden an Spielern in Ihrem Team";
									case 946:
										return "Sie fallen langsamer, während diese";
									case 947:
										return "Reacts to the light";
									case 948:
										return "Ermöglicht Flug und langsam fallen";
									case 950:
										return "Bietet zusätzliche Mobilität auf Eis";
									case 951:
										return "Schnell startet Schneebälle";
									case 953:
										return "Allows the ability to slide down walls";
									case 956:
										return "7% erhöht Nahkampfsangriffstempo";
									case 957:
										return "7% erhöht Nahkampfsangriffstempo";
									case 958:
										return "7% erhöht Nahkampfsangriffstempo";
									case 959:
										return "4% erhöht Fernkampfschaden.";
									case 960:
										return "Erhöht die maximale Mana um 20";
									case 961:
										return "Erhöht die maximale Mana um 20";
									case 962:
										return "Erhöht die maximale Mana um 20";
									case 963:
										return "Gewährt Euch eine Chance, Angriffe auszuweichen";
									case 964:
										return "Feuert eine Verbreitung von Kugeln";
									case 965:
										return "Kann auf bestiegen werden";
									case 966:
										return "Leben Regeneration erhöht wird, wenn in der Nähe ein Lagerfeuer";
									case 967:
										return "Legen Sie es auf einem Stock und Braten über dem Lagerfeuer";
									case 968:
										return "Braten Sie es über dem Lagerfeuer!";
									case 969:
										return "Kleinere Verbesserungen zu sämtlichen Statistiken";
									case 975:
										return "Ermöglicht die Fähigkeit, abrutschen Wände";
									case 976:
										return "Ermöglicht die Fähigkeit, Wände zu klettern";
									case 977:
										return "Ermöglicht die Fähigkeit zu stürzen";
									case 982:
										return "Erhöht die maximale Mana um 20";
									case 983:
										return "Ermöglicht dem Halter, Sprung verdoppeln";
									case 984:
										return "Ermöglicht die Fähigkeit, Wände und dash klettern";
									case 985:
										return "Werfen Sie einen climbable Linie des Seils erstellen";
									case 986:
										return "Ermöglicht die Sammlung von Saatgut für Munition";
									case 987:
										return "Ermöglicht dem Halter, Sprung verdoppeln";
									case 989:
										return "Schießt ein verzaubertes Schwert Strahl";
									case 990:
										return "'Nicht mit einem hamdrill verwechseln'";
									case 994:
										return "Beschwört einen Baby-Eater of Souls";
									case 995:
										return "Wird verwendet, um Objekte Handwerk";
									case 996:
										return "Wird verwendet, um Objekte Handwerk";
									case 997:
										return "Schaltet Schlamm und Matsch in etwas nützlich";
									case 998:
										return "Wird verwendet, um Objekte Handwerk";
									case 1000:
										return "schießt Konfetti überall!";
									case 1001:
										return "16% erhöht Nahkampfschaden";
									case 1002:
										return "16% erhöht Fernkampfschaden";
									case 1003:
										return "Erhöht die maximale Mana um 80 und verringert Manaverbrauchs um 17%";
									case 1004:
										return "5% mehr Schaden";
									case 1005:
										return "8% Chance auf kritische Treffer";
									case 1006:
										return "Reagiert auf das Licht";
									default:
										switch (l)
										{
										case 1071:
											return "Gebrauchte mit Farbe um Farbe Blöcke";
										case 1072:
											return "Gebrauchte mit Farbe um Farbe Wände";
										default:
											switch (l)
											{
											case 1100:
												return "Wird verwendet, um Farbe zu entfernen";
											case 1107:
												return "Gebrauchte und türkis Farbstoff machen";
											case 1108:
												return "Dient zum grünen Farbstoff machen";
											case 1109:
												return "Dient zum Himmel blauer Farbstoff machen";
											case 1110:
												return "Wird verwendet, um einen gelben Farbstoff machen";
											case 1111:
												return "Dient zum blauen Farbstoff machen";
											case 1112:
												return "Wird verwendet, um Kalk Farbstoff machenWird verwendet, um rosa Farbstoff machen";
											case 1113:
												return "Wird verwendet, um rosa Farbstoff machen";
											case 1114:
												return "Dient zum orangen Farbstoff machen";
											case 1115:
												return "Wird verwendet, um roten Farbstoff zu machen";
											case 1116:
												return "Wird verwendet, um Blaugrünfarbstoff machen";
											case 1117:
												return "Dient zum violetten Farbstoff machen";
											case 1118:
												return "Wird verwendet, um Purpur machen";
											case 1119:
												return "Dient zum schwarzen Farbstoff machen";
											case 1120:
												return "Wird verwendet, um Farbstoffe Craft";
											case 1121:
												return "Shoots Bienen, die den Feind jagen wird";
											case 1122:
												return "Jagt deinen Feind";
											case 1123:
												return "Summons Killer-Bienen nach dem Auftreffen auf deinen Gegner";
											case 1129:
												return "Orte Nesselsucht";
											case 1130:
												return "Explodiert in einem Bienenschwarm";
											case 1131:
												return "Ermöglicht dem Halter, der Schwerkraft umkehren";
											case 1132:
												return "Gibt Bienen, wenn sie beschädigt";
											case 1133:
												return "Summons die Bienenkönigin";
											case 1141:
												return "Öffnet die Tür Dschungeltempel";
											case 1145:
												return "Verwendet für Grundhandwerk";
											case 1151:
												return "Aktiviert, wenn ein Spieler auf sie";
											case 1156:
												return "Verriegelungen auf, um Feinde für die kontinuierliche Schäden";
											case 1157:
												return "Beschwört einen Pygmäen, für Sie zu kämpfen";
											case 1158:
												return "Erhöht Eure maximale Anzahl der Schergen";
											case 1159:
												return "Erhöht Eure maximale Anzahl der Schergen";
											case 1160:
												return "Erhöht Eure maximale Anzahl der Schergen";
											case 1161:
												return "Erhöht Eure maximale Anzahl der Schergen";
											case 1162:
												return "Ermöglicht Flug und langsam fallen";
											case 1163:
												return "Ermöglicht dem Halter, Sprung verdoppeln";
											case 1164:
												return "Ermöglicht dem Halter, vierfachen Sprung";
											case 1165:
												return "Ermöglicht Flug und langsam fallen";
											case 1167:
												return "Erhöht den Schaden Eurer Schergen von 15";
											case 1169:
												return "Summons ein Baby Skeletron Kopf";
											case 1170:
												return "Summons ein Baby Hornisse";
											case 1171:
												return "Beschwört einen Geist tiki";
											case 1172:
												return "Summons ein Haustier Eidechse";
											case 1178:
												return "Schnell schießt gestochen scharfe Blätter";
											case 1179:
												return "Jagt deinen Feind";
											case 1180:
												return "Beschwört einen Papagei";
											case 1181:
												return "Summons ein Baby Truffle";
											case 1182:
												return "Summons ein Haustier Bäumchen";
											case 1183:
												return "Beschwört einen Hauch um Licht zur Verfügung";
											case 1188:
												return "Kann mir Mithril, Orichalcum, Adamantite und Titanium";
											case 1189:
												return "Kann mir Mithril, Orichalcum, Adamantite und Titanium";
											case 1195:
												return "Kann mir Adamantitbeschlagene und Titanium";
											case 1196:
												return "Kann mir Adamantitbeschlagene und Titanium";
											case 1205:
												return "8% erhöht Nahkampfschaden";
											case 1206:
												return "9% erhöht Fernkampfschaden";
											case 1207:
												return "7% erhöht magischen Schaden und kritische Trefferchance";
											case 1208:
												return "3% Der Schaden wurde erhöht";
											case 1209:
												return "2% Der Schaden wurde erhöht";
											case 1210:
												return "7% erhöht Nahkampfschaden";
											case 1211:
												return "15% erhöhte Chance auf kritische Treffer reichte";
											case 1212:
												return "18% Magie erhöht Chance auf kritische Treffer";
											case 1213:
												return "6% erhöhte Chance auf kritische Treffer";
											case 1214:
												return "11% erhöhte Bewegungsgeschwindigkeit";
											case 1215:
												return "8% erhöht Nahkampfschaden und Chance auf kritische Treffer";
											case 1216:
												return "16% erhöht Fernkampfschaden";
											case 1217:
												return "16% erhöht magischen Schaden und 7% erhöht Magie Chance auf kritische Treffer";
											case 1218:
												return "4% Der Schaden wurde erhöht";
											case 1219:
												return "3% erhöhten Schaden und kritische Trefferchance";
											case 1220:
												return "Wird verwendet, um Elemente aus Mithril, orichalcum, Adamant und Titan Bars Handwerk";
											case 1221:
												return "Gebraucht zu schmelzen Adamant und Titanerz";
											case 1226:
												return "Schießt eine leistungsstarke Kugel";
											case 1227:
												return "Schießt eine Spore Cloud";
											case 1228:
												return "Schießt eine Spore Cloud";
											case 1235:
												return "Prallt zurück nach der Kollision mit einer Wand";
											case 1242:
												return "Beschwört einen Baby-Dinosaurier";
											case 1244:
												return "Beschwört eine Wolke zu regnen auf deine Feinde";
											case 1247:
												return "Verursacht Sternen zu fallen und gibt Bienen, wenn sie verletzt";
											case 1248:
												return "10% erhöhte Chance auf kritische Treffer";
											case 1249:
												return "Erhöht Sprunghöhe";
											case 1250:
												return "Ermöglicht dem Halter, Sprung verdoppeln";
											case 1251:
												return "Ermöglicht dem Halter, Sprung verdoppeln";
											case 1252:
												return "Ermöglicht dem Halter, Sprung verdoppeln";
											case 1253:
												return "Legt eine Schale um den Eigentümer, wenn weniger als 25% Leben, reduziert Schäden";
											case 1254:
												return "Schießt ein leistungsfähiges, mit hoher Geschwindigkeit Kugel";
											case 1255:
												return "Schießt ein leistungsfähiges, mit hoher Geschwindigkeit Kugel";
											case 1256:
												return "Beschwört eine Wolke, um Blut auf deine Feinde regnen";
											case 1258:
												return "Schießt eine explosive Bolzen";
											case 1259:
												return "Schießt gestochen scharfe Blütenblätter in der Nähe befindliche Feinde";
											case 1260:
												return "Schießt ein Regenbogen, der kontinuierliche Schaden anrichtet";
											case 1261:
												return "Explodes in tödliche Splitter";
											case 1264:
												return "Schießt einen Ball von Frost";
											case 1265:
												return "Schießt ein leistungsfähiges, mit hoher Geschwindigkeit Kugel";
											case 1282:
												return "Erhöht maximales Mana um 20";
											case 1283:
												return "Erhöht maximales Mana um 40";
											case 1284:
												return "Erhöht maximales Mana um 40";
											case 1285:
												return "Erhöht maximales Mana um 60";
											case 1286:
												return "Erhöht maximales Mana um 60";
											case 1287:
												return "Erhöht maximales Mana um 80";
											case 1290:
												return "Erhöht die Bewegungsgeschwindigkeit, nachdem er geschlagen";
											case 1291:
												return "Erhöht dauerhaft die maximale Lebensdauer von 5";
											case 1293:
												return "Eingesetzt bei den Lihzahrd Altar";
											case 1294:
												return "Capable des Bergbaus Lihzahrd Ziegel";
											case 1295:
												return "Schießt ein Piercing ray von Wärme";
											case 1296:
												return "Beschwört einen mächtigen Felsblock";
											case 1297:
												return "Locher mit der Kraft einer golem";
											case 1299:
												return "Erhöht die Reichweite sehen, wenn statt";
											case 1300:
												return "Erhöht die Reichweite sehen für Waffen";
											case 1301:
												return "10% Der Schaden wurde erhöht";
											case 1303:
												return "Bietet Licht Unterwasser";
											case 1306:
												return "Schießt ein eisiger Sichel";
											case 1307:
												return "'Sie sind eine schreckliche Person'";
											case 1308:
												return "Schießt ein Gift fang, die mehrere Feinde durchbohrt";
											case 1309:
												return "Beschwört ein Baby Schleim für dich kämpfen";
											case 1310:
												return "Verursacht Gift auf Feinde";
											case 1311:
												return "Summons an eyeball spring";
											case 1312:
												return "Beschwört einen Baby-Schneemann";
											case 1313:
												return "Schießt einen Schädel";
											case 1314:
												return "Schießt ein Boxhandschuh";
											case 1315:
												return "Beschwört einen Pirateninvasion";
											case 1316:
												return "6% erhöht Nahkampfschaden";
											case 1317:
												return "8% erhöht Nahkampfschaden und Chance auf kritische Treffer";
											case 1318:
												return "4% erhöht Nahkampf kritische Trefferchance";
											case 1321:
												return "Erhöht Pfeil Geschwindigkeit und Schaden um 10%";
											case 1322:
												return "Verursacht Feuerschaden Angriff";
											case 1323:
												return "Reduces damage from touching lava";
											case 1326:
												return "Teleporte der Position der Maus";
											case 1327:
												return "Schießt einen tödlichen Sichel";
											case 1331:
												return "Vorladung der Brain of Cthulhu";
											case 1332:
												return "'Das Blut der Götter'";
											case 1333:
												return "Kann in Wasser gelegt werden";
											case 1334:
												return "Verringert Verteidigung des Ziels";
											case 1335:
												return "Verringert Verteidigung des Ziels";
											case 1336:
												return "Sprays eine Dusche von Jauche";
											case 1343:
												return "Erhöht die Nahkampf-Rückstoß und verursacht Feuerschaden Angriff";
											}
											break;
										}
										break;
									}
								}
								else
								{
									switch (l)
									{
									case 1430:
										return "Dient zur Waffe imbuement Flaschen Handwerk";
									case 1431:
										break;
									case 1432:
										return "Wird verwendet, um verschiedene Arten von Munition Handwerk";
									default:
										switch (l)
										{
										case 1444:
											return "Erzeugt einen Schatten Strahl, abprallt Wände";
										case 1445:
											return "Startet einen Feuerball, der in einem rasenden Inferno explodiert";
										case 1446:
											return "Beschwört eine verlorene Seele zu jagen Ihre Feinde";
										case 1447:
										case 1448:
											break;
										case 1449:
											return "bläst Seifenblasen";
										case 1450:
											return "bläst Seifenblasen";
										default:
											switch (l)
											{
											case 1503:
												return "Erhöht die maximale Mana um 80 und verringert Manaverbrauchs um 17%";
											case 1504:
												return "7% erhöht magischen Schaden und kritische Trefferchance";
											case 1505:
												return "8% erhöht magischen Schaden";
											case 1513:
												return "Ein leistungsfähiges Rückkehr Hammer";
											case 1515:
												return "Ermöglicht Flug und langsam fallen";
											case 1522:
												return "Für fangen die gem. Es fällt, wenn du stirbst";
											case 1523:
												return "Für fangen die gem. Es fällt, wenn du stirbst";
											case 1524:
												return "Für fangen die gem. Es fällt, wenn du stirbst";
											case 1525:
												return "Für fangen die gem. Es fällt, wenn du stirbst";
											case 1526:
												return "Für fangen die gem. Es fällt, wenn du stirbst";
											case 1527:
												return "Für fangen die gem. Es fällt, wenn du stirbst";
											case 1533:
												return "Freigeschaltet einen Jungle Brust in den Kerker";
											case 1534:
												return "Freigeschaltet eine Korruption Brust in den Kerker";
											case 1535:
												return "Freigeschaltet einen hochroten Brust in den Kerker";
											case 1536:
												return "Freigeschaltet eine Hallowed Brust in den Kerker";
											case 1537:
												return "Freischaltungen einem gefrorenen Brust in den Kerker";
											case 1543:
												return "Gebrauchte mit Farbe um Farbe Blöcke";
											case 1544:
												return "Gebrauchte mit Farbe um Farbe Wände";
											case 1545:
												return "Wird verwendet, um Farbe zu entfernen";
											case 1546:
												return "15% erhöht arrow Schaden";
											case 1547:
												return "15% erhöht Kugel Schaden";
											case 1548:
												return "15% erhöht Rakete Schaden";
											case 1549:
												return "13% erhöhte Chance auf kritische Treffer reichte";
											case 1550:
												return "7% erhöhte Chance auf kritische Treffer reichte";
											case 1551:
												return "Konvertiert chlorophytischen Bars in Shroomite Bars";
											case 1553:
												return "50% Chance, nicht verbrauchen Munition";
											case 1554:
												return "Sie sollten nicht diese";
											case 1555:
												return "Sie sollten nicht diese";
											case 1556:
												return "Sie sollten nicht diese";
											case 1557:
												return "Sie sollten nicht diese";
											case 1558:
												return "Sie sollten nicht diese";
											case 1559:
												return "Sie sollten nicht diese";
											case 1560:
												return "Sie sollten nicht diese";
											case 1561:
												return "Sie sollten nicht diese";
											case 1562:
												return "Sie sollten nicht diese";
											case 1563:
												return "Sie sollten nicht diese";
											case 1564:
												return "Sie sollten nicht diese";
											case 1565:
												return "Sie sollten nicht diese";
											case 1566:
												return "Sie sollten nicht diese";
											case 1567:
												return "Sie sollten nicht diese";
											case 1568:
												return "Sie sollten nicht diese";
											case 1569:
												return "Schnell werfen Leben stehlen Dolche";
											case 1571:
												return "Ein leistungsfähiges Javalin die winzigen Esser entfesselt";
											case 1572:
												return "Beschwört einen mächtigen Frost Hydra, um Eis auf eure Feinde spucken";
											case 1578:
												return "Releases Bienen und erhöht die Bewegungsgeschwindigkeit bei Beschädigung";
											case 1579:
												return "Der Träger kann laufen super schnell";
											case 1580:
												return "Sie sollten nicht diese";
											case 1581:
												return "Sie sollten nicht diese";
											case 1582:
												return "Sie sollten nicht diese";
											case 1583:
												return "Sie sollten nicht diese";
											case 1584:
												return "Sie sollten nicht diese";
											case 1585:
												return "Sie sollten nicht diese";
											case 1586:
												return "Sie sollten nicht diese";
											case 1587:
												return "Sie sollten nicht diese";
											case 1588:
												return "Sie sollten nicht diese";
											case 1595:
												return "Erhöht maximales Mana um 20";
											}
											break;
										}
										break;
									}
								}
							}
						}
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						if (l <= 332)
						{
							if (l <= 128)
							{
								if (l <= 36)
								{
									if (l <= 8)
									{
										if (l == -1)
										{
											return "Può estrarre meteorite";
										}
										if (l == 8)
										{
											return "Fornisce luce";
										}
									}
									else
									{
										switch (l)
										{
										case 15:
											return "Indica il tempo";
										case 16:
											return "Indica il tempo";
										case 17:
											return "Indica il tempo";
										case 18:
											return "Mostra la profondità";
										case 19:
										case 20:
										case 21:
										case 22:
											break;
										case 23:
											return "'Sia gustoso che infiammabile'";
										default:
											if (l == 29)
											{
												return "Aumenta in maniera permanente la vita massima di 20";
											}
											switch (l)
											{
											case 33:
												return "Usato per fondere il minerale";
											case 35:
												return "Usata per creare oggetti dalle sbarre di metallo";
											case 36:
												return "Usato per l'artigianato di base";
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 75)
									{
										if (l == 43)
										{
											return "Evoca l'Occhio di Cthulhu";
										}
										switch (l)
										{
										case 49:
											return "Rigenera la vita lentamente";
										case 50:
											return "Guarda nello specchio per tornare a casa";
										case 51:
										case 52:
										case 55:
										case 58:
										case 59:
										case 60:
										case 61:
										case 62:
										case 63:
										case 69:
											break;
										case 53:
											return "Permette il salto doppio";
										case 54:
											return "Colui che li indossa può correre velocissimo";
										case 56:
											return "'Pulsa di energia oscura'";
										case 57:
											return "'Pulsa di energia oscura'";
										case 64:
											return "Evoca una spina vile";
										case 65:
											return "Fa piovere le stelle dal cielo";
										case 66:
											return "Ripulisce la distruzione";
										case 67:
											return "Rimuove il sacro";
										case 68:
											return "'Gustoso!'";
										case 70:
											return "Evoca il Mangiatore di mondi";
										default:
											if (l == 75)
											{
												return "Sparisce dopo l'alba";
											}
											break;
										}
									}
									else
									{
										if (l == 84)
										{
											return "'Vieni qui!'";
										}
										if (l == 88)
										{
											return "Fa luce una volta indossato";
										}
										switch (l)
										{
										case 98:
											return "33% di possibilità di non consumare munizioni";
										case 100:
											return "Velocità del corpo a corpo aumentata del 7%";
										case 101:
											return "Velocità del corpo a corpo aumentata del 7%";
										case 102:
											return "Velocità del corpo a corpo aumentata del 7%";
										case 103:
											return "In grado di estrarre la pietra infernale";
										case 109:
											return "Aumenta in maniera permanente il mana massimo di 20";
										case 111:
											return "Aumenta il mana massimo di 20";
										case 112:
											return "Tira palle di fuoco";
										case 113:
											return "Scaglia un missile guidato";
										case 114:
											return "Muovi magicamente la terra";
										case 115:
											return "Crea una sfera di luce magica";
										case 117:
											return "'Calda al tocco'";
										case 118:
											return "Lanciato a volte da Scheletri e Piranha";
										case 120:
											return "Incendia le frecce di legno";
										case 121:
											return "'Creato dal fuoco!'";
										case 123:
											return "Danno magico aumentato del 5%";
										case 124:
											return "Danno magico aumentato del 5%";
										case 125:
											return "Danno magico aumentato del 5%";
										case 128:
											return "Permettono il volo";
										}
									}
								}
							}
							else
							{
								if (l <= 218)
								{
									if (l <= 187)
									{
										switch (l)
										{
										case 148:
											return "Avere questo oggetto potrebbe attirare attenzione non desiderata";
										case 149:
											return "'Contiene simboli strani'";
										case 150:
										case 154:
										case 155:
										case 160:
										case 161:
										case 162:
										case 163:
										case 164:
											break;
										case 151:
											return "Danno a distanza  aumentato del 4%";
										case 152:
											return "Danno a distanza  aumentato del 4%";
										case 153:
											return "Danno a distanza  aumentato del 4%";
										case 156:
											return "Permette immunità allo spintone";
										case 157:
											return "Spruzza una cascata d'acqua";
										case 158:
											return "Annulla i danni da caduta";
										case 159:
											return "Aumenta l'altezza del salto";
										case 165:
											return "Lancia un dardo di acqua lento";
										case 166:
											return "Una piccola esplosione che distruggerà alcune mattonelle";
										case 167:
											return "Una grande esplosione che distruggerà molte mattonelle";
										case 168:
											return "Una piccola esplosione che non distruggerà mattonelle";
										default:
											if (l == 175)
											{
												return "'Calda al tocco'";
											}
											switch (l)
											{
											case 186:
												return "'Perché non annegare è alquanto piacevole'";
											case 187:
												return "Abilita al nuoto";
											}
											break;
										}
									}
									else
									{
										if (l == 193)
										{
											return "Permette immunità ai blocchi di fuoco";
										}
										if (l == 197)
										{
											return "Spara stelle cadenti";
										}
										switch (l)
										{
										case 208:
											return "'Graziosa, oh com'è graziosa'";
										case 211:
											return "Velocità del corpo a corpo aumentata del 12%";
										case 212:
											return "Velocità di movimento aumentata del 10%";
										case 213:
											return "Crea erba dalla terra";
										case 215:
											return "'Può disturbare gli altri'";
										case 218:
											return "Evoca una palla di fuoco guidata";
										}
									}
								}
								else
								{
									if (l <= 305)
									{
										switch (l)
										{
										case 222:
											return "Fa crescere le piante";
										case 223:
											return "Consumo mana ridotto del 6%";
										case 224:
										case 225:
										case 226:
										case 227:
											break;
										case 228:
											return "Aumenta il mana massimo di 20";
										case 229:
											return "Aumenta il mana massimo di 20";
										case 230:
											return "Aumenta il mana massimo di 20";
										default:
											switch (l)
											{
											case 235:
												return "'Lanciare potrebbe essere difficile.'";
											case 236:
												break;
											case 237:
												return "'Migliora il tuo look!'";
											case 238:
												return "Danno magico aumentato del 15%";
											default:
												switch (l)
												{
												case 261:
													return "'Sta ridendo, potrebbe essere uno spuntino appetitoso'";
												case 266:
													return "'Buona idea!'";
												case 267:
													return "'Sei una persona terribile.'";
												case 268:
													return "Aumenta moltissimo il respiro sott'acqua";
												case 272:
													return "Evoca una falce demoniaca";
												case 281:
													return "Permette la raccolta di semi come munizioni";
												case 282:
													return "Funziona da bagnato";
												case 283:
													return "Da usare con la cerbottana";
												case 285:
													return "Velocità di movimento aumentata del 5%";
												case 288:
													return "Dà immunità alla lava";
												case 289:
													return "Rigenera la vita";
												case 290:
													return "Velocità di movimento aumentata del 25%";
												case 291:
													return "Respira acqua invece di aria";
												case 292:
													return "Aumenta la difesa di 8";
												case 293:
													return "Aumenta la rigenerazione del mana";
												case 294:
													return "Danno magico aumentato del 20%";
												case 295:
													return "Velocità di caduta lenta";
												case 296:
													return "Mostra l'ubicazione di tesori e minerale";
												case 297:
													return "Rende invisibili";
												case 298:
													return "Emette un'aura di luce";
												case 299:
													return "Migliora la visione notturna";
												case 300:
													return "Aumenta il ritmo di generazone dei nemici";
												case 301:
													return "Anche gli aggressori subiscono danni";
												case 302:
													return "Consente di camminare sull'acqua";
												case 303:
													return "Velocità e danni della freccia aumentati del 20%";
												case 304:
													return "Mostra la posizione dei nemici";
												case 305:
													return "Permette il controllo della gravità";
												}
												break;
											}
											break;
										}
									}
									else
									{
										if (l == 324)
										{
											return "'Bandita in molti luoghi'";
										}
										switch (l)
										{
										case 327:
											return "Apre una cassa d'oro";
										case 328:
											break;
										case 329:
											return "Apre tutte le casse ombra";
										default:
											if (l == 332)
											{
												return "Usato per fabbricare abiti";
											}
											break;
										}
									}
								}
							}
						}
						else
						{
							if (l <= 726)
							{
								if (l <= 603)
								{
									if (l <= 407)
									{
										if (l == 352)
										{
											return "Usato per produrre birra";
										}
										switch (l)
										{
										case 357:
											return "Migliorie minori a tutti i parametri";
										case 361:
											return "Evoca un esercito di goblin";
										case 363:
											return "Usata per un'avanzata lavorazione del legno";
										case 367:
											return "Abbastanza forte per distruggere gli Altari dei demoni";
										case 371:
											return "Aumenta il mana massimo di 40";
										case 372:
											return "Velocità di movimento aumentata del 7%";
										case 373:
											return "Danno a distanza aumentato del 10%";
										case 376:
											return "Aumenta il mana massimo di 60";
										case 377:
											return "Possibilità di colpo critico nel corpo a corpo aumentata del 5%";
										case 378:
											return "Danno a distanza aumentato del 12%";
										case 385:
											return "Può estrarre mitrilio";
										case 386:
											return "Può estrarre adamantio";
										case 389:
											return "Può confondere";
										case 393:
											return "Mostra posizione orizzontale";
										case 394:
											return "Abilita al nuoto";
										case 395:
											return "Mostra posizione";
										case 396:
											return "Annulla i danni da caduta";
										case 397:
											return "Permette immunità allo spintone";
										case 398:
											return "Permette la combinazione di alcuni accessori";
										case 399:
											return "Permette il salto doppio";
										case 400:
											return "Aumenta il mana massimo di 80";
										case 401:
											return "Possibilità di colpo critico nel corpo a corpo aumentata del 7%";
										case 402:
											return "Danno a distanza aumentato del 14%";
										case 403:
											return "Danno aumentato del 6%";
										case 404:
											return "Possibilità di colpo critico aumetata del 4%";
										case 405:
											return "Permettono il volo";
										case 407:
											return "Aumenta la possibilità di collocamento dei blocchi";
										}
									}
									else
									{
										switch (l)
										{
										case 422:
											return "Spruzza acquasanta su alcuni blocchi";
										case 423:
											return "Diffonde la distruzione su alcuni blocchi";
										case 424:
											break;
										case 425:
											return "Evoca una fata magica";
										default:
											if (l == 434)
											{
												return "Tre raffiche";
											}
											switch (l)
											{
											case 485:
												return "Durante la luna piena trasforma il portatore in un lupo mannaro";
											case 486:
												return "Crea una griglia sullo schermo per sistemare i blocchi";
											case 489:
												return "Danno magico aumentato del 15%";
											case 490:
												return "Danno nel corpo a corpo aumentato del 15%";
											case 491:
												return "Danno a distanza aumentato del 15%";
											case 492:
												return "Permettono il volo e la caduta lenta";
											case 493:
												return "Permettono il volo e la caduta lenta";
											case 495:
												return "Genera un arcobaleno guidato";
											case 496:
												return "Evoca un blocco di ghiaccio";
											case 497:
												return "Trasforma il portatore in Tritone quando entra in acqua";
											case 506:
												return "Usa il gel come munizione";
											case 509:
												return "Sistema i cavi";
											case 510:
												return "Rimuove i cavi";
											case 515:
												return "Crea svariati frammenti di cristallo all'impatto";
											case 516:
												return "Evoca stelle cadenti all'impatto";
											case 517:
												return "Un pugnale magico che ritorna";
											case 518:
												return "Evoca veloci frammenti di cristallo infuocati";
											case 519:
												return "Evoca sfere di fuoco profane";
											case 520:
												return "'L'essenza delle creature della luce'";
											case 521:
												return "'L'essenza delle creature oscure'";
											case 522:
												return "'Neanche l'acqua può spegnere la fiamma'";
											case 523:
												return "Può essere messa in acqua";
											case 524:
												return "Usata per fondere il minerale adamantio";
											case 525:
												return "Usata per creare oggetti da sbarre di mitrilio e adamantio";
											case 526:
												return "'Appuntito e magico!'";
											case 527:
												return "'A volte portato dalle creature nei deserti distrutti'";
											case 528:
												return "'A volte portato dalle creature nei deserti di luce'";
											case 529:
												return "Si attiva quando calpestata";
											case 531:
												return "Può essere incantato";
											case 532:
												return "Causa la caduta delle stelle quando colpito";
											case 533:
												return "50% di possibilità di non consumare munizioni";
											case 534:
												return "Spara una rosa di proiettili";
											case 535:
												return "Riduce la ricarica della pozione curativa";
											case 536:
												return "Aumenta lo spintone in corpo a corpo";
											case 541:
												return "Si attiva quando calpestata";
											case 542:
												return "Si attiva quando calpestata";
											case 543:
												return "Si attiva quando calpestata";
											case 544:
												return "Evoca i gemelli";
											case 547:
												return "'L'essenza del terrore puro'";
											case 548:
												return "'L'essenza del distruttore'";
											case 549:
												return "'L'essenza degli osservatori onniscienti'";
											case 551:
												return "Possibilità di colpo critico aumentata del 7%";
											case 552:
												return "Danno aumentato del 7%";
											case 553:
												return "Danno a distanza aumentato del 15%";
											case 554:
												return "Aumenta la durata dell'invincibilità dopo aver subito danni";
											case 555:
												return "Consumo mana ridotto del 8%";
											case 556:
												return "Evoca l'Distruttore";
											case 557:
												return "Evoca lo Skeletron primario";
											case 558:
												return "Aumenta il mana massimo di 100";
											case 559:
												return "Possibilità di danno corpo a corpo e colpo critico aumentata del 10%";
											case 560:
												return "Evoca lo slime re";
											case 561:
												return "Raccoglie fino a 5";
											case 575:
												return "'L'essenza delle potenti creature volanti'";
											case 576:
												return "Ha una possibilità di registrare canzoni";
											case 579:
												return "'Da non confondere con il Segartello'";
											case 580:
												return "Esplodono quando attivati";
											case 581:
												return "Invia acqua alle pompe esterne";
											case 582:
												return "Riceve acqua dalle pompe interne";
											case 583:
												return "Si attiva ogni secondo";
											case 584:
												return "Si attiva ogni 3 secondi";
											case 585:
												return "Si attiva ogni 5 secondi";
											case 599:
												return "Tasto destro del mouse per aprire";
											case 600:
												return "Tasto destro del mouse per aprire";
											case 601:
												return "Tasto destro del mouse per aprire";
											case 602:
												return "Evoca la Legione di Frost";
											case 603:
												return "Evoca un coniglio domestico";
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 686)
									{
										switch (l)
										{
										case 665:
											return "Non si dovrebbe avere questo";
										case 666:
											return "Non si dovrebbe avere questo";
										case 667:
											return "Non si dovrebbe avere questo";
										case 668:
											return "Non si dovrebbe avere questo";
										case 669:
											return "Evoca un bambino pinguino";
										default:
											if (l == 676)
											{
												return "Spara un bullone di ghiaccio";
											}
											switch (l)
											{
											case 683:
												return "Evoca tridente del Diavolo";
											case 684:
												return "16% aumentato mischia e danno a distanza";
											case 685:
												return "11% aumentato mischia ea distanza possibilità di critico";
											case 686:
												return "8% maggiore velocità di movimento";
											}
											break;
										}
									}
									else
									{
										switch (l)
										{
										case 707:
											return "Indica il tempo di";
										case 708:
											return "Indica il tempo di";
										case 709:
											return "Indica il tempo di";
										default:
											if (l == 716)
											{
												return "Usato per oggetti artigianali da barre metalliche";
											}
											switch (l)
											{
											case 723:
												return "Spara un fascio di luce";
											case 724:
												return "Spara un bullone di ghiaccio";
											case 725:
												return "Germogli gelo frecce";
											case 726:
												return "Riprende un flusso di gelo";
											}
											break;
										}
									}
								}
							}
							else
							{
								if (l <= 832)
								{
									if (l <= 761)
									{
										switch (l)
										{
										case 748:
											return "Permette di volo e la caduta lenta";
										case 749:
											return "Permette di volo e la caduta lenta";
										default:
											if (l == 753)
											{
												return "Summons a pet turtle";
											}
											if (l == 761)
											{
												return "Permette di volo e la caduta lenta";
											}
											break;
										}
									}
									else
									{
										switch (l)
										{
										case 779:
											return "Crea e distrugge biomi quando spruzzato";
										case 780:
											return "Usato dal Clentaminator";
										case 781:
											return "Usato dal Clentaminator";
										case 782:
											return "Usato dal Clentaminator";
										case 783:
											return "Usato dal Clentaminator";
										case 784:
											return "Usato dal Clentaminator";
										case 785:
											return "Permette di volo e la caduta lenta";
										case 786:
											return "Permette di volo e la caduta lenta";
										case 787:
											return "Abbastanza forte da distruggere Altari Demone";
										case 788:
											return "Evoca una lancia spina";
										case 789:
										case 790:
										case 791:
										case 795:
										case 796:
										case 797:
											break;
										case 792:
											return "2% incrementato il danno";
										case 793:
											return "2% incrementato il danno";
										case 794:
											return "2% incrementato il danno";
										case 798:
											return "In grado di estrarre Hellstone";
										default:
											switch (l)
											{
											case 821:
												return "Permette di volo e la caduta lenta";
											case 822:
												return "Permette di volo e la caduta lenta";
											case 823:
												return "Permette di volo e la caduta lenta";
											default:
												if (l == 832)
												{
													return "Luoghi legno vivo";
												}
												break;
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 1343)
									{
										switch (l)
										{
										case 849:
											return "Consente blocchi solidi di essere attivata e disattivata";
										case 850:
											return "Luoghi filo blu";
										case 851:
											return "Luoghi filo verde";
										case 852:
											return "Attiva quando un giocatore passi su di esso";
										case 853:
											return "Attiva quando tutt'altro che un giocatore passi su di essa";
										case 854:
											return "Negozi hanno prezzi più bassi";
										case 855:
											return "Colpire i nemici a volte cadere monete extra";
										case 856:
											return "'Avere un tempo meraviglioso!'";
										case 857:
											return "Consente al titolare di fare una migliore doppio salto";
										case 858:
										case 859:
										case 864:
										case 865:
										case 866:
										case 867:
										case 868:
										case 869:
										case 870:
										case 871:
										case 872:
										case 873:
										case 874:
										case 875:
										case 876:
										case 877:
										case 878:
										case 879:
										case 880:
										case 881:
										case 882:
										case 883:
										case 884:
										case 894:
										case 895:
										case 896:
										case 909:
										case 910:
										case 911:
										case 912:
										case 913:
										case 914:
										case 915:
										case 916:
										case 917:
										case 918:
										case 919:
										case 920:
										case 921:
										case 922:
										case 923:
										case 924:
										case 925:
										case 926:
										case 927:
										case 928:
										case 929:
										case 930:
										case 931:
										case 939:
										case 940:
										case 941:
										case 942:
										case 943:
										case 944:
										case 945:
										case 949:
										case 952:
										case 954:
										case 955:
										case 970:
										case 971:
										case 972:
										case 973:
										case 974:
										case 978:
										case 979:
										case 980:
										case 981:
										case 988:
										case 991:
										case 992:
										case 993:
										case 999:
											break;
										case 860:
											return "Fornisce la rigenerazione della vita e riduce il cooldown delle pozioni di guarigione";
										case 861:
											return "Attiva il supporto in un lupo mannaro di notte e un Tritone quando si entra in acqua";
										case 862:
											return "Provoca stelle a cadere e aumenta la durata di invincibilità dopo l'assunzione di danni";
										case 863:
											return "Offre la possibilità di camminare sull'acqua";
										case 885:
											return "immunità alle emorragie";
										case 886:
											return "immunità alle armature rotto";
										case 887:
											return "immunità al veleno";
										case 888:
											return "Immunità alle tenebre";
										case 889:
											return "immunità per rallentare";
										case 890:
											return "immunità al silenzio";
										case 891:
											return "immunità a maledire";
										case 892:
											return "immunità alla debolezza";
										case 893:
											return "immunità alla confusione";
										case 897:
											return "Aumenta mischia contraccolpo";
										case 898:
											return "consente di volo";
										case 899:
											return "Aumenta tutte le statistiche se consumato durante il giorno";
										case 900:
											return "Aumenta tutte le statistiche se consumato durante la notte";
										case 901:
											return "immunità alla debolezza e armatura rotto";
										case 902:
											return "immunità al veleno e sanguinamento";
										case 903:
											return "immunità a rallentare e la confusione";
										case 904:
											return "immunità al silenzio e maledire";
										case 905:
											return "Utilizza le monete per munizioni";
										case 906:
											return "Fornisce 7 secondi di immunità ai lavica";
										case 907:
											return "Offre la possibilità di camminare sull'acqua";
										case 908:
											return "Offre la possibilità di camminare sulle acque e la lava";
										case 932:
											return "luoghi osso";
										case 933:
											return "luoghi lascia";
										case 934:
											return "Consente al proprietario di galleggiare per qualche secondo";
										case 935:
											return "12% incrementato il danno";
										case 936:
											return "Aumenta mischia contraccolpo";
										case 937:
											return "Esplode quando calpestato";
										case 938:
											return "Assorbe il 25% del danno fatto ai giocatori per la tua squadra";
										case 946:
											return "Si cadrà più lento mentre si tiene presente";
										case 947:
											return "Reagisce alla luce";
										case 948:
											return "Permette di volo e la caduta lenta";
										case 950:
											return "Fornisce la mobilità in più sul ghiaccio";
										case 951:
											return "Lancia rapidamente palle di neve";
										case 953:
											return "Consente la possibilità di far scorrere verso il basso le pareti";
										case 956:
											return "7% maggiore velocità di mischia";
										case 957:
											return "7% maggiore velocità di mischia";
										case 958:
											return "7% maggiore velocità di mischia";
										case 959:
											return "4% incrementato il danno a distanza";
										case 960:
											return "Aumenta mana massimo del 20";
										case 961:
											return "Aumenta mana massimo del 20";
										case 962:
											return "Aumenta mana massimo del 20";
										case 963:
											return "Dà la possibilità di schivare l'attacco";
										case 964:
											return "Spara una diffusione di proiettili";
										case 965:
											return "Può essere salito sul";
										case 966:
											return "Life regeneration is increased when near a campfire";
										case 967:
											return "La vita di rigenerazione è aumentata quando vicino a un falò";
										case 968:
											return "Arrostire su un fuoco!";
										case 969:
											return "Piccoli miglioramenti a tutti stats";
										case 975:
											return "Consente la possibilità di far scorrere verso il basso le pareti";
										case 976:
											return "Consente la possibilità di scalare le pareti";
										case 977:
											return "Consente la possibilità di precipitare";
										case 982:
											return "Aumenta mana massimo del 20";
										case 983:
											return "Consente al titolare di doppio salto";
										case 984:
											return "Consente la possibilità di scalare muri e cruscotto";
										case 985:
											return "Buttare per creare una linea scalabile di corda";
										case 986:
											return "Permette la raccolta di semi per munizioni";
										case 987:
											return "Consente al titolare di doppio salto";
										case 989:
											return "Spara un fascio di spada incantata";
										case 990:
											return "'Da non confondere con un hamdrill'";
										case 994:
											return "Evoca un Mangiamorte Baby of Souls";
										case 995:
											return "Usato per mestiere oggetti";
										case 996:
											return "Usato per mestiere oggetti";
										case 997:
											return "Attiva limo e fango in qualcosa di più utile";
										case 998:
											return "Usato per mestiere oggetti";
										case 1000:
											return "Spara coriandoli ovunque!";
										case 1001:
											return "16% incrementato il danno melee";
										case 1002:
											return "16% incrementato il danno a distanza";
										case 1003:
											return "Aumenta mana massimo da 80 e riduce l'uso di mana del 17%";
										case 1004:
											return "5% incrementato il danno";
										case 1005:
											return "8% maggiore possibilità di critico";
										case 1006:
											return "Reagisce alla luce";
										default:
											switch (l)
											{
											case 1071:
												return "Usato con vernice a blocchi di colore";
											case 1072:
												return "Usato con la vernice per pareti di colore";
											default:
												switch (l)
												{
												case 1100:
													return "Usato per rimuovere la vernice";
												case 1107:
													return "Usato per fare colorante verde acqua";
												case 1108:
													return "Usato per fare colorante verde";
												case 1109:
													return "Usato per fare cielo blu colorante";
												case 1110:
													return "Usato per fare colorante giallo";
												case 1111:
													return "Usato per fare colorante blu";
												case 1112:
													return "Usato per fare tintura calce";
												case 1113:
													return "Usato per fare colorante rosa";
												case 1114:
													return "Usato per fare arancio colorante";
												case 1115:
													return "Usato per fare colorante rosso";
												case 1116:
													return "Usato per fare colorante ciano";
												case 1117:
													return "Usato per fare viola colorante";
												case 1118:
													return "Usato per fare porpora";
												case 1119:
													return "Usato per fare tintura nera";
												case 1120:
													return "Usato per mestiere coloranti";
												case 1121:
													return "Shoots api che inseguirà il nemico";
												case 1122:
													return "Insegue il tuo nemico";
												case 1123:
													return "Convoca le api assassine dopo aver colpito il nemico";
												case 1129:
													return "luoghi orticaria";
												case 1130:
													return "Esplode in uno sciame di api";
												case 1131:
													return "Consente al titolare di invertire la gravità";
												case 1132:
													return "Rilascia le api se danneggiato";
												case 1133:
													return "Evoca la Queen Bee";
												case 1141:
													return "Apre la porta del tempio giungla";
												case 1145:
													return "Usato per la lavorazione di base";
												case 1151:
													return "Attiva quando un giocatore passi su di essa su";
												case 1156:
													return "Chiusure a nemici per danni continua";
												case 1157:
													return "Evoca un pigmeo a combattere per voi";
												case 1158:
													return "Aumenta il numero massimo di servitori";
												case 1159:
													return "Aumenta il numero massimo di servitori";
												case 1160:
													return "Aumenta il numero massimo di servitori";
												case 1161:
													return "Aumenta il numero massimo di servitori";
												case 1162:
													return "Permette di volo e la caduta lenta";
												case 1163:
													return "Consente al titolare di doppio salto";
												case 1164:
													return "Consente al titolare di salto quadruplo";
												case 1165:
													return "Permette di volo e la caduta lenta";
												case 1167:
													return "Aumenta il danno dei tuoi servitori dal 15";
												case 1169:
													return "Evoca un bambino Skeletron Testa";
												case 1170:
													return "Evoca un bambino Hornet";
												case 1171:
													return "Evoca un Spirito Tiki";
												case 1172:
													return "Evoca una lucertola";
												case 1178:
													return "Spara rapidamente foglie affilatissime";
												case 1179:
													return "Insegue il tuo nemico";
												case 1180:
													return "Evoca un pappagallo domestico";
												case 1181:
													return "Evoca un bambino Tartufo";
												case 1182:
													return "Evoca un Pet Alberello";
												case 1183:
													return "Evoca un Wisp per fornire luce";
												case 1188:
													return "Possono miniera Mythril, oricalco, Adamantite e titanio";
												case 1189:
													return "Possono miniera Mythril, oricalco, Adamantite e titanio";
												case 1195:
													return "Possono miniera Adamantite e Titanio";
												case 1196:
													return "Possono miniera Adamantite e Titanio";
												case 1205:
													return "8% incrementato il danno melee";
												case 1206:
													return "9% incrementato il danno a distanza";
												case 1207:
													return "7% maggiore danno magico e possibilità di critico";
												case 1208:
													return "3% incrementato il danno";
												case 1209:
													return "2% incrementato il danno";
												case 1210:
													return "7% incrementato il danno melee";
												case 1211:
													return "15% maggiore distanza possibilità di critico";
												case 1212:
													return "18% aumento magico possibilità di critico";
												case 1213:
													return "6% maggiore possibilità di critico";
												case 1214:
													return "11% maggiore velocità di movimento";
												case 1215:
													return "8% incrementato il danno melee e possibilità di critico";
												case 1216:
													return "16% incrementato il danno a distanza";
												case 1217:
													return "16% maggiore danno magico e il 7% è aumentato magico possibilità di critico";
												case 1218:
													return "4% in più di danni";
												case 1219:
													return "3% ha aumentato i danni e possibilità di critico";
												case 1220:
													return "Usato per creare oggetti da mithril, oricalco, Adamantite, e barre di titanio";
												case 1221:
													return "Usato per Adamantite odore e il minerale di titanio";
												case 1226:
													return "Spara un potente globo";
												case 1227:
													return "Spara una nuvola di spore";
												case 1228:
													return "Spara una nuvola di spore";
												case 1235:
													return "Rimbalza indietro dopo aver colpito un muro";
												case 1242:
													return "Evoca un dinosauro del bambino";
												case 1244:
													return "Evoca una nube a piovere sui vostri nemici";
												case 1247:
													return "Provoca stelle a cadere e rilascia le api quando feriti";
												case 1248:
													return "Il 10% ha aumentato la possibilità di critico feriti";
												case 1249:
													return "Aumenta salto altezza";
												case 1250:
													return "Consente al titolare di doppio salto";
												case 1251:
													return "Consente al titolare di doppio salto";
												case 1252:
													return "Consente al titolare di doppio salto";
												case 1253:
													return "Mette un guscio attorno al proprietario quando la vita sotto il 25%, che riduce i danni";
												case 1254:
													return "Spara un potente, ad alta velocità di proiettile";
												case 1255:
													return "Spara un potente, ad alta velocità di proiettile";
												case 1256:
													return "Evoca una nube a piovere sangue sui tuoi nemici";
												case 1258:
													return "Spara un bullone esplosivo";
												case 1259:
													return "Shoots nitidissime petali di fiori presso i nemici nelle vicinanze";
												case 1260:
													return "Spara un arcobaleno che fa danni continua";
												case 1261:
													return "Esplode in frammenti di proiettile mortale";
												case 1264:
													return "Spara una palla di gelo";
												case 1265:
													return "Spara un potente, ad alta velocità di proiettile";
												case 1282:
													return "Aumenta mana massimo del 20";
												case 1283:
													return "Aumenta mana massimo del 40";
												case 1284:
													return "Aumenta mana massimo del 40";
												case 1285:
													return "Aumenta mana massimo del 60";
												case 1286:
													return "Aumenta mana massimo del 60";
												case 1287:
													return "Aumenta mana massimo del 80";
												case 1290:
													return "Aumenta la velocità di movimento dopo essere stato colpito";
												case 1291:
													return "Permanente aumenta la durata massima di 5";
												case 1293:
													return "Usato all'Altare Lihzahrd";
												case 1294:
													return "Capace di estrazione Lihzahrd mattoni";
												case 1295:
													return "Spara un raggio penetrante di calore";
												case 1296:
													return "Evoca un potente masso";
												case 1297:
													return "Pugni con la forza di un golem";
												case 1299:
													return "Aumenta Visualizza linea quando si svolgono";
												case 1300:
													return "Aumenta la visualizzazione della gamma di pistole";
												case 1301:
													return "10% in più di danno";
												case 1303:
													return "Fornisce luce sotto l'acqua";
												case 1306:
													return "Spara una falce di ghiaccio";
												case 1307:
													return "'Lei è una persona terribile'";
												case 1308:
													return "Spara un veleno zanna che trafigge più nemici";
												case 1309:
													return "Evoca un bambino melma per combattere per voi";
												case 1310:
													return "Infligge veleno sui nemici";
												case 1311:
													return "Evoca una primavera bulbo oculare";
												case 1312:
													return "Evoca un bambino pupazzo di neve";
												case 1313:
													return "Spara un teschio";
												case 1314:
													return "Spara un guantone da boxe";
												case 1315:
													return "Evoca un invasione dei pirati";
												case 1316:
													return "6% aumento danni da mischia";
												case 1317:
													return "8% ha aumentato i danni melee e possibilità di critico";
												case 1318:
													return "4% in più di possibilità di critico melee";
												case 1321:
													return "Aumentare la velocità della freccia e il danno del 10%";
												case 1322:
													return "Infligge danni da fuoco in attacco";
												case 1323:
													return "Riduce i danni da toccare lavica";
												case 1326:
													return "Teleports alla posizione del mouse";
												case 1327:
													return "Spara una falce mortale";
												case 1331:
													return "Evoca il cervello di Cthulhu";
												case 1332:
													return "'Il sangue degli dei'";
												case 1333:
													return "Può essere posizionato in acqua";
												case 1334:
													return "Diminuisce la Difesa del bersaglio";
												case 1335:
													return "Diminuisce la Difesa del bersaglio";
												case 1336:
													return "Spray una pioggia di ichor";
												case 1343:
													return "Aumenta mischia contraccolpo e infligge danni da fuoco in attacco";
												}
												break;
											}
											break;
										}
									}
									else
									{
										switch (l)
										{
										case 1430:
											return "Destinati alla costruzione di armi fiaschi imbuement";
										case 1431:
											break;
										case 1432:
											return "Destinati alla costruzione di vari tipi di munizioni";
										default:
											switch (l)
											{
											case 1444:
												return "Crea un fascio di ombra che rimbalza muri";
											case 1445:
												return "Lancia una palla di fuoco che esplode in un calore infernale";
											case 1446:
												return "Evoca un anima persa per inseguire i nemici";
											case 1447:
											case 1448:
												break;
											case 1449:
												return "soffia bolle";
											case 1450:
												return "soffia bolle";
											default:
												switch (l)
												{
												case 1503:
													return "Aumenta mana massimo da 80 e riduce l'uso di mana del 17%";
												case 1504:
													return "7% maggiore danno magico e la possibilità di critico";
												case 1505:
													return "8% in più di danno magico";
												case 1513:
													return "Un potente martello di ritorno";
												case 1515:
													return "Permette di volo e la caduta lenta";
												case 1522:
													return "Per catturare la gemma. Che rilascia quando si muore";
												case 1523:
													return "Per catturare la gemma. Che rilascia quando si muore";
												case 1524:
													return "Per catturare la gemma. Che rilascia quando si muore";
												case 1525:
													return "Per catturare la gemma. Che rilascia quando si muore";
												case 1526:
													return "Per catturare la gemma. Che rilascia quando si muore";
												case 1527:
													return "Per catturare la gemma. Che rilascia quando si muore";
												case 1533:
													return "Sblocca una giungla Busto nel dungeon";
												case 1534:
													return "Sblocca un Petto corruzione nel dungeon";
												case 1535:
													return "Sblocca un Petto Crimson nel dungeon";
												case 1536:
													return "Sblocca un Petto santificato nel dungeon";
												case 1537:
													return "Sblocca un Petto congelato nel dungeon";
												case 1543:
													return "Usato con vernice a blocchi di colore";
												case 1544:
													return "Usato con la vernice per pareti di colore";
												case 1545:
													return "Usato per rimuovere la vernice";
												case 1546:
													return "15% in più di danno freccia";
												case 1547:
													return "15% in più di danno proiettile";
												case 1548:
													return "15% in più di danno razzo";
												case 1549:
													return "Il 13% ha aumentato spaziato possibilità di critico";
												case 1550:
													return "Il 13% ha aumentato spaziato possibilità di critico";
												case 1551:
													return "Converte Bar Chlorophyte in bar Shroomite";
												case 1553:
													return "50% di possibilità di non consumare munizioni";
												case 1554:
													return "Non si dovrebbe avere questo";
												case 1555:
													return "Non si dovrebbe avere questo";
												case 1556:
													return "Non si dovrebbe avere questo";
												case 1557:
													return "Non si dovrebbe avere questo";
												case 1558:
													return "Non si dovrebbe avere questo";
												case 1559:
													return "Non si dovrebbe avere questo";
												case 1560:
													return "Non si dovrebbe avere questo";
												case 1561:
													return "Non si dovrebbe avere questo";
												case 1562:
													return "Non si dovrebbe avere questo";
												case 1563:
													return "Non si dovrebbe avere questo";
												case 1564:
													return "Non si dovrebbe avere questo";
												case 1565:
													return "Non si dovrebbe avere questo";
												case 1566:
													return "Non si dovrebbe avere questo";
												case 1567:
													return "Non si dovrebbe avere questo";
												case 1568:
													return "Non si dovrebbe avere questo";
												case 1569:
													return "Rapidamente gettare vita pugnali rubare";
												case 1571:
													return "Un potente Javalin che scatena piccolo mangiatori";
												case 1572:
													return "Evoca un potente gelo idra a sputare ghiaccio ai nemici";
												case 1578:
													return "Stampa le api e la velocità aumenta il movimento, se danneggiato";
												case 1579:
													return "Chi lo indossa può correre super veloce";
												case 1580:
													return "Non si dovrebbe avere questo";
												case 1581:
													return "Non si dovrebbe avere questo";
												case 1582:
													return "Non si dovrebbe avere questo";
												case 1583:
													return "Non si dovrebbe avere questo";
												case 1584:
													return "Non si dovrebbe avere questo";
												case 1585:
													return "Non si dovrebbe avere questo";
												case 1586:
													return "Non si dovrebbe avere questo";
												case 1587:
													return "Non si dovrebbe avere questo";
												case 1588:
													return "Non si dovrebbe avere questo";
												case 1595:
													return "Aumenta mana massimo del 20";
												}
												break;
											}
											break;
										}
									}
								}
							}
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							if (l <= 332)
							{
								if (l <= 128)
								{
									if (l <= 36)
									{
										if (l <= 8)
										{
											if (l == -1)
											{
												return "Permet d'extraire la météorite";
											}
											if (l == 8)
											{
												return "Procure de la lumière";
											}
										}
										else
										{
											switch (l)
											{
											case 15:
												return "Donne l'heure";
											case 16:
												return "Donne l'heure";
											case 17:
												return "Donne l'heure";
											case 18:
												return "Mesure l'altitude";
											case 19:
											case 20:
											case 21:
											case 22:
												break;
											case 23:
												return "'À la fois savoureux et inflammable'";
											default:
												if (l == 29)
												{
													return "Augmente le maximum de vie de 20 de façon permanente";
												}
												switch (l)
												{
												case 33:
													return "Utilisé pour fondre le minerai";
												case 35:
													return "Permet de forger des objets à partir de métal";
												case 36:
													return "Utilisé pour l'artisanat de base";
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 75)
										{
											if (l == 43)
											{
												return "Invoque l'œil de Cthulhu";
											}
											switch (l)
											{
											case 49:
												return "Régénère lentement la vie";
											case 50:
												return "Fixer le miroir pour regagner son foyer";
											case 51:
											case 52:
											case 55:
											case 58:
											case 59:
											case 60:
											case 61:
											case 62:
											case 63:
											case 69:
												break;
											case 53:
												return "Permet de faire un double saut";
											case 54:
												return "Le porteur peur courir super vite";
											case 56:
												return "'Vibre d'une énergie sombre'";
											case 57:
												return "'Vibre d'une énergie sombre'";
											case 64:
												return "Invoque une vileronce";
											case 65:
												return "Provoque une pluie d'étoiles";
											case 66:
												return "Purifie la corruption";
											case 67:
												return "Corrompt la sainteté";
											case 68:
												return "'Ça a l'air bon !'";
											case 70:
												return "Invoque le dévoreur de mondes";
											default:
												if (l == 75)
												{
													return "Disparaît au coucher du soleil";
												}
												break;
											}
										}
										else
										{
											if (l == 84)
											{
												return "'Pour grimper tout là-haut'";
											}
											if (l == 88)
											{
												return "Procure de la lumière lorsqu'il est porté";
											}
											switch (l)
											{
											case 98:
												return "33 % de chance de n'utiliser aucune munition";
											case 100:
												return "Vitesse de mêlée augmentée de 7 %";
											case 101:
												return "Vitesse de mêlée augmentée de 7 %";
											case 102:
												return "Vitesse de mêlée augmentée de 7 %";
											case 103:
												return "Permet d'extraire de la pierre de l'enfer";
											case 109:
												return "Augmente le maximum de mana de 20 de façon permanente";
											case 111:
												return "Augmente le maximum de mana de 20";
											case 112:
												return "Lance des boules de feu";
											case 113:
												return "Lance un missile contrôlable";
											case 114:
												return "Déplace la terre par magie";
											case 115:
												return "Crée un orbe magique de lumière";
											case 117:
												return "'Chaude au toucher'";
											case 118:
												return "Trouvé parfois sur les squelettes et les piranhas";
											case 120:
												return "Transforme les flèches en bois tirées en flèches enflammées";
											case 121:
												return "'Elle pète le feu !'";
											case 123:
												return "Dégâts magiques accrus de 5 %";
											case 124:
												return "Dégâts magiques accrus de 5 %";
											case 125:
												return "Dégâts magiques accrus de 5 %";
											case 128:
												return "Permet de voler";
											}
										}
									}
								}
								else
								{
									if (l <= 218)
									{
										if (l <= 187)
										{
											switch (l)
											{
											case 148:
												return "Cet objet peut attirer une attention non désirée";
											case 149:
												return "'Il contient d'étranges symboles'";
											case 150:
											case 154:
											case 155:
											case 160:
											case 161:
											case 162:
											case 163:
											case 164:
												break;
											case 151:
												return "Dégâts à distance augmentés de 4 %";
											case 152:
												return "Dégâts à distance augmentés de 4 %";
											case 153:
												return "Dégâts à distance augmentés de 4 %";
											case 156:
												return "Annule tout effet de recul";
											case 157:
												return "Lance de l'eau en continu";
											case 158:
												return "Annule les dégâts de chute";
											case 159:
												return "Augmente la hauteur des sauts";
											case 165:
												return "Invoque une boule d'eau se déplaçant lentement";
											case 166:
												return "Une petite explosion détruisant quelques blocs";
											case 167:
												return "Une grosse explosion détruisant la plupart des blocs";
											case 168:
												return "Une petite explosion ne détruisant pas de blocs";
											default:
												if (l == 175)
												{
													return "'Chaud au toucher'";
												}
												switch (l)
												{
												case 186:
													return "'Ne pas se noyer, c'est quand même cool !'";
												case 187:
													return "Permet de nager";
												}
												break;
											}
										}
										else
										{
											if (l == 193)
											{
												return "Permet de résister aux blocs de feu";
											}
											if (l == 197)
											{
												return "Tire des étoiles filantes";
											}
											switch (l)
											{
											case 208:
												return "'Comme c'est joli !'";
											case 211:
												return "La vitesse de mêlée est augmentée de 12 %";
											case 212:
												return "La vitesse de déplacement est augmentée de 10 %";
											case 213:
												return "Fait pousser de l'herbe sur la terre";
											case 215:
												return "'Peut être incommodant'";
											case 218:
												return "Invoque une boule de feu contrôlable";
											}
										}
									}
									else
									{
										if (l <= 305)
										{
											switch (l)
											{
											case 222:
												return "Fait pousser les plantes";
											case 223:
												return "Réduit le coût de mana de 6 %";
											case 224:
											case 225:
											case 226:
											case 227:
												break;
											case 228:
												return "Augmente le maximum de mana de 20";
											case 229:
												return "Augmente le maximum de mana de 20";
											case 230:
												return "Augmente le maximum de mana de 20";
											default:
												switch (l)
												{
												case 235:
													return "'Peut s'avérer difficile à lancer'";
												case 236:
													break;
												case 237:
													return "'Pour un look de star !'";
												case 238:
													return "Augmente les dégâts magiques de 15 %";
												default:
													switch (l)
													{
													case 261:
														return "'Il sourit, ça ferait un casse-croûte sympa.'";
													case 266:
														return "'Super idée !'";
													case 267:
														return "'Vous êtes vraiment terrible.'";
													case 268:
														return "Améliore grandement la respiration sous l'eau";
													case 272:
														return "Lance une faux de démon";
													case 281:
														return "Permet de récupérer des graines comme munitions";
													case 282:
														return "Fonctionne même humide";
													case 283:
														return "Utilisable avec la sarbacane";
													case 285:
														return "La vitesse de déplacement est augmentée de 5 %";
													case 288:
														return "Procure l'immunité à la lave";
													case 289:
														return "Régénère la vie";
													case 290:
														return "Augmente la vitesse de déplacement de 25 %";
													case 291:
														return "Permet de respirer sous l'eau comme dans l'air";
													case 292:
														return "Augmente la défense de 8";
													case 293:
														return "Augmente la régénération de mana";
													case 294:
														return "Augmente les dégâts de magie de 20 %";
													case 295:
														return "Réduit la vitesse de chute";
													case 296:
														return "Indique l'emplacement des trésors et du minerai";
													case 297:
														return "Procure l'invisibilité";
													case 298:
														return "Émet une aura de lumière";
													case 299:
														return "Augmente la vision nocturne";
													case 300:
														return "Augmente la fréquence d'apparition des ennemis";
													case 301:
														return "Les attaquants subissent aussi des dégâts";
													case 302:
														return "Permet de marcher sur l'eau";
													case 303:
														return "La vitesse des flèches et leurs dégâts sont augmentés de 20 %";
													case 304:
														return "Indique l'emplacement des ennemis";
													case 305:
														return "Permet de contrôler la gravité";
													}
													break;
												}
												break;
											}
										}
										else
										{
											if (l == 324)
											{
												return "'Interdit quasiment partout'";
											}
											switch (l)
											{
											case 327:
												return "Ouvre un coffre d'or";
											case 328:
												break;
											case 329:
												return "Ouvre tous les coffres sombres";
											default:
												if (l == 332)
												{
													return "Utilisé pour la fabrication de vêtements";
												}
												break;
											}
										}
									}
								}
							}
							else
							{
								if (l <= 726)
								{
									if (l <= 603)
									{
										if (l <= 407)
										{
											if (l == 352)
											{
												return "Utilisé pour brasser la bière.";
											}
											switch (l)
											{
											case 357:
												return "Amélioration mineure de toutes les stats.";
											case 361:
												return "Invoque une armée de gobelins";
											case 363:
												return "Permet un travail avancé du bois";
											case 367:
												return "Suffisamment puissant pour détruire les autels démoniaques";
											case 371:
												return "Augmente le maximum de mana de 40";
											case 372:
												return "La vitesse de déplacement est augmentée de 7 %";
											case 373:
												return "Les dégâts à distance sont augmentés de 10 %";
											case 376:
												return "Augmente le maximum de mana de 60";
											case 377:
												return "Les chances de coup critique de mêler sont augmentées de 5 %";
											case 378:
												return "Les dégâts à distance sont augmentés de 12 %";
											case 385:
												return "Permet d'extraire du mythril";
											case 386:
												return "Permet d'extraire de l'adamantine";
											case 389:
												return "Peut étourdir les ennemis";
											case 393:
												return "Indique la position horizontale";
											case 394:
												return "Permet de nager";
											case 395:
												return "Indique la position";
											case 396:
												return "Annule les dégâts de chute";
											case 397:
												return "Annule tout effet de recul";
											case 398:
												return "Permet de combiner certains accessoires";
											case 399:
												return "Permet de faire un double saut";
											case 400:
												return "Augmente le maximum de mana de 80";
											case 401:
												return "Les chances de coup critique de mêlée sont augmentées de 7 %";
											case 402:
												return "Les dégâts à distance sont augmentés de 14 %";
											case 403:
												return "Les dégâts sont augmentés de 6 %";
											case 404:
												return "Les chances de coup critique sont augmentées de 4 %";
											case 405:
												return "Permet de voler";
											case 407:
												return "Permet de construire un bloc plus loin";
											}
										}
										else
										{
											switch (l)
											{
											case 422:
												return "Purifie certains blocs";
											case 423:
												return "Corrompt certains blocs";
											case 424:
												break;
											case 425:
												return "Invoque une fée magique";
											default:
												if (l == 434)
												{
													return "Tire des rafales de trois coups";
												}
												switch (l)
												{
												case 485:
													return "Transforme le porteur en loup-garou à la pleine lune";
												case 486:
													return "Crée une grille à l'écran pour le placement des blocs";
												case 489:
													return "Augmente les dégâts magiques de 15 %";
												case 490:
													return "Augmente les dégâts de mêlée de 15 %";
												case 491:
													return "Dégâts à distance augmentés de 15 %";
												case 492:
													return "Permet de voler et de ralentir la chute";
												case 493:
													return "Permet de voler et de ralentir la chute";
												case 495:
													return "Lance un arc-en-ciel contrôlable";
												case 496:
													return "Invoque un bloc de glace";
												case 497:
													return "Transforme le porteur en sirène lorsqu'il entre dans l'eau";
												case 506:
													return "Utilise du gel comme carburant";
												case 509:
													return "Joint les câbles";
												case 510:
													return "Coupe les câbles";
												case 515:
													return "Crée plusieurs éclats de cristal à l'impact";
												case 516:
													return "Invoque des étoiles déchues à l'impact";
												case 517:
													return "Une dague qui revient magiquement à son possesseur";
												case 518:
													return "Invoque des éclats rapides de cristal de feu";
												case 519:
													return "Invoque des boules de feu maudites";
												case 520:
													return "'L'essence des créatures de lumière'";
												case 521:
													return "'L'essence des créatures sombres'";
												case 522:
													return "'Même l'eau ne peut l'éteindre'";
												case 523:
													return "Peut être placée dans l'eau";
												case 524:
													return "Utilisée pour fondre le minerai d'adamantine";
												case 525:
													return "Utilisée pour forger des objets avec du mythril et de l'adamantite";
												case 526:
													return "'Magique et coupante'";
												case 527:
													return "'Porté parfois par les créatures dans le désert corrompu'";
												case 528:
													return "'Porté parfois par les créatures dans le désert de lumière'";
												case 529:
													return "S'active en marchant dessus";
												case 531:
													return "Peut être enchanté";
												case 532:
													return "Des étoiles tombent lorsque le porteur est blessé";
												case 533:
													return "50 % de chance de n'utiliser aucune munition";
												case 534:
													return "Disperse une salve de balles";
												case 535:
													return "Réduit le temps d'utilisation entre les potions de soin";
												case 536:
													return "Accroît le recul en mêlée";
												case 541:
													return "S'active en marchant dessus";
												case 542:
													return "S'active en marchant dessus";
												case 543:
													return "S'active en marchant dessus";
												case 544:
													return "Invoque les jumeaux";
												case 547:
													return "'L'essence de la terreur pure'";
												case 548:
													return "'L'essence du destructeur'";
												case 549:
													return "'L'essence des observateurs omniscients'";
												case 551:
													return "Augmente les chances de coup critique de 7 %";
												case 552:
													return "Dégâts augmentés de 7 %";
												case 553:
													return "Dégâts à distance augmentés de 15 %";
												case 554:
													return "Augmente la durée d'invincibilité après avoir subi des dégâts";
												case 555:
													return "Utilisation de mana réduite de 8 %";
												case 556:
													return "Invoque l'destructeur";
												case 557:
													return "Invoque le squeletron primaire";
												case 558:
													return "Augmente le maximum de mana de 100";
												case 559:
													return "Les chances de coup critique et les dégâts de mêlée sont augmentés de 10 %";
												case 560:
													return "Invoque le roi slime";
												case 561:
													return "Possibilité d'en lancer jusqu'à 5";
												case 575:
													return "'L'essence des puissantes créatures volantes'";
												case 576:
													return "A une chance d'enregistrer un morceau";
												case 579:
													return "'À ne pas confondre avec le marteau-scie'";
												case 580:
													return "Explosent lorsqu'ils sont activés";
												case 581:
													return "Envoie de l'eau aux sorties de pompage";
												case 582:
													return "Reçoit de l'eau des postes de pompage";
												case 583:
													return "S'active chaque seconde";
												case 584:
													return "S'active toutes les 3 secondes";
												case 585:
													return "S'active toutes les 5 secondes";
												case 599:
													return "Faites un clic droit pour ouvrir";
												case 600:
													return "Faites un clic droit pour ouvrir";
												case 601:
													return "Faites un clic droit pour ouvrir";
												case 602:
													return "Invoque la Légion gel";
												case 603:
													return "Convocation d'un lapin de compagnie";
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 686)
										{
											switch (l)
											{
											case 665:
												return "Vous ne devriez pas avoir cette";
											case 666:
												return "Vous ne devriez pas avoir cette";
											case 667:
												return "Vous ne devriez pas avoir cette";
											case 668:
												return "Vous ne devriez pas avoir cette";
											case 669:
												return "Invoque un bébé pingouin";
											default:
												if (l == 676)
												{
													return "Tire sur un boulon de glace";
												}
												switch (l)
												{
												case 683:
													return "Invoque trident du diable";
												case 684:
													return "16% ont augmenté mêlée et à distance des dégâts";
												case 685:
													return "11% ont augmenté mêlée et à distance chances de coup critique";
												case 686:
													return "8% a augmenté la vitesse de déplacement";
												}
												break;
											}
										}
										else
										{
											switch (l)
											{
											case 707:
												return "Indique le temps";
											case 708:
												return "Indique le temps";
											case 709:
												return "Indique le temps";
											default:
												if (l == 716)
												{
													return "Utilisé pour des objets d'artisanat à partir de barres de métal";
												}
												switch (l)
												{
												case 723:
													return "Tire un faisceau de lumière";
												case 724:
													return "Tire sur un boulon de glace";
												case 725:
													return "Lance gel flèches";
												case 726:
													return "De prendre un flux de gel";
												}
												break;
											}
										}
									}
								}
								else
								{
									if (l <= 832)
									{
										if (l <= 761)
										{
											switch (l)
											{
											case 748:
												return "Permet de vol et de chute lente";
											case 749:
												return "Permet de vol et de chute lente";
											default:
												if (l == 753)
												{
													return "Summons a pet turtle";
												}
												if (l == 761)
												{
													return "Permet de vol et de chute lente";
												}
												break;
											}
										}
										else
										{
											switch (l)
											{
											case 779:
												return "Crée et détruit biomes lors de la pulvérisation";
											case 780:
												return "Utilisé par le Clentaminator";
											case 781:
												return "Utilisé par le Clentaminator";
											case 782:
												return "Utilisé par le Clentaminator";
											case 783:
												return "Utilisé par le Clentaminator";
											case 784:
												return "Utilisé par le Clentaminator";
											case 785:
												return "Permet de vol et de chute lente";
											case 786:
												return "Permet de vol et de chute lente";
											case 787:
												return "Assez fort pour détruire les autels de démon";
											case 788:
												return "Invoque une lance d'épines";
											case 789:
											case 790:
											case 791:
											case 795:
											case 796:
											case 797:
												break;
											case 792:
												return "2% de dégâts";
											case 793:
												return "2% de dégâts";
											case 794:
												return "2% de dégâts";
											case 798:
												return "Capable d'exploiter Hellstone";
											default:
												switch (l)
												{
												case 821:
													return "Permet de vol et de chute lente";
												case 822:
													return "Permet de vol et de chute lente";
												case 823:
													return "Permet de vol et de chute lente";
												default:
													if (l == 832)
													{
														return "Places bois vivant";
													}
													break;
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 1343)
										{
											switch (l)
											{
											case 849:
												return "Permet blocs solides pour être activée ou désactivée";
											case 850:
												return "Places fil bleu";
											case 851:
												return "Places fil vert";
											case 852:
												return "Active quand un joueur marche sur-le";
											case 853:
												return "Active quand quelque chose mais un joueur marche dessus sur";
											case 854:
												return "Magasins ont des prix plus bas";
											case 855:
												return "Ennemis frappeurs parfois tomber des pièces supplémentaires";
											case 856:
												return "'Avoir un temps merveilleux!'";
											case 857:
												return "Permet à son détenteur de faire un meilleur saut double";
											case 858:
											case 859:
											case 864:
											case 865:
											case 866:
											case 867:
											case 868:
											case 869:
											case 870:
											case 871:
											case 872:
											case 873:
											case 874:
											case 875:
											case 876:
											case 877:
											case 878:
											case 879:
											case 880:
											case 881:
											case 882:
											case 883:
											case 884:
											case 894:
											case 895:
											case 896:
											case 909:
											case 910:
											case 911:
											case 912:
											case 913:
											case 914:
											case 915:
											case 916:
											case 917:
											case 918:
											case 919:
											case 920:
											case 921:
											case 922:
											case 923:
											case 924:
											case 925:
											case 926:
											case 927:
											case 928:
											case 929:
											case 930:
											case 931:
											case 939:
											case 940:
											case 941:
											case 942:
											case 943:
											case 944:
											case 945:
											case 949:
											case 952:
											case 954:
											case 955:
											case 970:
											case 971:
											case 972:
											case 973:
											case 974:
											case 978:
											case 979:
											case 980:
											case 981:
											case 988:
											case 991:
											case 992:
											case 993:
											case 999:
												break;
											case 860:
												return "Fournit la régénération de vie et réduit le temps de recharge de potions de guérison";
											case 861:
												return "Active le support en loup-garou la nuit et un merfolk lors de l'entrée d'eau";
											case 862:
												return "Provoque étoiles à tomber et augmente la longueur d'invincibilité après prendre des dommages";
											case 863:
												return "Offre la possibilité de marcher sur l'eau";
											case 885:
												return "immunité aux saignements";
											case 886:
												return "immunité à l'armure brisée";
											case 887:
												return "immunité au poison";
											case 888:
												return "immunité à l'obscurité";
											case 889:
												return "immunité à ralentir";
											case 890:
												return "immunité au silence";
											case 891:
												return "l'immunité de maudire";
											case 892:
												return "l'immunité à la faiblesse";
											case 893:
												return "immunité à confusion";
											case 897:
												return "Augmente repoussement de mêlée";
											case 898:
												return "permet vol";
											case 899:
												return "Augmente tous les stats si usé pendant le jour";
											case 900:
												return "Augmente tous les stats si usé pendant la nuit";
											case 901:
												return "Immunité de la faiblesse et de l'armure brisée";
											case 902:
												return "Immunité au poison et des saignements";
											case 903:
												return "Immunité à ralentir et confusion";
											case 904:
												return "Immunité au silence et ne maudissez";
											case 905:
												return "Utilise des pièces de munitions";
											case 906:
												return "Fournit de 7 secondes d'immunité aux lave";
											case 907:
												return "Offre la possibilité de marcher sur l'eau";
											case 908:
												return "Offre la possibilité de marcher sur l'eau et la lave";
											case 932:
												return "places os";
											case 933:
												return "places laisse";
											case 934:
												return "Permet au propriétaire de flotter pendant quelques secondes";
											case 935:
												return "12% de dégâts";
											case 936:
												return "Augmente repoussement de mêlée";
											case 937:
												return "Explose quand on marche dessus";
											case 938:
												return "Absorbe 25% des dégâts infligés aux joueurs de votre équipe";
											case 946:
												return "Vous allez tomber lentement tout en maintenant cette";
											case 947:
												return "Réagit à la lumière";
											case 948:
												return "Permet de vol et de chute lente";
											case 950:
												return "Fournit la mobilité supplémentaire sur la glace";
											case 951:
												return "Lance rapidement des boules de neige";
											case 953:
												return "Permet la possibilité de glisser le long des murs";
											case 956:
												return "7% ont augmenté la vitesse de mêlée";
											case 957:
												return "7% ont augmenté la vitesse de mêlée";
											case 958:
												return "7% ont augmenté la vitesse de mêlée";
											case 959:
												return "4% ont augmenté les dégâts à distance.";
											case 960:
												return "Augmente mana maximum de 20";
											case 961:
												return "Augmente mana maximum de 20";
											case 962:
												return "Augmente mana maximum de 20";
											case 963:
												return "Donne une chance d'esquiver les attaques";
											case 964:
												return "Lance une propagation de balles";
											case 965:
												return "Peut être monté sur";
											case 966:
												return "Régénération de vie est augmentée lorsque près d'un feu de camp";
											case 967:
												return "Mettez-le sur un bâton et rôti au feu de bois";
											case 968:
												return "Rôtir sur un feu de camp!";
											case 969:
												return "Améliorations mineures apportées à toutes les carac";
											case 975:
												return "Permet la possibilité de glisser le long des murs";
											case 976:
												return "Permet la possibilité d'escalader les murs";
											case 977:
												return "Permet la possibilité de se lancer";
											case 982:
												return "Augmente mana maximum de 20";
											case 983:
												return "Permet au titulaire de double saut";
											case 984:
												return "Permet la possibilité de grimper aux murs et tableau de bord";
											case 985:
												return "Jeter de créer une ligne de corde climbable";
											case 986:
												return "Permet la collecte de semences pour munitions";
											case 987:
												return "Permet au titulaire de double saut";
											case 989:
												return "Tire un faisceau d'épée enchantée";
											case 990:
												return "'A ne pas confondre avec un hamdrill'";
											case 994:
												return "Invoque un mangeur de bébé des âmes";
											case 995:
												return "Utilisé pour fabriquer des objets";
											case 996:
												return "Utilisé pour fabriquer des objets";
											case 997:
												return "Met limon et de boue en quelque chose de plus utile";
											case 998:
												return "Utilisé pour fabriquer des objets";
											case 1000:
												return "Lance confettis partout!";
											case 1001:
												return "16% ont augmenté les dégâts de mêlée";
											case 1002:
												return "16% ont augmenté les dégâts à distance";
											case 1003:
												return "Augmente mana maximum de 80 et réduit la consommation de mana de 17%";
											case 1004:
												return "5% de dégâts";
											case 1005:
												return "8% ont augmenté les chances de coup critique";
											case 1006:
												return "Réagit à la lumière";
											default:
												switch (l)
												{
												case 1071:
													return "Utilisé avec de la peinture à blocs de couleur";
												case 1072:
													return "Utilisé avec de la peinture sur les murs de couleur";
												default:
													switch (l)
													{
													case 1100:
														return "Utilisé pour enlever la peinture";
													case 1107:
														return "Utilisé pour faire colorant bleu sarcelle";
													case 1108:
														return "Utilisé pour faire colorant vert";
													case 1109:
														return "Utilisé pour faire colorant bleu ciel";
													case 1110:
														return "Utilisé pour faire colorant jaune";
													case 1111:
														return "Utilisé pour faire colorant bleu";
													case 1112:
														return "Utilisé pour fabriquer des colorants chaux";
													case 1113:
														return "Utilisé pour faire colorant rose";
													case 1114:
														return "Utilisé pour faire colorant d'orange";
													case 1115:
														return "Utilisé pour faire colorant rouge";
													case 1116:
														return "Utilisé pour faire colorant cyan";
													case 1117:
														return "Utilisé pour fabriquer la teinture violette";
													case 1118:
														return "Utilisé pour faire colorant violet";
													case 1119:
														return "Utilisé pour faire colorant noir";
													case 1120:
														return "Utilisé pour fabriquer des colorants";
													case 1121:
														return "Shoots abeilles qui vont chasser vos ennemis";
													case 1122:
														return "Poursuites après votre ennemi";
													case 1123:
														return "Invoque abeilles tueuses après avoir frappé votre ennemi";
													case 1129:
														return "Places urticaire";
													case 1130:
														return "Explose en un essaim d'abeilles";
													case 1131:
														return "Permet à son titulaire d'inverser la gravité";
													case 1132:
														return "Libère les abeilles lorsqu'elles sont endommagées";
													case 1133:
														return "Invoque le Queen Bee";
													case 1141:
														return "Ouvre la porte du temple de la jungle";
													case 1145:
														return "Utilisé pour l'artisanat de base";
													case 1151:
														return "Active quand un joueur marche sur-le";
													case 1156:
														return "Loquets situés sur les ennemis pour les dommages continu";
													case 1157:
														return "Invoque un pygmée à se battre pour vous";
													case 1158:
														return "Augmente votre nombre maximum de sous-fifres";
													case 1159:
														return "Augmente votre nombre maximum de sous-fifres";
													case 1160:
														return "Augmente votre nombre maximum de sous-fifres";
													case 1161:
														return "Augmente votre nombre maximum de sous-fifres";
													case 1162:
														return "Permet de vol et de chute lente";
													case 1163:
														return "Permet au titulaire de double saut";
													case 1164:
														return "Permet au titulaire de quadruple saut";
													case 1165:
														return "Permet de vol et de chute lente";
													case 1167:
														return "Augmente les dégâts de vos sbires d'ici le 15";
													case 1169:
														return "Invoque un bébé Skeletron tête";
													case 1170:
														return "Invoque un Hornet bébé";
													case 1171:
														return "Invoque un esprit de Tiki";
													case 1172:
														return "Invoque un lézard de compagnie";
													case 1178:
														return "Pousses rapidement feuilles acérées";
													case 1179:
														return "Chases after your enemy";
													case 1180:
														return "Invoque un perroquet";
													case 1181:
														return "Invoque un Truffle bébé";
													case 1182:
														return "Invoque un jeune arbre Pet";
													case 1183:
														return "Invoque un Wisp pour fournir la lumière";
													case 1188:
														return "Peut-mines de mithril, orichalque, adamantite et Titane";
													case 1189:
														return "Peut-mines de mithril, orichalque, adamantite et Titane";
													case 1195:
														return "Peut mien adamantite et Titane";
													case 1196:
														return "Peut mien adamantite et Titane";
													case 1205:
														return "8% ont augmenté les dégâts de mêlée";
													case 1206:
														return "9% ont augmenté les dégâts à distance";
													case 1207:
														return "7% d'augmentation des dégâts magiques et les chances de coup critique";
													case 1208:
														return "3% de dégâts";
													case 1209:
														return "2% de dégâts";
													case 1210:
														return "7% ont augmenté les dégâts de mêlée";
													case 1211:
														return "15% ont augmenté varié chances de coup critique";
													case 1212:
														return "18% ont augmenté magie chances de coup critique";
													case 1213:
														return "6% ont augmenté les chances de coup critique";
													case 1214:
														return "11% augmente la vitesse de déplacement";
													case 1215:
														return "8% de dégâts au corps à corps et les chances de coup critique";
													case 1216:
														return "16% ont augmenté les dégâts à distance";
													case 1217:
														return "16% d'augmentation des dégâts magiques et 7% ont augmenté magie chances de coup critique";
													case 1218:
														return "4% de dégâts";
													case 1219:
														return "3% de dégâts et les chances de coup critique";
													case 1220:
														return "Utilisé pour fabriquer des objets à partir de mithril, orichalque, adamantite, et des barres de titane";
													case 1221:
														return "Utilisé pour adamante éperlan et du minerai de titane";
													case 1226:
														return "Tire un puissant orbe";
													case 1227:
														return "Tire un nuage de spores";
													case 1228:
														return "Tire un nuage de spores";
													case 1235:
														return "Rebondit après avoir heurté un mur";
													case 1242:
														return "Invoque un bébé dinosaure";
													case 1244:
														return "Invoque un nuage à pleuvoir sur vos ennemis";
													case 1247:
														return "Provoque étoiles à tomber et libère les abeilles quand blessés";
													case 1248:
														return "10% ont augmenté les chances de coup critique";
													case 1249:
														return "Augmente la hauteur de saut";
													case 1250:
														return "Permet au titulaire de double saut";
													case 1251:
														return "Permet au titulaire de double saut";
													case 1252:
														return "Permet au titulaire de double saut";
													case 1253:
														return "Met une coquille autour de la propriétaire quand la vie dessous de 25% qui réduit les dommages";
													case 1254:
														return "Tire une puissante balle à grande vitesse";
													case 1255:
														return "Tire une puissante balle à grande vitesse";
													case 1256:
														return "Invoque un nuage à pleuvoir du sang sur vos ennemis";
													case 1258:
														return "Tire un boulon explosif";
													case 1259:
														return "Pousses rasoir tranchant pétales de fleurs sur les ennemis proches";
													case 1260:
														return "Tire un arc en ciel qui fait des dégâts en continu";
													case 1261:
														return "Explose en éclats mortels";
													case 1264:
														return "Tire une boule de gel";
													case 1265:
														return "Tire une puissante balle à grande vitesse";
													case 1282:
														return "Augmente mana maximum de 20";
													case 1283:
														return "Augmente mana maximum de 40";
													case 1284:
														return "Augmente mana maximum de 40";
													case 1285:
														return "Augmente mana maximum de 60";
													case 1286:
														return "Augmente mana maximum de 60";
													case 1287:
														return "Augmente mana maximum de 80";
													case 1290:
														return "Augmente la vitesse de déplacement après avoir été frappé";
													case 1291:
														return "Augmente en permanence durée de vie maximale de 5";
													case 1293:
														return "Utilisé à l'autel Lihzahrd";
													case 1294:
														return "Capable de mines Lihzahrd briques";
													case 1295:
														return "Tire un rayon perçant de chaleur";
													case 1296:
														return "Invoque un puissant rocher";
													case 1297:
														return "Coups de poing avec la force d'un golem";
													case 1299:
														return "Augmente visualiser gamme lorsqu'il est maintenu";
													case 1300:
														return "Augmente Afficher la gamme des pistolets";
													case 1301:
														return "10% de dégâts";
													case 1303:
														return "Fournit de la lumière sous l'eau";
													case 1306:
														return "Tire une faucille glacial";
													case 1307:
														return "'Vous êtes une personne épouvantable'";
													case 1308:
														return "Tire un poison croc qui perce plusieurs ennemis";
													case 1309:
														return "Invoque un bébé bave à se battre pour vous";
													case 1310:
														return "Inflige poison sur les ennemis";
													case 1311:
														return "Invoque un ressort de globe oculaire";
													case 1312:
														return "Invoque un bébé bonhomme de neige";
													case 1313:
														return "Tire un crâne";
													case 1314:
														return "Tire un gant de boxe";
													case 1315:
														return "Invoque une invasion de pirates";
													case 1316:
														return "6% ont augmenté les dégâts de mêlée";
													case 1317:
														return "8% de dégâts au corps à corps et les chances de coup critique";
													case 1318:
														return "4% ont augmenté mêlée chances de coup critique";
													case 1321:
														return "Augmenter la vitesse de flèche et les dommages de 10%";
													case 1322:
														return "Inflige des dégâts de feu sur l'attaque";
													case 1323:
														return "Réduit les dégâts de toucher lave";
													case 1326:
														return "Téléports à la position de la souris";
													case 1327:
														return "Tire une faucille mort";
													case 1331:
														return "Invoque le cerveau de Cthulhu";
													case 1332:
														return "'Le sang des dieux'";
													case 1333:
														return "Peut être placé dans l'eau";
													case 1334:
														return "Diminue la défense de la cible";
													case 1335:
														return "Diminue la défense de la cible";
													case 1336:
														return "Sprays une pluie de ichor";
													case 1343:
														return "Augmente la mêlée repoussement et inflige des dégâts de feu sur l'attaque";
													}
													break;
												}
												break;
											}
										}
										else
										{
											switch (l)
											{
											case 1430:
												return "Utilisé pour fabriquer des flacons de imbuement d'armes";
											case 1431:
												break;
											case 1432:
												return "Utilisé pour fabriquer différents types de munitions";
											default:
												switch (l)
												{
												case 1444:
													return "Crée un faisceau d'ombre qui rebondit sur les murs";
												case 1445:
													return "Lance une boule de feu qui explose dans un brasier";
												case 1446:
													return "Invoque une âme perdue pour chasser vos ennemis";
												case 1447:
												case 1448:
													break;
												case 1449:
													return "souffle des bulles";
												case 1450:
													return "souffle des bulles";
												default:
													switch (l)
													{
													case 1503:
														return "Augmente mana maximum de 80 et réduit la consommation de mana de 17%";
													case 1504:
														return "7% d'augmentation des dégâts magiques et les chances de coup critique";
													case 1505:
														return "8% d'augmentation des dégâts magiques";
													case 1513:
														return "Un marteau retour puissant";
													case 1515:
														return "Permet de vol et de chute lente";
													case 1522:
														return "Pour capturer le Gem. Il tombe quand vous mourrez";
													case 1523:
														return "Pour capturer le Gem. Il tombe quand vous mourrez";
													case 1524:
														return "Pour capturer le Gem. Il tombe quand vous mourrez";
													case 1525:
														return "Pour capturer le Gem. Il tombe quand vous mourrez";
													case 1526:
														return "Pour capturer le Gem. Il tombe quand vous mourrez";
													case 1527:
														return "Pour capturer le Gem. Il tombe quand vous mourrez";
													case 1533:
														return "Débloque une jungle poitrine dans le donjon";
													case 1534:
														return "Débloque un coffre de la corruption dans le donjon";
													case 1535:
														return "Débloque un coffre Crimson dans le donjon";
													case 1536:
														return "Débloque un coffre sanctifié dans le donjon";
													case 1537:
														return "Débloque un coffre congelés dans le donjon";
													case 1543:
														return "Utilisé avec de la peinture à blocs de couleur";
													case 1544:
														return "Utilisé avec de la peinture sur les murs de couleur";
													case 1545:
														return "Utilisé pour enlever la peinture";
													case 1546:
														return "15% de dégâts supplémentaires flèche";
													case 1547:
														return "15% de dégâts supplémentaires infligés par balle";
													case 1548:
														return "15% de dégâts supplémentaires fusée";
													case 1549:
														return "13% ont augmenté varié chances de coup critique";
													case 1550:
														return "7% ont augmenté varié chances de coup critique";
													case 1551:
														return "Convertit Bars Bars chlorophyte en Shroomite";
													case 1553:
														return "50% de chances de ne pas consommer de munitions";
													case 1554:
														return "Vous ne devriez pas avoir cette";
													case 1555:
														return "Vous ne devriez pas avoir cette";
													case 1556:
														return "Vous ne devriez pas avoir cette";
													case 1557:
														return "Vous ne devriez pas avoir cette";
													case 1558:
														return "Vous ne devriez pas avoir cette";
													case 1559:
														return "Vous ne devriez pas avoir cette";
													case 1560:
														return "Vous ne devriez pas avoir cette";
													case 1561:
														return "Vous ne devriez pas avoir cette";
													case 1562:
														return "Vous ne devriez pas avoir cette";
													case 1563:
														return "Vous ne devriez pas avoir cette";
													case 1564:
														return "Vous ne devriez pas avoir cette";
													case 1565:
														return "Vous ne devriez pas avoir cette";
													case 1566:
														return "Vous ne devriez pas avoir cette";
													case 1567:
														return "Vous ne devriez pas avoir cette";
													case 1568:
														return "Vous ne devriez pas avoir cette";
													case 1569:
														return "Rapidement jeter des poignards qui volent de la vie";
													case 1571:
														return "A javalin puissant qui libère petit mangeurs";
													case 1572:
														return "Invoque un puissant gel hydre à cracher de la glace sur vos ennemis";
													case 1578:
														return "Communiqués abeilles et augmente la vitesse de déplacement lorsqu'il a été endommagé";
													case 1579:
														return "Le porteur peut fonctionner super rapide";
													case 1580:
														return "Vous ne devriez pas avoir cette";
													case 1581:
														return "Vous ne devriez pas avoir cette";
													case 1582:
														return "Vous ne devriez pas avoir cette";
													case 1583:
														return "Vous ne devriez pas avoir cette";
													case 1584:
														return "Vous ne devriez pas avoir cette";
													case 1585:
														return "Vous ne devriez pas avoir cette";
													case 1586:
														return "Vous ne devriez pas avoir cette";
													case 1587:
														return "Vous ne devriez pas avoir cette";
													case 1588:
														return "Vous ne devriez pas avoir cette";
													case 1595:
														return "Augmente mana maximum de 20";
													}
													break;
												}
												break;
											}
										}
									}
								}
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								if (l <= 332)
								{
									if (l <= 128)
									{
										if (l <= 36)
										{
											if (l <= 8)
											{
												if (l == -1)
												{
													return "Puede abrir meteoritos";
												}
												if (l == 8)
												{
													return "Da luz";
												}
											}
											else
											{
												switch (l)
												{
												case 15:
													return "Da la hora";
												case 16:
													return "Da la hora";
												case 17:
													return "Da la hora";
												case 18:
													return "indica la profundidad";
												case 19:
												case 20:
												case 21:
												case 22:
													break;
												case 23:
													return "'Repugnante a la vez que inflamable'";
												default:
													if (l == 29)
													{
														return "Aumenta al máximo la vida (20) de forma definitiva";
													}
													switch (l)
													{
													case 33:
														return "Se usa para fundir mineral";
													case 35:
														return "Se usa para fabricar objetos con lingotes de metal";
													case 36:
														return "Se usa para creaciones básicas";
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 75)
											{
												if (l == 43)
												{
													return "Invoca al Ojo de Cthulhu";
												}
												switch (l)
												{
												case 49:
													return "Regenera la vida poco a poco";
												case 50:
													return "Al mirarse en él se regresa al hogar";
												case 51:
												case 52:
												case 55:
												case 58:
												case 59:
												case 60:
												case 61:
												case 62:
												case 63:
												case 69:
													break;
												case 53:
													return "Su portador salta el doble";
												case 54:
													return "Permite correr superrápido";
												case 56:
													return "'Late de energía oscura'";
												case 57:
													return "'Late de energía oscura'";
												case 64:
													return "Lanza una espina vil";
												case 65:
													return "Hace que lluevan estrellas del cielo";
												case 66:
													return "Limpia la corrupción";
												case 67:
													return "Elimina la bendición";
												case 68:
													return "'¡Sabe asqueroso!'";
												case 70:
													return "Invoca al Devoramundos";
												default:
													if (l == 75)
													{
														return "Desaparece al amanecer";
													}
													break;
												}
											}
											else
											{
												if (l == 84)
												{
													return "'¡Te atrapé!'";
												}
												if (l == 88)
												{
													return "Da luz a su portador";
												}
												switch (l)
												{
												case 98:
													return "Probabilidad del 33% de no gastar munición";
												case 100:
													return "Aumenta un 7% la velocidad en el cuerpo a cuerpo";
												case 101:
													return "Aumenta un 7% la velocidad en el cuerpo a cuerpo";
												case 102:
													return "Aumenta un 7% la velocidad en el cuerpo a cuerpo";
												case 103:
													return "Puede abrir la piedra infernal";
												case 109:
													return "Aumenta al máximo el maná (20) de forma definitiva";
												case 111:
													return "Aumenta al máximo el maná (20)";
												case 112:
													return "Arroja bolas de fuego";
												case 113:
													return "Lanza un misil dirigido";
												case 114:
													return "Remueve la tierra por arte de magia";
												case 115:
													return "Crea un orbe mágico de luz";
												case 117:
													return "'Calienta la antorcha'";
												case 118:
													return "A veces lo sueltan esqueletos y pirañas";
												case 120:
													return "Enciende las flechas de madera";
												case 121:
													return "'¡Hecha de fuego!'";
												case 123:
													return "Aumenta el daño mágico en un 5%";
												case 124:
													return "Aumenta el daño mágico en un 5%";
												case 125:
													return "Aumenta el daño mágico en un 5%";
												case 128:
													return "Permite volar";
												}
											}
										}
									}
									else
									{
										if (l <= 218)
										{
											if (l <= 187)
											{
												switch (l)
												{
												case 148:
													return "Su portador llamará la atención de indeseables";
												case 149:
													return "'Contiene extraños símbolos'";
												case 150:
												case 154:
												case 155:
												case 160:
												case 161:
												case 162:
												case 163:
												case 164:
													break;
												case 151:
													return "Aumenta el daño a distancia en un 4%";
												case 152:
													return "Aumenta el daño a distancia en un 4%";
												case 153:
													return "Aumenta el daño a distancia en un 4%";
												case 156:
													return "Ofrece inmunidad ante el retroceso";
												case 157:
													return "Pulveriza un chorro de agua";
												case 158:
													return "Anula el daño al caer";
												case 159:
													return "Aumenta la altura al saltar";
												case 165:
													return "Lanza un rayo de agua a baja velocidad";
												case 166:
													return "Pequeña explosión que rompe varios ladrillos";
												case 167:
													return "Gran explosión que rompe casi todos los ladrillos";
												case 168:
													return "Pequeña explosión que no rompe ningún ladrillo";
												default:
													if (l == 175)
													{
														return "'Enciende la antorcha'";
													}
													switch (l)
													{
													case 186:
														return "'Está bien eso de no ahogarse'";
													case 187:
														return "Permite nadar";
													}
													break;
												}
											}
											else
											{
												if (l == 193)
												{
													return "Ofrece inmunidad ante los bloques de fuego";
												}
												if (l == 197)
												{
													return "Dispara estrellas caídas";
												}
												switch (l)
												{
												case 208:
													return "'Hermosa, muy hermosa'";
												case 211:
													return "Aumenta un 12% la velocidad en el cuerpo a cuerpo";
												case 212:
													return "Aumenta en un 10% la velocidad de movimiento";
												case 213:
													return "Genera césped sobre la tierra";
												case 215:
													return "'Una molestia para los demás'";
												case 218:
													return "Lanza una bola de fuego dirigida";
												}
											}
										}
										else
										{
											if (l <= 305)
											{
												switch (l)
												{
												case 222:
													return "Cultiva plantas";
												case 223:
													return "Reduce el uso de maná en un 6%";
												case 224:
												case 225:
												case 226:
												case 227:
													break;
												case 228:
													return "Aumenta al máximo el maná (20)";
												case 229:
													return "Aumenta al máximo el maná (20)";
												case 230:
													return "Aumenta al máximo el maná (20)";
												default:
													switch (l)
													{
													case 235:
														return "'Puede costar lanzarla'";
													case 236:
														break;
													case 237:
														return "'¡Te quedan muy bien!'";
													case 238:
														return "Aumenta el daño mágico en un 15%";
													default:
														switch (l)
														{
														case 261:
															return "'Sonríe y además es un buen aperitivo'";
														case 266:
															return "'¡Una buena idea!'";
														case 267:
															return "'Eres mala persona'";
														case 268:
															return "Permite respirar bajo el agua mucho más tiempo";
														case 272:
															return "Lanza una guadaña demoníaca";
														case 281:
															return "Permite recoger semillas como munición";
														case 282:
															return "Funciona con humedad";
														case 283:
															return "Para la cerbatana";
														case 285:
															return "Aumenta en un 5% la velocidad de movimiento";
														case 288:
															return "Ofrece inmunidad ante la lava";
														case 289:
															return "Regenera la vida";
														case 290:
															return "Aumenta en un 25% la velocidad de movimiento";
														case 291:
															return "Permite respirar agua en lugar de aire";
														case 292:
															return "Aumenta la defensa en 8";
														case 293:
															return "Aumenta la regeneración de maná";
														case 294:
															return "Aumenta el daño mágico en un 20%";
														case 295:
															return "Disminuye la velocidad de caída";
														case 296:
															return "Muestra la ubicación de tesoros y minerales";
														case 297:
															return "Proporciona invisibilidad";
														case 298:
															return "Emite un aura de luz";
														case 299:
															return "Aumenta la visión nocturna";
														case 300:
															return "Aumenta el porcentaje de regeneración del enemigo";
														case 301:
															return "Los atacantes también sufren daños";
														case 302:
															return "Permite caminar sobre el agua";
														case 303:
															return "Aumenta en un 20% la velocidad y el daño de las flechas";
														case 304:
															return "Muestra la ubicación de los enemigos";
														case 305:
															return "Permite controlar la gravedad";
														}
														break;
													}
													break;
												}
											}
											else
											{
												if (l == 324)
												{
													return "'Prohibidos en casi todas partes'";
												}
												switch (l)
												{
												case 327:
													return "Abre un cofre de oro";
												case 328:
													break;
												case 329:
													return "Abre todos los cofres de las sombras";
												default:
													if (l == 332)
													{
														return "Se usa para confeccionar ropa";
													}
													break;
												}
											}
										}
									}
								}
								else
								{
									if (l <= 726)
									{
										if (l <= 603)
										{
											if (l <= 407)
											{
												if (l == 352)
												{
													return "Se usa para elaborar cerveza";
												}
												switch (l)
												{
												case 357:
													return "Pequeñas mejoras de todas las estadísticas";
												case 361:
													return "Invoca a un ejército de duendes";
												case 363:
													return "Se usa para realizar trabajos de madera avanzados";
												case 367:
													return "Lo bastante sólido para destruir los altares demoníacos";
												case 371:
													return "Aumenta al máximo el maná (40)";
												case 372:
													return "Aumenta en un 7% la velocidad de movimiento";
												case 373:
													return "Aumenta el daño a distancia en un 10%";
												case 376:
													return "Aumenta al máximo el maná (60)";
												case 377:
													return "Aumenta un 5% la probabilidad de ataque crítico en el cuerpo a cuerpo";
												case 378:
													return "Aumenta el daño a distancia en un 12%";
												case 385:
													return "Puede abrir el mithril";
												case 386:
													return "Puede abrir la adamantita";
												case 389:
													return "Puede llegar a confundir";
												case 393:
													return "Indica el horizonte";
												case 394:
													return "Permite nadar";
												case 395:
													return "Indica la posición";
												case 396:
													return "Anula el daño al caer";
												case 397:
													return "Ofrece inmunidad ante el retroceso";
												case 398:
													return "Permite combinar varios accesorios";
												case 399:
													return "Su portador salta el doble";
												case 400:
													return "Aumenta al máximo el maná (80)";
												case 401:
													return "Aumenta un 7% la probabilidad de ataque crítico en el cuerpo a cuerpo";
												case 402:
													return "Aumenta el daño a distancia en un 14%";
												case 403:
													return "Aumenta el daño en un 6%";
												case 404:
													return "Aumenta la probabilidad de ataque crítico en un 4%";
												case 405:
													return "Permite volar";
												case 407:
													return "Aumenta la distancia de colocación de bloques";
												}
											}
											else
											{
												switch (l)
												{
												case 422:
													return "Extiende la bendición a algunos bloques";
												case 423:
													return "Extiende la corrupción a algunos bloques";
												case 424:
													break;
												case 425:
													return "Invoca a una hada mágica";
												default:
													if (l == 434)
													{
														return "Dispara tres ráfagas";
													}
													switch (l)
													{
													case 485:
														return "Convierte a su portador en hombre lobo durante la luna llena";
													case 486:
														return "Dibuja una rejilla en pantalla para colocar los bloques";
													case 489:
														return "Aumenta el daño mágico en un 15%";
													case 490:
														return "Aumenta un 15% el daño en el cuerpo a cuerpo";
													case 491:
														return "Aumenta el daño a distancia en un 15%";
													case 492:
														return "Permite volar y caer lentamente";
													case 493:
														return "Permite volar y caer lentamente";
													case 495:
														return "Lanza un arco iris dirigido";
													case 496:
														return "Lanza un bloque de hielo";
													case 497:
														return "Transforma a su portador en un tritón al sumergirse en el agua";
													case 506:
														return "Utiliza baba como munición";
													case 509:
														return "Permite colocar alambre";
													case 510:
														return "Permite cortar alambre";
													case 515:
														return "Crea varios fragmentos de cristal al impactar";
													case 516:
														return "Lanza estrellas caídas al impactar";
													case 517:
														return "Una daga mágica que vuelve al arrojarse";
													case 518:
														return "Lanza fragmentos de cristal a toda velocidad";
													case 519:
														return "Lanza bolas de fuego impuras";
													case 520:
														return "'La esencia de las criaturas de la luz'";
													case 521:
														return "'La esencia de las criaturas de la oscuridad'";
													case 522:
														return "'Ni siquiera el agua puede apagarla'";
													case 523:
														return "Se puede meter en el agua";
													case 524:
														return "Se usa para fundir mineral de adamantita";
													case 525:
														return "Se usa para fabricar objetos con lingotes de mithril y adamantita";
													case 526:
														return "'¡Puntiagudo y mágico!'";
													case 527:
														return "'A veces lo llevan las criaturas de los desiertos corrompidos'";
													case 528:
														return "'A veces lo llevan las criaturas de los desiertos de luz'";
													case 529:
														return "Se activa al pisarla";
													case 531:
														return "Se puede hechizar";
													case 532:
														return "Hace que las estrellas caigan cuando te hieren";
													case 533:
														return "Probabilidad del 50% de no gastar munición";
													case 534:
														return "Dispara una ráfaga de balas";
													case 535:
														return "Reduce el tiempo de espera para las pociones curativas";
													case 536:
														return "Aumenta el retroceso en el cuerpo a cuerpo";
													case 541:
														return "Se activa al pisarla";
													case 542:
														return "Se activa al pisarla";
													case 543:
														return "Se activa al pisarla";
													case 544:
														return "Invoca a los Gemelos";
													case 547:
														return "'La esencia del terror en estado puro'";
													case 548:
														return "'La esencia del Destructor'";
													case 549:
														return "'La esencia de los observadores omniscientes'";
													case 551:
														return "Aumenta la probabilidad de ataque crítico en un 7%";
													case 552:
														return "Aumenta el daño en un 7%";
													case 553:
														return "Aumenta el daño a distancia en un 15%";
													case 554:
														return "Aumenta el tiempo de invencibilidad tras recibir daños";
													case 555:
														return "Reduce el uso de maná en un 8%";
													case 556:
														return "Invoca El Destructor";
													case 557:
														return "Invoca al Esqueleto mayor";
													case 558:
														return "Aumenta al máximo el maná (100)";
													case 559:
														return "Aumenta un 10% la probabilidad de ataque crítico y daño en el cuerpo a cuerpo";
													case 560:
														return "Invoca a la Babosa rey";
													case 561:
														return "No apilar más de 5";
													case 575:
														return "'La esencia de poderosas criaturas que vuelan'";
													case 576:
														return "Puedes grabar canciones";
													case 579:
														return "'No confundir con un cuchillo jamonero'";
													case 580:
														return "Explota al activarse";
													case 581:
														return "Envía agua a los colectores de salida";
													case 582:
														return "Recibe agua de los colectores de entrada";
													case 583:
														return "Se activa cada segundo";
													case 584:
														return "Se activa cada 3 segundos";
													case 585:
														return "Se activa cada 5 segundos";
													case 599:
														return "Haga clic derecho para abrir";
													case 600:
														return "Haga clic derecho para abrir";
													case 601:
														return "Haga clic derecho para abrir";
													case 602:
														return "Convoca a la Legión de Frost";
													case 603:
														return "Convoca a un conejo de mascota";
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 686)
											{
												switch (l)
												{
												case 665:
													return "Usted no debería tener este";
												case 666:
													return "Usted no debería tener este";
												case 667:
													return "Usted no debería tener este";
												case 668:
													return "Usted no debería tener este";
												case 669:
													return "Invoca a un bebé pingüino";
												default:
													if (l == 676)
													{
														return "Dispara un tornillo de hielo";
													}
													switch (l)
													{
													case 683:
														return "Citación tridente del diablo";
													case 684:
														return "16% más de daño cuerpo a cuerpo ya distancia";
													case 685:
														return "11% más de cuerpo a cuerpo ya distancia probabilidad de golpe críticoe";
													case 686:
														return "8% de aumento de la velocidad de movimiento";
													}
													break;
												}
											}
											else
											{
												switch (l)
												{
												case 707:
													return "Indica el tiempo";
												case 708:
													return "Indica el tiempo";
												case 709:
													return "Indica el tiempo";
												default:
													if (l == 716)
													{
														return "Se utiliza para artículos de artesanía a partir de barras de metal";
													}
													switch (l)
													{
													case 723:
														return "Dispara un rayo de luz";
													case 724:
														return "Dispara un tornillo de hielo";
													case 725:
														return "Dispara flechas heladas";
													case 726:
														return "Dispara un chorro de heladas";
													}
													break;
												}
											}
										}
									}
									else
									{
										if (l <= 832)
										{
											if (l <= 761)
											{
												switch (l)
												{
												case 748:
													return "Permite el vuelo y la caída lenta";
												case 749:
													return "Permite el vuelo y la caída lenta";
												default:
													if (l == 753)
													{
														return "Invoca una tortuga mascota";
													}
													if (l == 761)
													{
														return "Permite el vuelo y la caída lenta";
													}
													break;
												}
											}
											else
											{
												switch (l)
												{
												case 779:
													return "Crea y destruye biomas cuando se pulveriza";
												case 780:
													return "Utilizado por el Clentaminator";
												case 781:
													return "Utilizado por el Clentaminator";
												case 782:
													return "Utilizado por el Clentaminator";
												case 783:
													return "Utilizado por el Clentaminator";
												case 784:
													return "Utilizado por el Clentaminator";
												case 785:
													return "Permite el vuelo y la caída lenta";
												case 786:
													return "Permite el vuelo y la caída lenta";
												case 787:
													return "Lo suficientemente fuerte como para destruir los altares Demon";
												case 788:
													return "Invoca una lanza espina";
												case 789:
												case 790:
												case 791:
												case 795:
												case 796:
												case 797:
													break;
												case 792:
													return "2% aumentado el daño";
												case 793:
													return "2% aumentado el daño";
												case 794:
													return "2% aumentado el daño";
												case 798:
													return "Capaz de extraer Hellstone";
												default:
													switch (l)
													{
													case 821:
														return "Permite el vuelo y la caída lenta";
													case 822:
														return "Permite el vuelo y la caída lenta";
													case 823:
														return "Permite el vuelo y la caída lenta";
													default:
														if (l == 832)
														{
															return "Lugares madera viva";
														}
														break;
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 1343)
											{
												switch (l)
												{
												case 849:
													return "Permite bloques sólidos para activar y desactivar";
												case 850:
													return "Lugares cable azul";
												case 851:
													return "Lugares cable verde";
												case 852:
													return "Se activa cuando un jugador pisa";
												case 853:
													return "Se activa cuando cualquier cosa menos que un jugador pisa";
												case 854:
													return "Tiendas tienen precios más bajos";
												case 855:
													return "Golpear a los enemigos a veces caer más monedas";
												case 856:
													return "'Tener un tiempo maravilloso!'";
												case 857:
													return "Permite a su titular a hacer un doble salto mejorada";
												case 858:
												case 859:
												case 864:
												case 865:
												case 866:
												case 867:
												case 868:
												case 869:
												case 870:
												case 871:
												case 872:
												case 873:
												case 874:
												case 875:
												case 876:
												case 877:
												case 878:
												case 879:
												case 880:
												case 881:
												case 882:
												case 883:
												case 884:
												case 894:
												case 895:
												case 896:
												case 909:
												case 910:
												case 911:
												case 912:
												case 913:
												case 914:
												case 915:
												case 916:
												case 917:
												case 918:
												case 919:
												case 920:
												case 921:
												case 922:
												case 923:
												case 924:
												case 925:
												case 926:
												case 927:
												case 928:
												case 929:
												case 930:
												case 931:
												case 939:
												case 940:
												case 941:
												case 942:
												case 943:
												case 944:
												case 945:
												case 949:
												case 952:
												case 954:
												case 955:
												case 970:
												case 971:
												case 972:
												case 973:
												case 974:
												case 978:
												case 979:
												case 980:
												case 981:
												case 988:
												case 991:
												case 992:
												case 993:
												case 999:
													break;
												case 860:
													return "Proporciona regeneración de vida y reduce el tiempo de reutilización de pociones curativas";
												case 861:
													return "Activa el soporte en un hombre lobo en la noche y tritones al entrar en el agua";
												case 862:
													return "Causas estrellas a caer y aumenta la longitud de la invencibilidad tras recibir daño";
												case 863:
													return "Ofrece la posibilidad de caminar sobre el agua";
												case 885:
													return "inmunidad a sangrado";
												case 886:
													return "inmunidad a la armadura rota";
												case 887:
													return "inmunidad al veneno";
												case 888:
													return "inmunidad a la oscuridad";
												case 889:
													return "inmunidad a reducir la velocidad";
												case 890:
													return "inmunidad para silenciar";
												case 891:
													return "inmunidad a maldecir";
												case 892:
													return "inmunidad a la debilidad";
												case 893:
													return "inmunidad a la confusión";
												case 897:
													return "Aumenta melee llamar de nuevo";
												case 898:
													return "permite vuelo";
												case 899:
													return "Incrementa todas las estadísticas si se usan durante el día";
												case 900:
													return "Incrementa todas las estadísticas si se usan durante la noche";
												case 901:
													return "Inmunidad a la debilidad y la armadura rota";
												case 902:
													return "Inmunidad al veneno y sangrado";
												case 903:
													return "Inmunidad a disminuir y la confusión";
												case 904:
													return "Inmunidad al silencio y la maldición";
												case 905:
													return "Utiliza las monedas de munición";
												case 906:
													return "Proporciona 7 segundos de inmunidad a la lava";
												case 907:
													return "Ofrece la posibilidad de caminar sobre el agua";
												case 908:
													return "Ofrece la posibilidad de caminar sobre el agua y la lava";
												case 932:
													return "lugares ósea";
												case 933:
													return "lugares hojas";
												case 934:
													return "Permite al propietario para flotar durante unos segundos";
												case 935:
													return "12% aumentado el daño";
												case 936:
													return "Aumenta melee llamar de nuevo";
												case 937:
													return "Explota cuando pisó";
												case 938:
													return "Absorbe el 25% del daño hecho a los jugadores de su equipo";
												case 946:
													return "Usted caerá más lento, mientras que la celebración de este";
												case 947:
													return "Reacciona a la luz";
												case 948:
													return "Permite el vuelo y la caída lenta";
												case 950:
													return "Proporciona una mayor movilidad en el hielo";
												case 951:
													return "Rápidamente lanza bolas de nieve";
												case 953:
													return "Permite la posibilidad de deslizarse por las paredes";
												case 956:
													return "7% aumento de la velocidad de cuerpo a cuerpo";
												case 957:
													return "7% aumento de la velocidad de cuerpo a cuerpo";
												case 958:
													return "7% aumento de la velocidad de cuerpo a cuerpo";
												case 959:
													return "4% aumentado el daño a distancia.";
												case 960:
													return "Aumenta el maná máximo por 20";
												case 961:
													return "Aumenta el maná máximo por 20";
												case 962:
													return "Aumenta el maná máximo por 20";
												case 963:
													return "Da la oportunidad de esquivar los ataques";
												case 964:
													return "Dispara un diferencial de balas";
												case 965:
													return "Puede ser escalado en";
												case 966:
													return "La regeneración de la vida se incrementa cuando cerca de una fogata";
												case 967:
													return "Póngalo en un palo y asado sobre un fuego de campamento";
												case 968:
													return "Asar es sobre una hoguera!";
												case 969:
													return "Pequeñas mejoras a todas las estadísticas";
												case 975:
													return "Permite la posibilidad de deslizarse por las paredes";
												case 976:
													return "Permite la posibilidad de escalar paredes";
												case 977:
													return "Permite la posibilidad de lanzarse";
												case 982:
													return "Aumenta el maná máximo por 20";
												case 983:
													return "Permite al propietario el doble salto";
												case 984:
													return "Permite la posibilidad de escalar paredes y guión";
												case 985:
													return "Saque de banda para crear una línea escalable de la cuerda";
												case 986:
													return "Permite la recolección de semillas para munición";
												case 987:
													return "Permite al propietario el doble salto";
												case 989:
													return "Dispara un rayo espada encantada";
												case 990:
													return "'No se debe confundir con un hamdrill'";
												case 994:
													return "Invoca una Eater bebé de las Almas";
												case 995:
													return "Se utiliza para elaborar objetos";
												case 996:
													return "Se utiliza para elaborar objetos";
												case 997:
													return "Resulta cieno y lodo en algo más útil";
												case 998:
													return "Se utiliza para elaborar objetos";
												case 1000:
													return "Dispara confeti por todas partes!";
												case 1001:
													return "16% aumentado el daño cuerpo a cuerpo";
												case 1002:
													return "16% aumentado el daño a distancia";
												case 1003:
													return "Aumenta el maná máximo en un 80 y reduce el uso de maná un 17%";
												case 1004:
													return "5% aumentado el daño";
												case 1005:
													return "8% mayor probabilidad de golpe crítico";
												case 1006:
													return "Reacciona a la luz";
												default:
													switch (l)
													{
													case 1071:
														return "Utilizado con pintura a los bloques de color";
													case 1072:
														return "Se utiliza con pintura de color a las paredes";
													default:
														switch (l)
														{
														case 1100:
															return "Se utiliza para quitar la pintura";
														case 1107:
															return "Used to make teal dye";
														case 1108:
															return "Used to make green dye";
														case 1109:
															return "Se utiliza para hacer tinte verde azulado";
														case 1110:
															return "Se utiliza para hacer colorante amarillo";
														case 1111:
															return "Se utiliza para hacer un tinte azul";
														case 1112:
															return "Se utiliza para hacer tintes cal";
														case 1113:
															return "Se utiliza para hacer tinte rosa";
														case 1114:
															return "Se utiliza para hacer tinte naranja";
														case 1115:
															return "Se utiliza para hacer tinte rojo";
														case 1116:
															return "Se utiliza para hacer colorante cian";
														case 1117:
															return "Se utiliza para hacer tinte violeta";
														case 1118:
															return "Se utiliza para hacer tinte púrpura";
														case 1119:
															return "Se utiliza para hacer tinte negro";
														case 1120:
															return "Se utiliza para elaborar tintes";
														case 1121:
															return "Brotes de abejas que perseguir a su enemigo";
														case 1122:
															return "Persigue a su enemigo";
														case 1123:
															return "Invoca abejas asesinas después de golpear a tu enemigo";
														case 1129:
															return "Lugares colmenas";
														case 1130:
															return "Se descompone en un enjambre de abejas";
														case 1131:
															return "Permite al propietario para revertir la gravedad";
														case 1132:
															return "Libera las abejas cuando está dañado";
														case 1133:
															return "Invoca la abeja reina";
														case 1141:
															return "Abre la puerta del templo de la selva";
														case 1145:
															return "Se utiliza para la elaboración básicas";
														case 1151:
															return "Se activa cuando un jugador pisa";
														case 1156:
															return "Prende a los enemigos por los daños continuos";
														case 1157:
															return "Invoca un pigmeo para luchar por usted";
														case 1158:
															return "Aumenta el número máximo de esbirros";
														case 1159:
															return "Aumenta el número máximo de esbirros";
														case 1160:
															return "Aumenta el número máximo de esbirros";
														case 1161:
															return "Aumenta el número máximo de esbirros";
														case 1162:
															return "Permite el vuelo y la caída lenta";
														case 1163:
															return "Permite al propietario el doble salto";
														case 1164:
															return "Permite al propietario salto cuádruple";
														case 1165:
															return "Permite el vuelo y la caída lenta";
														case 1167:
															return "Aumenta el daño de tus siervos por 15";
														case 1169:
															return "Invoca una cabeza Skeletron bebé";
														case 1170:
															return "Invoca un Hornet bebé";
														case 1171:
															return "Invoca un espíritu Tiki";
														case 1172:
															return "Invoca una lagartija";
														case 1178:
															return "Dispara rápidamente hojas afiladas";
														case 1179:
															return "Persigue a su enemigo";
														case 1180:
															return "Invoca un loro";
														case 1181:
															return "Invoca una trufa bebé";
														case 1182:
															return "Invoca un árbol del animal doméstico";
														case 1183:
															return "Invoca un Wisp para proporcionar luz";
														case 1188:
															return "Puede mina Mythril, Orichalcum, adamantita y Titanium";
														case 1189:
															return "Puede mina Mythril, Orichalcum, adamantita y Titanium";
														case 1195:
															return "Puede mina adamantita y Titanio";
														case 1196:
															return "Puede mina adamantita y Titanio";
														case 1205:
															return "8% aumentado el daño cuerpo a cuerpo";
														case 1206:
															return "9% aumentado el daño a distancia";
														case 1207:
															return "7% aumento de daño mágico y probabilidad de golpe crítico";
														case 1208:
															return "3% aumentado el daño";
														case 1209:
															return "2% aumentado el daño";
														case 1210:
															return "7% aumentado el daño cuerpo a cuerpo";
														case 1211:
															return "15% mayor distancia probabilidad de golpe crítico";
														case 1212:
															return "18% increased magic critical strike chance";
														case 1213:
															return "6% mayor probabilidad de golpe crítico";
														case 1214:
															return "11% increased movement speed";
														case 1215:
															return "8% increased melee damage and critical strike chance";
														case 1216:
															return "16% aumentado el daño a distancia";
														case 1217:
															return "16% aumento de daño mágico y el 7% se incrementaron magia probabilidad de golpe crítico";
														case 1218:
															return "4% aumentado el daño";
														case 1219:
															return "3% aumentado el daño y la probabilidad de golpe crítico";
														case 1220:
															return "Se utiliza para crear objetos de mythril, oricalco, adamantita y barras de titanio";
														case 1221:
															return "Se utiliza para adamantite fundir y mineral de titanio";
														case 1226:
															return "Dispara un poderoso orbe";
														case 1227:
															return "Dispara una nube de esporas";
														case 1228:
															return "Dispara una nube de esporas";
														case 1235:
															return "Rebota después de golpear una pared";
														case 1242:
															return "Invoca un dinosaurio bebé";
														case 1244:
															return "Invoca una nube lloviendo sobre sus enemigos";
														case 1247:
															return "Causas estrellas a caer y libera abejas cuando se lesionó";
														case 1248:
															return "10% mayor probabilidad de golpe crítico";
														case 1249:
															return "Aumenta la altura del salto";
														case 1250:
															return "Permite al propietario el doble salto";
														case 1251:
															return "Permite al propietario el doble salto";
														case 1252:
															return "Permite al propietario el doble salto";
														case 1253:
															return "Pone una capa alrededor del propietario cuando bajo la vida del 25% que reduce el daño";
														case 1254:
															return "Dispara un potente y de alta velocidad de la bala";
														case 1255:
															return "Dispara un potente y de alta velocidad de la bala";
														case 1256:
															return "Invoca una nube a llover sangre en tus enemigos";
														case 1258:
															return "Dispara un perno explosivo";
														case 1259:
															return "Brotes de afeitar afiladas pétalos de flores a los enemigos cercanos";
														case 1260:
															return "Dispara un arco iris que hace daño continuo";
														case 1261:
															return "Se descompone en metralla mortal";
														case 1264:
															return "Dispara una bola de hielo";
														case 1265:
															return "Dispara un potente y de alta velocidad de la bala";
														case 1282:
															return "Aumenta el maná máximo por 20";
														case 1283:
															return "Aumenta el maná máximo por 40";
														case 1284:
															return "Aumenta el maná máximo por 40";
														case 1285:
															return "Aumenta el maná máximo por 60";
														case 1286:
															return "Aumenta el maná máximo por 60";
														case 1287:
															return "Aumenta el maná máximo por 80";
														case 1290:
															return "Aumenta la velocidad de movimiento después de ser golpeado";
														case 1291:
															return "Permanentemente aumenta la vida útil máxima de 5";
														case 1293:
															return "Se utiliza en el Altar Lihzahrd";
														case 1294:
															return "Capaz de minería Lihzahrd Ladrillos";
														case 1295:
															return "Dispara un rayo penetrante calor";
														case 1296:
															return "Invoca un poderoso canto rodado";
														case 1297:
															return "Golpes con la fuerza de un golem";
														case 1299:
															return "Aumenta la gama ver cuando se mantiene";
														case 1300:
															return "Aumenta ver gama de armas de fuego";
														case 1301:
															return "10% aumentado el daño";
														case 1303:
															return "Proporciona luz bajo el agua";
														case 1306:
															return "Dispara una hoz helada";
														case 1307:
															return "'Usted es una persona terrible'";
														case 1308:
															return "Dispara un veneno colmillo que atraviesa múltiples enemigos";
														case 1309:
															return "Invoca un limo bebé para luchar por usted";
														case 1310:
															return "Inflige veneno enemigos";
														case 1311:
															return "Convoca a un resorte globo ocular";
														case 1312:
															return "Invoca un muñeco de nieve del bebé";
														case 1313:
															return "Dispara un cráneo";
														case 1314:
															return "Dispara un guante de boxeo";
														case 1315:
															return "Invoca una invasión pirata";
														case 1316:
															return "6% aumentado el daño cuerpo a cuerpo";
														case 1317:
															return "8% aumentado el daño cuerpo a cuerpo y la probabilidad de golpe crítico";
														case 1318:
															return "4% mayor probabilidad de golpe crítico cuerpo a cuerpo";
														case 1321:
															return "Aumentar la velocidad de la flecha y el daño en un 10%";
														case 1322:
															return "Inflige daño de fuego en el ataque";
														case 1323:
															return "Reduce el daño de no tocar la lava";
														case 1326:
															return "Teletransporta a la posición del ratón";
														case 1327:
															return "Dispara una hoz mortal";
														case 1331:
															return "Invoca el cerebro de Cthulhu";
														case 1332:
															return "'La sangre de los dioses'";
														case 1333:
															return "Puede ser colocado en agua";
														case 1334:
															return "Disminuye la defensa del objetivo";
														case 1335:
															return "Disminuye la defensa del objetivo";
														case 1336:
															return "Aplica una lluvia de icor";
														case 1343:
															return "Aumenta melee llamar de nuevo e inflige daño de fuego en el ataque";
														}
														break;
													}
													break;
												}
											}
											else
											{
												switch (l)
												{
												case 1430:
													return "Se utiliza para elaborar frascos imbuement armas";
												case 1431:
													break;
												case 1432:
													return "Se utiliza para elaborar distintos tipos de munición";
												default:
													switch (l)
													{
													case 1444:
														return "Crea un haz de sombra que rebota en las paredes";
													case 1445:
														return "Lanza una bola de fuego que explota en un infierno rugiente";
													case 1446:
														return "Invoca un alma en pena para perseguir a sus enemigos";
													case 1447:
													case 1448:
														break;
													case 1449:
														return "sopla burbujas";
													case 1450:
														return "sopla burbujas";
													default:
														switch (l)
														{
														case 1503:
															return "Aumenta el maná máximo en un 80 y reduce el uso de maná un 17%";
														case 1504:
															return "7% más de daño mágico y la probabilidad de golpe crítico";
														case 1505:
															return "8% mayor daño mágico";
														case 1513:
															return "Un poderoso martillo regresar";
														case 1515:
															return "Permite el vuelo y la caída lenta";
														case 1522:
															return "Para la captura de la gema. Suelta cuando mueras";
														case 1523:
															return "Para la captura de la gema. Suelta cuando mueras";
														case 1524:
															return "Para la captura de la gema. Suelta cuando mueras";
														case 1525:
															return "Para la captura de la gema. Suelta cuando mueras";
														case 1526:
															return "Para la captura de la gema. Suelta cuando mueras";
														case 1527:
															return "Para la captura de la gema. Suelta cuando mueras";
														case 1533:
															return "Desbloquea un pecho Jungle en la mazmorra";
														case 1534:
															return "Desbloquea un pecho Corrupción en el calabozo";
														case 1535:
															return "Desbloquea un pecho carmesí en el calabozo";
														case 1536:
															return "Abre un cofre sagrado en el calabozo";
														case 1537:
															return "Desbloquea un pecho congelado en el calabozo";
														case 1543:
															return "Utilizado con pintura a los bloques de color";
														case 1544:
															return "Se utiliza con pintura de color a las paredes";
														case 1545:
															return "Se utiliza para quitar la pintura";
														case 1546:
															return "15% aumentado el daño flecha";
														case 1547:
															return "15% aumentado el daño de bala";
														case 1548:
															return "15% aumentado el daño de cohetes";
														case 1549:
															return "13% mayor distancia probabilidad de golpe crítico";
														case 1550:
															return "7% mayor distancia probabilidad de golpe crítico";
														case 1551:
															return "Convierte Bares chlorophyte en Bares Shroomite";
														case 1553:
															return "50% oportunidad de no consumir municiones";
														case 1554:
															return "Usted no debería tener este";
														case 1555:
															return "Usted no debería tener este";
														case 1556:
															return "Usted no debería tener este";
														case 1557:
															return "Usted no debería tener este";
														case 1558:
															return "Usted no debería tener este";
														case 1559:
															return "Usted no debería tener este";
														case 1560:
															return "Usted no debería tener este";
														case 1561:
															return "Usted no debería tener este";
														case 1562:
															return "Usted no debería tener este";
														case 1563:
															return "Usted no debería tener este";
														case 1564:
															return "Usted no debería tener este";
														case 1565:
															return "Usted no debería tener este";
														case 1566:
															return "Usted no debería tener este";
														case 1567:
															return "Usted no debería tener este";
														case 1568:
															return "Usted no debería tener este";
														case 1569:
															return "Tirar rápidamente dagas robando la vida";
														case 1571:
															return "A javalin poderosa que libera pequeñas comedores";
														case 1572:
															return "Invoca un poderoso heladas hydra de escupir hielo a sus enemigos";
														case 1578:
															return "Lanzamientos abejas y aumenta la velocidad de movimiento cuando está dañado";
														case 1579:
															return "El usuario puede correr muy rápido";
														case 1580:
															return "Usted no debería tener este";
														case 1581:
															return "Usted no debería tener este";
														case 1582:
															return "Usted no debería tener este";
														case 1583:
															return "Usted no debería tener este";
														case 1584:
															return "Usted no debería tener este";
														case 1585:
															return "Usted no debería tener este";
														case 1586:
															return "Usted no debería tener este";
														case 1587:
															return "Usted no debería tener este";
														case 1588:
															return "Usted no debería tener este";
														case 1595:
															return "Aumenta el maná máximo por 20";
														}
														break;
													}
													break;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (!english && Lang.lang > 1)
			{
				return Lang.toolTip(l, true);
			}
			return "";
		}
		public static string toolTip2(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				if (l <= 962)
				{
					if (l <= 686)
					{
						if (l <= 405)
						{
							if (l <= 98)
							{
								if (l == 65)
								{
									return "'Forged with the fury of heaven'";
								}
								if (l == 98)
								{
									return "'Half shark, half gun, completely awesome.'";
								}
							}
							else
							{
								switch (l)
								{
								case 228:
									return "3% increased magic critical strike chance";
								case 229:
									return "3% increased magic critical strike chance";
								case 230:
									return "3% increased magic critical strike chance";
								default:
									switch (l)
									{
									case 371:
										return "9% increased magic critical strike chance";
									case 372:
										return "12% increased melee speed";
									case 373:
										return "6% increased ranged critical strike chance";
									case 374:
										return "3% increased critical strike chance";
									case 375:
										return "10% increased movement speed";
									case 376:
										return "15% increased magic damage";
									case 377:
										return "10% increased melee damage";
									case 378:
										return "7% increased ranged critical strike chance";
									case 379:
										return "5% increased damage";
									case 380:
										return "3% increased critical strike chance";
									case 389:
										return "'Find your inner pieces'";
									case 394:
										return "Greatly extends underwater breathing";
									case 395:
										return "Tells the time";
									case 396:
										return "Grants immunity to fire blocks";
									case 397:
										return "Grants immunity to fire blocks";
									case 399:
										return "Increases jump height";
									case 400:
										return "11% increased magic damage and critical strike chance";
									case 401:
										return "14% increased melee damage";
									case 402:
										return "8% increased ranged critical strike chance";
									case 404:
										return "5% increased movement speed";
									case 405:
										return "The wearer can run super fast";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 533)
							{
								if (l == 434)
								{
									return "Only the first shot consumes ammo";
								}
								if (l == 533)
								{
									return "'Minishark's older brother'";
								}
							}
							else
							{
								switch (l)
								{
								case 552:
									return "8% increased movement speed";
								case 553:
									return "8% increased ranged critical strike chance";
								case 554:
								case 556:
								case 557:
									break;
								case 555:
									return "Automatically use mana potions when needed";
								case 558:
									return "12% increased magic damage and critical strike chance";
								case 559:
									return "10% increased melee haste";
								default:
									if (l == 686)
									{
										return "7% increased melee attack speed";
									}
									break;
								}
							}
						}
					}
					else
					{
						if (l <= 908)
						{
							if (l <= 784)
							{
								if (l == 748)
								{
									return "Hold up to rocket faster";
								}
								switch (l)
								{
								case 771:
									return "Small blast radius. Will not destroy tiles";
								case 772:
									return "Small blast radius. Will destroy tiles";
								case 773:
									return "Large blast radius. Will not destroy tiles";
								case 774:
									return "Large blast radius. Will destroy tiles";
								case 775:
									return "Increases running speed";
								case 776:
									return "Can mine Mythril and Orichalcum";
								case 777:
									return "Can mine Adamantite and Titanium";
								case 779:
									return "Uses colored solution";
								case 780:
									return "Spreads the Purity";
								case 781:
									return "Spreads the Hallow";
								case 782:
									return "Spreads the Corruption";
								case 783:
									return "Spreads Glowing Mushrooms";
								case 784:
									return "Spreads the Crimson";
								}
							}
							else
							{
								switch (l)
								{
								case 897:
									return "12% increased melee speed";
								case 898:
									return "The wearer can run incredibly fast";
								default:
									switch (l)
									{
									case 905:
										return "Higher valued coins do more damage";
									case 907:
										return "Grants immunity to fire blocks";
									case 908:
										return "Grants immunity to fire blocks and 7 seconds of immunity to lava";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 938)
							{
								if (l == 929)
								{
									return "For use with cannon";
								}
								switch (l)
								{
								case 936:
									return "10% increased damage and melee speed";
								case 938:
									return "Only active above 25% life";
								}
							}
							else
							{
								if (l == 950)
								{
									return "Ice will not break when you fall on it";
								}
								if (l == 953)
								{
									return "Improved ability if combined with Shoe Spikes";
								}
								switch (l)
								{
								case 960:
									return "3% increased magic critical strike chance";
								case 961:
									return "3% increased magic critical strike chance";
								case 962:
									return "3% increased magic critical strike chance";
								}
							}
						}
					}
				}
				else
				{
					if (l <= 1254)
					{
						if (l <= 1123)
						{
							if (l <= 984)
							{
								switch (l)
								{
								case 975:
									return "Improved ability if combined with Climbing Claws";
								case 976:
									break;
								case 977:
									return "Double tap a direction";
								default:
									switch (l)
									{
									case 982:
										return "Increases mana regeneration rate";
									case 983:
										return "Increases jump height";
									case 984:
										return "Gives a chance to dodge attacks";
									}
									break;
								}
							}
							else
							{
								switch (l)
								{
								case 997:
									return "'To use: Place silt/slush in the extractinator'";
								case 998:
								case 999:
								case 1000:
									break;
								case 1001:
									return "6% increased melee critical strike chance";
								case 1002:
									return "20% chance to not consume ammo";
								case 1003:
									return "16% increased magic damage";
								case 1004:
									return "7% increased critical strike chance";
								case 1005:
									return "5% increased movement speed";
								default:
									if (l == 1123)
									{
										return "Small chance to cause confusion";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 1167)
							{
								if (l == 1131)
								{
									return "Press UP to change gravity";
								}
								switch (l)
								{
								case 1159:
									return "Increases minion damage by 10%";
								case 1160:
									return "Increases minion damage by 10%";
								case 1161:
									return "Increases minion damage by 10%";
								case 1163:
									return "Increases jump height";
								case 1164:
									return "Increases jump height";
								case 1167:
									return "Increases the knockback of your minions";
								}
							}
							else
							{
								switch (l)
								{
								case 1205:
									return "12% increased melee speed";
								case 1206:
									return "9% increased ranged critical strike chance";
								case 1207:
									return "Increases maximum mana by 60";
								case 1208:
									return "2% increased critical strike chance";
								case 1209:
									return "1% increased critical strike chance";
								case 1210:
									return "7% increased movement and melee speed";
								case 1211:
									return "8% increased movement speed";
								case 1212:
									return "Increases maximum mana by 80";
								case 1213:
								case 1214:
									break;
								case 1215:
									return "8% increased melee speed";
								case 1216:
									return "7% increased ranged critical strike chance";
								case 1217:
									return "Increases maximum mana by 100";
								case 1218:
									return "3% increased critical strike chance";
								case 1219:
									return "6% increased movement speed";
								default:
									switch (l)
									{
									case 1249:
										return "Releases bees when damaged";
									case 1250:
										return "Increases jump height and negates fall damage";
									case 1251:
										return "Increases jump height and negates fall damage";
									case 1252:
										return "Increases jump height and negates fall damage";
									case 1254:
										return "Right click to zoom out";
									}
									break;
								}
							}
						}
					}
					else
					{
						if (l <= 1321)
						{
							if (l <= 1295)
							{
								switch (l)
								{
								case 1282:
									return "Reduces mana usage by 5%";
								case 1283:
									return "Reduces mana usage by 7%";
								case 1284:
									return "Reduces mana usage by 9%";
								case 1285:
									return "Reduces mana usage by 11%";
								case 1286:
									return "Reduces mana usage by 13%";
								case 1287:
									return "Reduces mana usage by 15%";
								default:
									if (l == 1295)
									{
										return "'Oolaa!!'";
									}
									break;
								}
							}
							else
							{
								switch (l)
								{
								case 1300:
									return "Right click to zoom out";
								case 1301:
									return "8% increased critical strike chance";
								default:
									switch (l)
									{
									case 1316:
										return "Enemies are more likely to target you";
									case 1317:
										return "Enemies are more likely to target you";
									case 1318:
										return "Enemies are more likely to target you";
									case 1321:
										return "20% chance to not consume arrow";
									}
									break;
								}
							}
						}
						else
						{
							if (l <= 1505)
							{
								switch (l)
								{
								case 1336:
									return "Decreases target's defense";
								case 1337:
								case 1344:
								case 1345:
								case 1346:
								case 1347:
								case 1348:
									break;
								case 1338:
									return "For use with bunny cannon";
								case 1339:
									return "'Extremely toxic'";
								case 1340:
									return "Melee attacks inflict Venom on enemies";
								case 1341:
									return "Inflicts target with Venom";
								case 1342:
									return "Inflicts target with Venom";
								case 1343:
									return "9% increased melee damage and speed";
								case 1349:
									return "Explodes into confetti on impact";
								case 1350:
									return "Causes confusion";
								case 1351:
									return "Explodes on impact";
								case 1352:
									return "Enemies killed will drop more money";
								case 1353:
									return "Melee attacks inflict enemies with cursed flames";
								case 1354:
									return "Melee attacks set enemies on fire";
								case 1355:
									return "Melee attacks make enemies drop more gold";
								case 1356:
									return "Melee attacks decrease enemies defense";
								case 1357:
									return "Melee attacks confuse enemies";
								case 1358:
									return "Melee attacks cause confetti to appear";
								case 1359:
									return "Melee attacks poison enemies";
								default:
									switch (l)
									{
									case 1503:
										return "10% increased magic damage and critical strike chance";
									case 1505:
										return "8% increased movement speed";
									}
									break;
								}
							}
							else
							{
								switch (l)
								{
								case 1546:
									return "5% increased ranged critical strike chance";
								case 1547:
									return "5% increased ranged critical strike chance";
								case 1548:
									return "5% increased ranged critical strike chance";
								case 1549:
									return "20% chance to not consume ammo";
								case 1550:
									return "12% increased movement speed";
								case 1551:
								case 1552:
									break;
								case 1553:
									return "'It came from the edge of space'";
								default:
									if (l == 1595)
									{
										return "Restores mana when damaged";
									}
									if (l == 1613)
									{
										return "Grants immunity to most debuffs";
									}
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					if (l <= 962)
					{
						if (l <= 686)
						{
							if (l <= 405)
							{
								if (l <= 98)
								{
									if (l == 65)
									{
										return "'Geschmiedet mit Himmelswut'";
									}
									if (l == 98)
									{
										return "'Halb Hai, halb Pistole - einfach toll!'";
									}
								}
								else
								{
									switch (l)
									{
									case 228:
										return "Um 3% erhoehte kritische Magietrefferchance";
									case 229:
										return "Um 3% erhoehte kritische Magietrefferchance";
									case 230:
										return "Um 3% erhoehte kritische Magietrefferchance";
									default:
										switch (l)
										{
										case 371:
											return "Um 9% erhoehte kritische Magietrefferchance";
										case 372:
											return "Um 12% erhoehtes Nahkampftempo";
										case 373:
											return "Um 6% erhoehte kritische Fernkampf-Trefferchance";
										case 374:
											return "Um 3% erhoehte kritische Trefferchance";
										case 375:
											return "Um 10% erhoehtes Bewegungstempo";
										case 376:
											return "Um 15% erhoehter magischer Schaden";
										case 377:
											return "Um 10% erhoehter Nahkampfschaden";
										case 378:
											return "Um 7% erhoehte kritische Fernkampf-Trefferchance";
										case 379:
											return "Um 5% erhoehter Schaden";
										case 380:
											return "Um 3% erhoehte kritische Trefferchance";
										case 389:
											return "'Sammele dich!'";
										case 394:
											return "Verlaengert das Atmen unter Wasser deutlich";
										case 395:
											return "Zeigt die Zeit an";
										case 396:
											return "Macht immun gegen Feuer-Bloecke";
										case 397:
											return "Macht immun gegen Feuer-Bloecke";
										case 399:
											return "Vergroessert die Sprunghoehe";
										case 400:
											return "Magischer Schaden und kritische Trefferchance um 11% erhoeht";
										case 401:
											return "Um 14% erhoehter Nahkampfschaden";
										case 402:
											return "Um 8% erhoehte kritische Fernkampf-Trefferchance";
										case 404:
											return "Um 5% erhoehtes Bewegungstempo";
										case 405:
											return "Der Traeger kann superschnell rennen";
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 533)
								{
									if (l == 434)
									{
										return "Nur der erste Schuss verbraucht Munition ";
									}
									if (l == 533)
									{
										return "'Minihais grosser Bruder'";
									}
								}
								else
								{
									switch (l)
									{
									case 552:
										return "Um 8% erhoehtes Bewegungstempo";
									case 553:
										return "Um 8% erhoehte kritische Fernkampf-Trefferchance";
									case 554:
									case 556:
									case 557:
										break;
									case 555:
										return "Bei Bedarf automatisch Manatraenke verwenden";
									case 558:
										return "Magischer Schaden und kritische Trefferchance um 12% erhoeht";
									case 559:
										return "Um 10% erhoehtes Nahkampftempo";
									default:
										if (l == 686)
										{
											return "7% erhöht Nahkampfangriffstempo";
										}
										break;
									}
								}
							}
						}
						else
						{
							if (l <= 908)
							{
								if (l <= 784)
								{
									if (l == 748)
									{
										return "Halten bis zu Rakete schneller";
									}
									switch (l)
									{
									case 771:
										return "Kleine Explosion. Wird nicht zerstören Fliesen";
									case 772:
										return "Kleine Explosion. Will Fliesen zu zerstören";
									case 773:
										return "Große Sprengradius. Wird nicht zerstören Fliesen";
									case 774:
										return "Große Sprengradius. Will Fliesen zu zerstören";
									case 775:
										return "Erhöht Laufgeschwindigkeit";
									case 776:
										return "Kann mir Mithril und Orichalcum";
									case 777:
										return "Kann mir Adamantitbeschlagene und Titanium";
									case 779:
										return "Verwendet gefärbte Lösung";
									case 780:
										return "Verbreitet die Reinheit";
									case 781:
										return "Verteilt den Hallow";
									case 782:
										return "Verbreitet die Korruption";
									case 783:
										return "Verbreitet leuchtende Pilze";
									case 784:
										return "Verbreitet Crimson";
									}
								}
								else
								{
									switch (l)
									{
									case 897:
										return "12% erhöht Nahkampfsangriffstempo";
									case 898:
										return "Der Träger kann unglaublich schnell laufen";
									default:
										switch (l)
										{
										case 905:
											return "Höherwertigen Münzen mehr Schaden anrichten";
										case 907:
											return "Grants Immunität gegen Feuer-Blöcke";
										case 908:
											return "Grants Immunität gegen Feuer-Blöcke und 7 Sekunden Immunität gegen Lava";
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 938)
								{
									if (l == 929)
									{
										return "Für den Einsatz mit Kanone";
									}
									switch (l)
									{
									case 936:
										return "10% mehr Schaden und Nahkampfsangriffstempo";
									case 938:
										return "Nur aktiv, über 25% Leben";
									}
								}
								else
								{
									if (l == 953)
									{
										return "Verbesserte Fähigkeit, wenn sie mit Schuh Spikes kombiniert";
									}
									switch (l)
									{
									case 960:
										return "3% Magie erhöht Chance auf kritische Treffer";
									case 961:
										return "3% Magie erhöht Chance auf kritische Treffer";
									case 962:
										return "3% Magie erhöht Chance auf kritische Treffer";
									}
								}
							}
						}
					}
					else
					{
						if (l <= 1254)
						{
							if (l <= 1123)
							{
								if (l <= 984)
								{
									switch (l)
									{
									case 975:
										return "Verbesserte Fähigkeit, wenn sie mit Klettern Claws kombiniert";
									case 976:
										break;
									case 977:
										return "Tippen Sie zweimal auf eine Richtung";
									default:
										switch (l)
										{
										case 982:
											return "Erhöht Manaregenerationsrate";
										case 983:
											return "Erhöht Sprunghöhe";
										case 984:
											return "Gewährt Euch eine Chance, Angriffe auszuweichen";
										}
										break;
									}
								}
								else
								{
									switch (l)
									{
									case 997:
										return "'So verwenden: Platz Schlick und Matsch in der extractinator'";
									case 998:
									case 999:
									case 1000:
										break;
									case 1001:
										return "6% erhöht Nahkampf kritische Trefferchance";
									case 1002:
										return "20% Chance, nicht verbrauchen Munition";
									case 1003:
										return "16% erhöht magischen Schaden";
									case 1004:
										return "7% erhöhte Chance auf kritische Treffer";
									case 1005:
										return "5% erhöhte Bewegungsgeschwindigkeit";
									default:
										if (l == 1123)
										{
											return "Geringe Chance zu Verwechslungen führen";
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 1167)
								{
									if (l == 1131)
									{
										return "Drücken Sie UP, um die Schwerkraft zu ändern";
									}
									switch (l)
									{
									case 1159:
										return "Erhöht Günstling Schäden, die durch 10%";
									case 1160:
										return "Erhöht Günstling Schäden, die durch 10%";
									case 1161:
										return "Erhöht Günstling Schäden, die durch 10%";
									case 1163:
										return "Erhöht Sprunghöhe";
									case 1164:
										return "Erhöht Sprunghöhe";
									case 1167:
										return "Erhöht das Klopfen Rückseite Ihrer Schergen";
									}
								}
								else
								{
									switch (l)
									{
									case 1205:
										return "12% erhöht Nahkampfsangriffstempo";
									case 1206:
										return "9% erhöhte Chance auf kritische Treffer reichte";
									case 1207:
										return "Erhöht die maximale Mana um 60";
									case 1208:
										return "2% erhöhte Chance auf kritische Treffer";
									case 1209:
										return "1% erhöhte Chance auf kritische Treffer";
									case 1210:
										return "7% increased Bewegung und Nahkampfsangriffstempo";
									case 1211:
										return "8% erhöhte Bewegungsgeschwindigkeit";
									case 1212:
										return "Iincreases maximalen Manas um 80";
									case 1213:
									case 1214:
										break;
									case 1215:
										return "8% erhöht Nahkampfsangriffstempo";
									case 1216:
										return "7% erhöhte Chance auf kritische Treffer reichte";
									case 1217:
										return "Erhöht maximales Mana um 100";
									case 1218:
										return "3% erhöhte Chance auf kritische Treffer";
									case 1219:
										return "6% erhöhte Bewegungsgeschwindigkeit";
									default:
										switch (l)
										{
										case 1249:
											return "Gibt Bienen, wenn sie beschädigt";
										case 1250:
											return "Erhöht Sprunghöhe und negiert fallen Schäden";
										case 1251:
											return "Erhöht Sprunghöhe und negiert fallen Schäden";
										case 1252:
											return "Erhöht Sprunghöhe und negiert fallen Schäden";
										case 1254:
											return "Rechts klicken, um zu verkleinern";
										}
										break;
									}
								}
							}
						}
						else
						{
							if (l <= 1321)
							{
								if (l <= 1295)
								{
									switch (l)
									{
									case 1282:
										return "Verringert Manaverbrauchs um 5%";
									case 1283:
										return "Verringert Manaverbrauchs um 7%";
									case 1284:
										return "Verringert Manaverbrauchs um 9%";
									case 1285:
										return "Verringert Manaverbrauchs um 11%";
									case 1286:
										return "Verringert Manaverbrauchs um 13%";
									case 1287:
										return "Verringert Manaverbrauchs um 15%";
									default:
										if (l == 1295)
										{
											return "'Oolaa!!'";
										}
										break;
									}
								}
								else
								{
									switch (l)
									{
									case 1300:
										return "Rechts klicken, um zu verkleinern";
									case 1301:
										return "8% Chance auf kritische Treffer";
									default:
										switch (l)
										{
										case 1316:
											return "Feinde sind eher Sie als Ziel";
										case 1317:
											return "Feinde sind eher Sie als Ziel";
										case 1318:
											return "Feinde sind eher Sie als Ziel";
										case 1321:
											return "20% Chance, nicht verbrauchen arrow";
										}
										break;
									}
								}
							}
							else
							{
								if (l <= 1505)
								{
									switch (l)
									{
									case 1336:
										return "Verringert Verteidigung des Ziels";
									case 1337:
									case 1344:
									case 1345:
									case 1346:
									case 1347:
									case 1348:
										break;
									case 1338:
										return "Für den Einsatz mit Hase Kanone";
									case 1339:
										return "'Extrem giftig'";
									case 1340:
										return "Nahkampfangriffe verursachen Venom auf Feinde";
									case 1341:
										return "Fügt Ziel mit Gift";
									case 1342:
										return "Fügt Ziel mit Gift";
									case 1343:
										return "9% erhöht Nahkampfschaden und Geschwindigkeit";
									case 1349:
										return "Explodiert in Konfetti auf Auswirkungen";
									case 1350:
										return "Verursacht Verwirrung";
									case 1351:
										return "Explodiert beim Aufprall";
									case 1352:
										return "Getötete Feinde sinkt mehr Geld";
									case 1353:
										return "Nahkampfangriffe verursachen Feinde verflucht mit Flammen";
									case 1354:
										return "Nahkampfangriffe gesetzt Feinde";
									case 1355:
										return "Nahkampfangriffe Feinde machen fallen mehr Gold";
									case 1356:
										return "Nahkampfangriffe verringern Feinde Verteidigung";
									case 1357:
										return "Nahkampfangriffe verwirren Feinde";
									case 1358:
										return "Nahkampfangriffe verursachen Konfetti zu erscheinen";
									case 1359:
										return "Nahkampfangriffe Gift Feinde";
									default:
										switch (l)
										{
										case 1503:
											return "10% erhöht magischen Schaden und kritische Trefferchance";
										case 1505:
											return "8% erhöhte Bewegungsgeschwindigkeit";
										}
										break;
									}
								}
								else
								{
									switch (l)
									{
									case 1546:
										return "5% erhöhte Chance auf kritische Treffer reichte";
									case 1547:
										return "5% erhöhte Chance auf kritische Treffer reichte";
									case 1548:
										return "5% erhöhte Chance auf kritische Treffer reichte";
									case 1549:
										return "20% Chance, nicht verbrauchen Munition";
									case 1550:
										return "12% erhöhte Bewegungsgeschwindigkeit";
									case 1551:
									case 1552:
										break;
									case 1553:
										return "'Es kam aus den Rand des Weltraums'";
									default:
										if (l == 1595)
										{
											return "Mana wieder her, wenn sie beschädigt";
										}
										break;
									}
								}
							}
						}
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						if (l <= 962)
						{
							if (l <= 686)
							{
								if (l <= 405)
								{
									if (l <= 98)
									{
										if (l == 65)
										{
											return "'Forgiato con la furia del cielo'";
										}
										if (l == 98)
										{
											return "'Mezzo squalo, mezza arma, assolutamente terrificante.'";
										}
									}
									else
									{
										switch (l)
										{
										case 228:
											return "Aumenta la possibilità di colpo critico magico del 3%";
										case 229:
											return "Aumenta la possibilità di colpo critico magico del 3%";
										case 230:
											return "Aumenta la possibilità di colpo critico magico del 3%";
										default:
											switch (l)
											{
											case 371:
												return "Possibilità colpo critico magico aumentate del 9%";
											case 372:
												return "Velocità del corpo a corpo aumentata del 12%";
											case 373:
												return "Possibilità di colpo critico magico aumentata del 6%";
											case 374:
												return "Possibilità di colpo critico aumentata del 3%";
											case 375:
												return "Velocità di movimento aumentata del 10%";
											case 376:
												return "Danno magico aumentato del 15%";
											case 377:
												return "Danno nel corpo a corpo aumentato del 10%";
											case 378:
												return "Possibilità di colpo critico a distanza aumentata del 7%";
											case 379:
												return "Danno aumentato del 5%";
											case 380:
												return "Possibilità di colpo critico aumentata del 3%";
											case 389:
												return "'Trova i pezzi interni'";
											case 394:
												return "Aumenta moltissimo il respiro sott'acqua";
											case 395:
												return "Indica il tempo";
											case 396:
												return "Permette immunità ai blocchi di fuoco";
											case 397:
												return "Permette immunità ai blocchi di fuoco";
											case 399:
												return "Aumenta l'altezza del salto";
											case 400:
												return "Possibilità di colpo critico e danno magico aumentata del 11%";
											case 401:
												return "Danno del corpo a corpo aumentato del 14%";
											case 402:
												return "Possibilità di colpo critico a distanza aumentata dell'8%";
											case 404:
												return "Velocità di movimento aumentata del 5%";
											case 405:
												return "Colui che li indossa può correre velocissimo";
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 533)
									{
										if (l == 434)
										{
											return "Solo il primo colpo consuma munizioni";
										}
										if (l == 533)
										{
											return "'Fratello maggiore del Minishark'";
										}
									}
									else
									{
										switch (l)
										{
										case 552:
											return "Velocità di movimento aumentata del 8%";
										case 553:
											return "Possibilità di colpo critico a distanza aumentata dell'8%";
										case 554:
										case 556:
										case 557:
											break;
										case 555:
											return "Usa le pozioni mana automaticamente in caso di bisogno";
										case 558:
											return "Possibilità di danno magico e colpo critico aumentata del 12%";
										case 559:
											return "Velocità del corpo a corpo aumentata del 10%";
										default:
											if (l == 686)
											{
												return "7% nella velocità di attacco in mischia";
											}
											break;
										}
									}
								}
							}
							else
							{
								if (l <= 908)
								{
									if (l <= 784)
									{
										if (l == 748)
										{
											return "Contenere fino a razzo più veloce";
										}
										switch (l)
										{
										case 771:
											return "Piccolo raggio di esplosione. Non distruggerà le piastrelle";
										case 772:
											return "Piccolo raggio di esplosione. Distruggerà le piastrelle";
										case 773:
											return "Ampio raggio di esplosione. Non distruggerà le piastrelle";
										case 774:
											return "Ampio raggio di esplosione. Distruggerà le piastrelle";
										case 775:
											return "Aumenta la velocità di corsa";
										case 776:
											return "Can miniera Mythril e oricalco";
										case 777:
											return "Possono miniera Adamantite e Titanio";
										case 779:
											return "Utilizza soluzione colorata";
										case 780:
											return "Distribuisce il Purezza";
										case 781:
											return "Distribuisce il Hallow";
										case 782:
											return "Diffonde la corruzione";
										case 783:
											return "Spreads Funghi Incandescente";
										case 784:
											return "Distribuisce il Crimson";
										}
									}
									else
									{
										switch (l)
										{
										case 897:
											return "12% nella velocità di mischia";
										case 898:
											return "Chi lo indossa può funzionare incredibilmente veloce";
										default:
											switch (l)
											{
											case 905:
												return "Higher valued coins do more damage";
											case 907:
												return "Borse di immunità ai blocchi di fuoco";
											case 908:
												return "Borse di immunità ai blocchi di fuoco e 7 secondi di immunità ai lavica";
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 938)
									{
										if (l == 929)
										{
											return "Per l'utilizzo con cannone";
										}
										switch (l)
										{
										case 936:
											return "10% maggiore danno e la velocità mischia";
										case 938:
											return "Solo attivo superiore al 25% della vita";
										}
									}
									else
									{
										if (l == 953)
										{
											return "Miglioramento della capacità, se combinato con Spikes scarpe";
										}
										switch (l)
										{
										case 960:
											return "3% aumento magico possibilità di critico";
										case 961:
											return "3% aumento magico possibilità di critico";
										case 962:
											return "3% aumento magico possibilità di critico";
										}
									}
								}
							}
						}
						else
						{
							if (l <= 1254)
							{
								if (l <= 1123)
								{
									if (l <= 984)
									{
										switch (l)
										{
										case 975:
											return "Miglioramento della capacità, se combinato con artigli Arrampicata";
										case 976:
											break;
										case 977:
											return "Toccare due volte una direzione";
										default:
											switch (l)
											{
											case 982:
												return "Aumenta la velocità di rigenerazione di mana";
											case 983:
												return "Aumenta salto altezza";
											case 984:
												return "Dà la possibilità di schivare gli attacchi";
											}
											break;
										}
									}
									else
									{
										switch (l)
										{
										case 997:
											return "'Per utilizzare: Luogo limo o fango nel extractinator'";
										case 998:
										case 999:
										case 1000:
											break;
										case 1001:
											return "6% aumento mischia possibilità di critico";
										case 1002:
											return "20% di possibilità di non consumare munizioni";
										case 1003:
											return "16% in più di danno magico";
										case 1004:
											return "7% maggiore probabilità di critico";
										case 1005:
											return "5% nella velocità di movimento";
										default:
											if (l == 1123)
											{
												return "Small chance to cause confusion";
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 1167)
									{
										if (l == 1131)
										{
											return "Premere fino a cambiare la gravità";
										}
										switch (l)
										{
										case 1159:
											return "Aumenta il danno minion del 10%";
										case 1160:
											return "Aumenta il danno minion del 10%";
										case 1161:
											return "Aumenta il danno minion del 10%";
										case 1163:
											return "Aumenta salto altezza";
										case 1164:
											return "Aumenta salto altezza";
										case 1167:
											return "Aumenta il knock back dei tuoi servitori";
										}
									}
									else
									{
										switch (l)
										{
										case 1205:
											return "12% nella velocità di mischia";
										case 1206:
											return "9% ha aumentato spaziato possibilità di critico";
										case 1207:
											return "Aumenta mana massimo del 60";
										case 1208:
											return "2% maggiore possibilità di critico";
										case 1209:
											return "1% maggiore possibilità di critico";
										case 1210:
											return "7% increased movement and melee speed";
										case 1211:
											return "8% increased movement speed";
										case 1212:
											return "Aumenta mana massimo del 80";
										case 1213:
										case 1214:
											break;
										case 1215:
											return "8% increased melee speed";
										case 1216:
											return "7% increased ranged critical strike chance";
										case 1217:
											return "Aumenta mana massimo del 100";
										case 1218:
											return "3% maggiore possibilità di critico";
										case 1219:
											return "6% maggiore velocità di movimento";
										default:
											switch (l)
											{
											case 1249:
												return "Rilascia le api se danneggiato";
											case 1250:
												return "Aumenta saltano altezza e nega danno da caduta";
											case 1251:
												return "Aumenta saltano altezza e nega danno da caduta";
											case 1252:
												return "Aumenta saltano altezza e nega danno da caduta";
											case 1254:
												return "Fare clic destro per rimpicciolire";
											}
											break;
										}
									}
								}
							}
							else
							{
								if (l <= 1321)
								{
									if (l <= 1295)
									{
										switch (l)
										{
										case 1282:
											return "Riduce l'uso di mana del 5%";
										case 1283:
											return "Riduce l'uso di mana del 7%";
										case 1284:
											return "Riduce l'uso di mana del 9%";
										case 1285:
											return "Riduce l'uso di mana del 11%";
										case 1286:
											return "Riduce l'uso di mana del 13%";
										case 1287:
											return "Riduce l'uso di mana del 15%";
										default:
											if (l == 1295)
											{
												return "'Oolaa!!'";
											}
											break;
										}
									}
									else
									{
										switch (l)
										{
										case 1300:
											return "Fare clic destro per rimpicciolire";
										case 1301:
											return "8% maggiore possibilità di critico";
										default:
											switch (l)
											{
											case 1316:
												return "I nemici sono più propensi a indirizzare voi";
											case 1317:
												return "I nemici sono più propensi a indirizzare voi";
											case 1318:
												return "I nemici sono più propensi a indirizzare voi";
											case 1321:
												return "20% di possibilità di non consumare freccia";
											}
											break;
										}
									}
								}
								else
								{
									if (l <= 1505)
									{
										switch (l)
										{
										case 1336:
											return "Diminuisce la Difesa del bersaglio";
										case 1337:
										case 1344:
										case 1345:
										case 1346:
										case 1347:
										case 1348:
											break;
										case 1338:
											return "Per l'uso con il coniglietto di cannone";
										case 1339:
											return "'estremamente tossico'";
										case 1340:
											return "Attacchi in mischia infliggono Venom sui nemici";
										case 1341:
											return "Infligge bersaglio con veleno";
										case 1342:
											return "Infligge bersaglio con veleno";
										case 1343:
											return "9% ha aumentato i danni melee e velocità";
										case 1349:
											return "Esplode in coriandoli di impatto";
										case 1350:
											return "provoca confusione";
										case 1351:
											return "Esplode al momento dell'impatto";
										case 1352:
											return "Nemici uccisi scenderanno più soldi";
										case 1353:
											return "Attacchi in mischia infliggono nemici con fiamme maledette";
										case 1354:
											return "Attacchi corpo a corpo impostati nemici in fiamme";
										case 1355:
											return "Attacchi corpo a corpo i nemici fanno cadere più oro";
										case 1356:
											return "Attacchi corpo a corpo diminuiscono nemici difesa";
										case 1357:
											return "Attacchi corpo a corpo confondono i nemici";
										case 1358:
											return "Attacchi melee causano appaia coriandoli";
										case 1359:
											return "Mischia attacca nemici veleno";
										default:
											switch (l)
											{
											case 1503:
												return "10% aumento danno magico e possibilità di critico";
											case 1505:
												return "8% in più di velocità di movimento";
											}
											break;
										}
									}
									else
									{
										switch (l)
										{
										case 1546:
											return "5% aumentato spaziato possibilità di critico";
										case 1547:
											return "5% aumentato spaziato possibilità di critico";
										case 1548:
											return "5% aumentato spaziato possibilità di critico";
										case 1549:
											return "20% di possibilità di non consumare munizioni";
										case 1550:
											return "12% nella velocità di movimento";
										case 1551:
										case 1552:
											break;
										case 1553:
											return "'E 'venuto dal bordo dello spazio'";
										default:
											if (l == 1595)
											{
												return "Ripristina mana se danneggiato";
											}
											break;
										}
									}
								}
							}
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							if (l <= 962)
							{
								if (l <= 686)
								{
									if (l <= 405)
									{
										if (l <= 98)
										{
											if (l == 65)
											{
												return "'Forgée dans la furie du ciel'";
											}
											if (l == 98)
											{
												return "'Moitié requin, moitié fusil, c'est de la balle !'";
											}
										}
										else
										{
											switch (l)
											{
											case 228:
												return "Chance de coup critique magique augmenté de 3 %";
											case 229:
												return "Chance de coup critique magique augmenté de 3 %";
											case 230:
												return "Chance de coup critique magique augmenté de 3 %";
											default:
												switch (l)
												{
												case 371:
													return "Les chances de coup critique magique sont augmentées de 9 %";
												case 372:
													return "La vitesse de mêlée est augmentée de 12 %";
												case 373:
													return "Les chances de coup critique des attaques à distance sont augmentées de 6 %";
												case 374:
													return "Les chances de coup critique sont augmentées de 3 %";
												case 375:
													return "La vitesse de déplacement est augmentée de 10 %";
												case 376:
													return "Augmente les dégâts magiques de 15 %";
												case 377:
													return "Les dégâts de mêlée sont augmentés de 10 %";
												case 378:
													return "Les chances de coup critique des attaques à distance sont augmentées de 7 %";
												case 379:
													return "Les dégâts sont augmentés de 5 %";
												case 380:
													return "Les chances de coup critique sont augmentées de 3 %";
												case 389:
													return "'Pour trouver la paix intérieure'";
												case 394:
													return "Améliore grandement la respiration sous l'eau";
												case 395:
													return "Donne l'heure";
												case 396:
													return "Permet de résister aux blocs de feu";
												case 397:
													return "Permet de résister aux blocs de feu";
												case 399:
													return "Augmente la hauteur des sauts";
												case 400:
													return "Les dégâts et les chances de coup critique de magie sont augmentés de 11 %";
												case 401:
													return "Les dégâts de mêlée sont augmentés de 14 %";
												case 402:
													return "Chances de coup critique des attaques à distance augmentées de 8 %";
												case 404:
													return "La vitesse de déplacement est augmentée de 5 %";
												case 405:
													return "Le porteur peur courir super vite";
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 533)
										{
											if (l == 434)
											{
												return "Seul le premier tir utilise des munitions";
											}
											if (l == 533)
											{
												return "'La version améliorée du minishark'";
											}
										}
										else
										{
											switch (l)
											{
											case 552:
												return "Vitesse de mouvement augmentée de 8 %";
											case 553:
												return "Chances de coup critique des attaques à distance augmentées de 8 %";
											case 554:
											case 556:
											case 557:
												break;
											case 555:
												return "Utilise des potions de mana automatiquement si besoin";
											case 558:
												return "Les chances de coup critique et les dégâts magiques sont augmentés de 12 %";
											case 559:
												return "Vitesse de mêlée augmentée de 10%";
											default:
												if (l == 686)
												{
													return "7% ont augmenté la vitesse d'attaque en mêlée";
												}
												break;
											}
										}
									}
								}
								else
								{
									if (l <= 908)
									{
										if (l <= 784)
										{
											if (l == 748)
											{
												return "contenir jusqu'à fusée rapide";
											}
											switch (l)
											{
											case 771:
												return "Petit rayon de souffle. Ne va pas détruire tuiles";
											case 772:
												return "Petit rayon de souffle. Détruira tuiles";
											case 773:
												return "Grand rayon d'explosion. Ne va pas détruire tuiles";
											case 774:
												return "Grand rayon d'explosion. Détruira tuiles";
											case 775:
												return "Augmente la vitesse en cours d'exécution";
											case 776:
												return "Can mine de mithril et orichalque";
											case 777:
												return "Peut mien adamantite et Titane";
											case 779:
												return "Utilise solution colorée";
											case 780:
												return "Les spreads de la pureté";
											case 781:
												return "Spreads le Hallow";
											case 782:
												return "Répand la corruption";
											case 783:
												return "Spreads Champignons rougeoyants";
											case 784:
												return "Spreads le Crimson";
											}
										}
										else
										{
											switch (l)
											{
											case 897:
												return "12% ont augmenté la vitesse de mêlée";
											case 898:
												return "Le porteur peut courir à une vitesse incroyable";
											default:
												switch (l)
												{
												case 905:
													return "Pièces de plus grande valeur font plus de dégâts";
												case 907:
													return "Accorde l'immunité à des blocs d'incendie";
												case 908:
													return "Accorde l'immunité à des blocs d'incendie et de 7 secondes d'immunité de lave";
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 938)
										{
											if (l == 929)
											{
												return "Pour une utilisation avec des canons";
											}
											switch (l)
											{
											case 936:
												return "10% de dégâts supplémentaires et la vitesse de mêlée";
											case 938:
												return "Seulement actif au-dessus de 25% vie";
											}
										}
										else
										{
											if (l == 953)
											{
												return "Amélioration de la capacité si elle est combinée avec des pointes de chaussures";
											}
											switch (l)
											{
											case 960:
												return "3% ont augmenté magie chances de coup critique";
											case 961:
												return "3% ont augmenté magie chances de coup critique";
											case 962:
												return "3% ont augmenté magie chances de coup critique";
											}
										}
									}
								}
							}
							else
							{
								if (l <= 1254)
								{
									if (l <= 1123)
									{
										if (l <= 984)
										{
											switch (l)
											{
											case 975:
												return "Amélioration de la capacité si elle est combinée avec des griffes d'escalade";
											case 976:
												break;
											case 977:
												return "Appuyez deux fois sur une direction";
											default:
												switch (l)
												{
												case 982:
													return "Augmente la vitesse de régénération de mana";
												case 983:
													return "Augmente la hauteur de saut";
												case 984:
													return "Donne une chance d'esquiver les attaques";
												}
												break;
											}
										}
										else
										{
											switch (l)
											{
											case 997:
												return "'Pour utiliser: La place limon ou de neige fondante dans la extractinator'";
											case 998:
											case 999:
											case 1000:
												break;
											case 1001:
												return "6% ont augmenté mêlée chances de coup critique";
											case 1002:
												return "20% de chances de ne pas consommer de munitions";
											case 1003:
												return "16% d'augmentation des dégâts magiques";
											case 1004:
												return "7% ont augmenté les chances de coup critique";
											case 1005:
												return "5% ont augmenté la vitesse de déplacement";
											default:
												if (l == 1123)
												{
													return "Petite chance de causer de la confusion";
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 1167)
										{
											if (l == 1131)
											{
												return "Appuyez jusqu'à changer la gravité";
											}
											switch (l)
											{
											case 1159:
												return "Augmente les dégâts des familiers de 10%";
											case 1160:
												return "Augmente les dégâts des familiers de 10%";
											case 1161:
												return "Augmente les dégâts des familiers de 10%";
											case 1163:
												return "Augmente la hauteur de saut";
											case 1164:
												return "Augmente la hauteur de saut";
											case 1167:
												return "Augmente l'arrière coup de vos serviteurs";
											}
										}
										else
										{
											switch (l)
											{
											case 1205:
												return "12% ont augmenté la vitesse de mêlée";
											case 1206:
												return "9% ont augmenté varié chances de coup critique";
											case 1207:
												return "Augmente mana maximum de 60";
											case 1208:
												return "2% ont augmenté les chances de coup critique";
											case 1209:
												return "1% ont augmenté les chances de coup critique";
											case 1210:
												return "7% ont augmenté mouvement et la vitesse de mêlée";
											case 1211:
												return "8% a augmenté la vitesse de déplacement";
											case 1212:
												return "Augmente mana maximum de 80";
											case 1213:
											case 1214:
												break;
											case 1215:
												return "8% ont augmenté la vitesse de mêlée";
											case 1216:
												return "7% ont augmenté varié chances de coup critique";
											case 1217:
												return "Augmente mana maximum de 100";
											case 1218:
												return "3% ont augmenté les chances de coup critique";
											case 1219:
												return "6% ont augmenté la vitesse de déplacement";
											default:
												switch (l)
												{
												case 1249:
													return "Libère les abeilles lorsqu'elles sont endommagées";
												case 1250:
													return "Augmente la hauteur de saut et nie dégâts de chute";
												case 1251:
													return "Augmente la hauteur de saut et nie dégâts de chute";
												case 1252:
													return "Augmente la hauteur de saut et nie dégâts de chute";
												case 1254:
													return "Faites un clic droit pour dézoomer";
												}
												break;
											}
										}
									}
								}
								else
								{
									if (l <= 1321)
									{
										if (l <= 1295)
										{
											switch (l)
											{
											case 1282:
												return "Réduit la consommation de mana de 5%";
											case 1283:
												return "Réduit la consommation de mana de 7%";
											case 1284:
												return "Réduit la consommation de mana de 9%";
											case 1285:
												return "Réduit la consommation de mana de 11%";
											case 1286:
												return "Réduit la consommation de mana de 13%";
											case 1287:
												return "Réduit la consommation de mana de 15%";
											default:
												if (l == 1295)
												{
													return "'Oolaa!!'";
												}
												break;
											}
										}
										else
										{
											switch (l)
											{
											case 1300:
												return "Faites un clic droit pour dézoomer";
											case 1301:
												return "8% ont augmenté les chances de coup critique";
											default:
												switch (l)
												{
												case 1316:
													return "Les ennemis sont plus enclins à vous cibler";
												case 1317:
													return "Les ennemis sont plus enclins à vous cibler";
												case 1318:
													return "Les ennemis sont plus enclins à vous cibler";
												case 1321:
													return "20% de chances de ne pas consommer les flèches";
												}
												break;
											}
										}
									}
									else
									{
										if (l <= 1505)
										{
											switch (l)
											{
											case 1336:
												return "Diminue la défense de la cible";
											case 1337:
											case 1344:
											case 1345:
											case 1346:
											case 1347:
											case 1348:
												break;
											case 1338:
												return "Pour une utilisation avec le lapin canon";
											case 1339:
												return "'extrêmement toxique'";
											case 1340:
												return "Melee attacks inflict venom on enemies";
											case 1341:
												return "Inflige cible avec du venin";
											case 1342:
												return "Inflige cible avec du venin";
											case 1343:
												return "9% de dégâts de mêlée et de la vitesse";
											case 1349:
												return "Explose en confettis sur l'impact";
											case 1350:
												return "Provoque une confusion";
											case 1351:
												return "Explose à l'impact";
											case 1352:
												return "Ennemis tués tomberont plus d'argent";
											case 1353:
												return "Les attaques de mêlée infligent des ennemis avec des flammes maudits";
											case 1354:
												return "Les attaques de mêlée des ennemis mis le feu";
											case 1355:
												return "Les attaques de mêlée rendent ennemis laissent tomber plus d'or";
											case 1356:
												return "Les attaques de mêlée réduire la défense des ennemis";
											case 1357:
												return "Les attaques de mêlée confondent ennemis";
											case 1358:
												return "Les attaques de mêlée causent des confettis à comparaître";
											case 1359:
												return "Attaques de mêlée des ennemis de poison";
											default:
												switch (l)
												{
												case 1503:
													return "10% d'augmentation des dégâts magiques et les chances de coup critique";
												case 1505:
													return "8% a augmenté la vitesse de déplacement";
												}
												break;
											}
										}
										else
										{
											switch (l)
											{
											case 1546:
												return "5% ont augmenté varié chances de coup critique";
											case 1547:
												return "5% ont augmenté varié chances de coup critique";
											case 1548:
												return "5% ont augmenté varié chances de coup critique";
											case 1549:
												return "20% de chances de ne pas consommer de munitions";
											case 1550:
												return "12% ont augmenté la vitesse de déplacement";
											case 1551:
											case 1552:
												break;
											case 1553:
												return "'Il venait de la frontière de l'espace'";
											default:
												if (l == 1595)
												{
													return "Restaure mana lorsqu'il est endommagé";
												}
												break;
											}
										}
									}
								}
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								if (l <= 962)
								{
									if (l <= 686)
									{
										if (l <= 405)
										{
											if (l <= 98)
											{
												if (l == 65)
												{
													return "'Forjada por la furia del cielo'";
												}
												if (l == 98)
												{
													return "'Mitad tiburón, mitad arma; realmente asombroso'";
												}
											}
											else
											{
												switch (l)
												{
												case 228:
													return "Aumenta la probabilidad de ataque mágico crítico en un 3%";
												case 229:
													return "Aumenta la probabilidad de ataque mágico crítico en un 3%";
												case 230:
													return "Aumenta la probabilidad de ataque mágico crítico en un 3%";
												default:
													switch (l)
													{
													case 371:
														return "Aumenta la probabilidad de ataque mágico crítico en un 9%";
													case 372:
														return "Aumenta un 12% la velocidad en el cuerpo a cuerpo";
													case 373:
														return "Aumenta la probabilidad de ataque a distancia crítico en un 6%";
													case 374:
														return "Aumenta la probabilidad de ataque crítico en un 3%";
													case 375:
														return "Aumenta en un 10% la velocidad de movimiento";
													case 376:
														return "Aumenta el daño mágico en un 15%";
													case 377:
														return "Aumenta un 10% el daño en el cuerpo a cuerpo";
													case 378:
														return "Aumenta la probabilidad de ataque a distancia crítico en un 7%";
													case 379:
														return "Aumenta el daño en un 5%";
													case 380:
														return "Aumenta la probabilidad de ataque crítico en un 3%";
													case 389:
														return "'Busca en tu interior'";
													case 394:
														return "Permite respirar bajo el agua mucho más tiempo";
													case 395:
														return "Da la hora";
													case 396:
														return "Ofrece inmunidad ante los bloques de fuego";
													case 397:
														return "Ofrece inmunidad ante los bloques de fuego";
													case 399:
														return "Aumenta la altura al saltar";
													case 400:
														return "Aumenta la probabilidad de ataque crítico y daño mágico en un 11%";
													case 401:
														return "Aumenta un 14% el daño en el cuerpo a cuerpo";
													case 402:
														return "Aumenta la probabilidad de ataque a distancia crítico en un 8%";
													case 404:
														return "Aumenta en un 5% la velocidad de movimiento";
													case 405:
														return "Permite correr superrápido";
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 533)
											{
												if (l == 434)
												{
													return "Solo gasta munición el primer disparo";
												}
												if (l == 533)
												{
													return "'El hermano mayor del minitiburón'";
												}
											}
											else
											{
												switch (l)
												{
												case 552:
													return "Aumenta en un 8% la velocidad de movimiento";
												case 553:
													return "Aumenta la probabilidad de ataque a distancia crítico en un 8%";
												case 554:
												case 556:
												case 557:
													break;
												case 555:
													return "Usa de forma automática pociones de maná cuando se necesitan";
												case 558:
													return "Aumenta la probabilidad de ataque crítico y daño mágico en un 12%";
												case 559:
													return "Aumenta un 10% la anticipación en el cuerpo a cuerpo";
												default:
													if (l == 686)
													{
														return "7% más de velocidad de ataque cuerpo a cuerpo";
													}
													break;
												}
											}
										}
									}
									else
									{
										if (l <= 908)
										{
											if (l <= 784)
											{
												if (l == 748)
												{
													return "Sostenga hasta cohete más rápido";
												}
												switch (l)
												{
												case 771:
													return "Pequeño radio de explosión. No la destruiré azulejos";
												case 772:
													return "Pequeño radio de explosión. Destruirá azulejos";
												case 773:
													return "Radio de la explosión grande. No la destruiré azulejos";
												case 774:
													return "Radio de la explosión grande. Destruirá azulejos";
												case 775:
													return "Aumenta la velocidad de carrera";
												case 776:
													return "Puede mina Mythril y Orichalcum";
												case 777:
													return "Puede mina adamantita y Titanio";
												case 779:
													return "Utiliza solución de color";
												case 780:
													return "Extiende la Pureza";
												case 781:
													return "Extiende el Hallow";
												case 782:
													return "Extiende la Corrupción";
												case 783:
													return "Spreads Setas que brillan intensamente";
												case 784:
													return "Extiende el carmesí";
												}
											}
											else
											{
												switch (l)
												{
												case 897:
													return "12% más de velocidad de cuerpo a cuerpo";
												case 898:
													return "El usuario puede correr muy rápido";
												default:
													switch (l)
													{
													case 905:
														return "Monedas de mayor valor hacen más daño";
													case 907:
														return "Otorga inmunidad a los bloques de fuego";
													case 908:
														return "Otorga inmunidad a los bloques de fuego y 7 segundos de inmunidad a la lava";
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 938)
											{
												if (l == 929)
												{
													return "Para el uso con el cañón";
												}
												switch (l)
												{
												case 936:
													return "10% más de daño y velocidad de cuerpo a cuerpo";
												case 938:
													return "Sólo se activa por encima de la vida 25%";
												}
											}
											else
											{
												if (l == 953)
												{
													return "Mejora de la capacidad si se combina con picos de zapatos";
												}
												switch (l)
												{
												case 960:
													return "3% más de probabilidad de golpe crítico mágico";
												case 961:
													return "3% más de probabilidad de golpe crítico mágico";
												case 962:
													return "3% más de probabilidad de golpe crítico mágico";
												}
											}
										}
									}
								}
								else
								{
									if (l <= 1254)
									{
										if (l <= 1123)
										{
											if (l <= 984)
											{
												switch (l)
												{
												case 975:
													return "Mejora de la capacidad si se combina con Garras Escalada";
												case 976:
													break;
												case 977:
													return "Doble toque en una dirección";
												default:
													switch (l)
													{
													case 982:
														return "Aumenta la tasa de regeneración de maná";
													case 983:
														return "Aumenta la altura del salto";
													case 984:
														return "Da la oportunidad de esquivar los ataques";
													}
													break;
												}
											}
											else
											{
												switch (l)
												{
												case 997:
													return "'Modo de empleo: Colocar cieno o lodo en el extractinator'";
												case 998:
												case 999:
												case 1000:
													break;
												case 1001:
													return "6% más de probabilidad de golpe crítico cuerpo a cuerpo";
												case 1002:
													return "20% de probabilidad de no consumir municiones";
												case 1003:
													return "16% más de daño mágico";
												case 1004:
													return "7% más de probabilidad de golpe crítico";
												case 1005:
													return "5% de aumento de la velocidad de movimiento";
												default:
													if (l == 1123)
													{
														return "Pocas posibilidades de causar confusión";
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 1167)
											{
												if (l == 1131)
												{
													return "Pulse para cambiar la gravedad";
												}
												switch (l)
												{
												case 1159:
													return "Aumenta el daño minion en un 10%";
												case 1160:
													return "Aumenta el daño minion en un 10%";
												case 1161:
													return "Aumenta el daño minion en un 10%";
												case 1163:
													return "Aumenta la altura del salto";
												case 1164:
													return "Aumenta la altura del salto";
												case 1167:
													return "Aumenta la parte posterior golpe de sus secuaces";
												}
											}
											else
											{
												switch (l)
												{
												case 1205:
													return "12% más de velocidad de cuerpo a cuerpo";
												case 1206:
													return "9% más de probabilidad de golpe crítico a distancia";
												case 1207:
													return "Aumenta el maná máximo en un 60";
												case 1208:
													return "2% increased critical strike chance";
												case 1209:
													return "1% increased critical strike chance";
												case 1210:
													return "7% increased movement and melee speed";
												case 1211:
													return "8% increased movement speed";
												case 1212:
													return "Aumenta el maná máximo en un 80";
												case 1213:
												case 1214:
													break;
												case 1215:
													return "8% increased melee speed";
												case 1216:
													return "7% increased ranged critical strike chance";
												case 1217:
													return "Aumenta el maná máximo en un 100";
												case 1218:
													return "3% más de probabilidad de golpe crítico";
												case 1219:
													return "6% de aumento de la velocidad de movimiento";
												default:
													switch (l)
													{
													case 1249:
														return "Libera las abejas cuando está dañado";
													case 1250:
														return "Aumenta saltar altura y niega daño por caída";
													case 1251:
														return "Aumenta saltar altura y niega daño por caída";
													case 1252:
														return "Aumenta saltar altura y niega daño por caída";
													case 1254:
														return "Haga clic derecho para alejar";
													}
													break;
												}
											}
										}
									}
									else
									{
										if (l <= 1321)
										{
											if (l <= 1295)
											{
												switch (l)
												{
												case 1282:
													return "Reduce el uso de maná un 5%";
												case 1283:
													return "Reduce el uso de maná un 7%";
												case 1284:
													return "Reduce el uso de maná un 9%";
												case 1285:
													return "Reduce el uso de maná un 11%";
												case 1286:
													return "Reduce el uso de maná un 13%";
												case 1287:
													return "Reduce el uso de maná un 15%";
												default:
													if (l == 1295)
													{
														return "'Oolaa!!'";
													}
													break;
												}
											}
											else
											{
												switch (l)
												{
												case 1300:
													return "Haga clic derecho para alejar";
												case 1301:
													return "8% más de probabilidad de golpe crítico";
												default:
													switch (l)
													{
													case 1316:
														return "Los enemigos son más propensos a que se dirige";
													case 1317:
														return "Los enemigos son más propensos a que se dirige";
													case 1318:
														return "Los enemigos son más propensos a que se dirige";
													case 1321:
														return "20% de probabilidad de no consumir flechas";
													}
													break;
												}
											}
										}
										else
										{
											if (l <= 1505)
											{
												switch (l)
												{
												case 1336:
													return "Disminuye la defensa del objetivo";
												case 1337:
												case 1344:
												case 1345:
												case 1346:
												case 1347:
												case 1348:
													break;
												case 1338:
													return "Para el uso con el conejito de cañón";
												case 1339:
													return "'Extremadamente tóxico'";
												case 1340:
													return "Ataques cuerpo a cuerpo infligen veneno a los enemigos";
												case 1341:
													return "Inflige objetivo con veneno";
												case 1342:
													return "Inflige objetivo con veneno";
												case 1343:
													return "9% más de daño cuerpo a cuerpo y la velocidad";
												case 1349:
													return "Se descompone en confeti sobre el impacto";
												case 1350:
													return "provoca confusión";
												case 1351:
													return "Explota por impacto";
												case 1352:
													return "Enemigos muertos caerán más dinero";
												case 1353:
													return "Ataques cuerpo a cuerpo infligen los enemigos con llamas malditos";
												case 1354:
													return "Ataques cuerpo a cuerpo establecen enemigos en llamas";
												case 1355:
													return "Ataques cuerpo a cuerpo hacen enemigos caen más oro";
												case 1356:
													return "Ataques cuerpo a cuerpo disminuyen defensa enemigos";
												case 1357:
													return "Ataques cuerpo a cuerpo confunde enemigos";
												case 1358:
													return "Ataques cuerpo a cuerpo infligen confetti que aparezca";
												case 1359:
													return "Cuerpo a cuerpo ataca a los enemigos de veneno";
												default:
													switch (l)
													{
													case 1503:
														return "10% más de daño mágico y la probabilidad de golpe crítico";
													case 1505:
														return "8% de aumento de la velocidad de movimiento";
													}
													break;
												}
											}
											else
											{
												switch (l)
												{
												case 1546:
													return "5% más de probabilidad de golpe crítico a distancia";
												case 1547:
													return "5% más de probabilidad de golpe crítico a distancia";
												case 1548:
													return "5% más de probabilidad de golpe crítico a distancia";
												case 1549:
													return "20% de probabilidad de no consumir municiones";
												case 1550:
													return "12% de aumento de la velocidad de movimiento";
												case 1551:
												case 1552:
													break;
												case 1553:
													return "'Venía del borde del espacio'";
												default:
													if (l == 1595)
													{
														return "Restaura mana cuando está dañado";
													}
													break;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			if (!english && Lang.lang > 1)
			{
				return Lang.toolTip2(l, true);
			}
			return "";
		}
		public static string itemName(int l, bool english = false)
		{
			if (Lang.lang <= 1 || english)
			{
				switch (l)
				{
				case -48:
					return "Platinum Bow";
				case -47:
					return "Platinum Hammer";
				case -46:
					return "Platinum Axe";
				case -45:
					return "Platinum Shortsword";
				case -44:
					return "Platinum Broadsword";
				case -43:
					return "Platinum Pickaxe";
				case -42:
					return "Tungsten Bow";
				case -41:
					return "Tungsten Hammer";
				case -40:
					return "Tungsten Axe";
				case -39:
					return "Tungsten Shortsword";
				case -38:
					return "Tungsten Broadsword";
				case -37:
					return "Tungsten Pickaxe";
				case -36:
					return "Lead Bow";
				case -35:
					return "Lead Hammer";
				case -34:
					return "Lead Axe";
				case -33:
					return "Lead Shortsword";
				case -32:
					return "Lead Broadsword";
				case -31:
					return "Lead Pickaxe";
				case -30:
					return "Tin Bow";
				case -29:
					return "Tin Hammer";
				case -28:
					return "Tin Axe";
				case -27:
					return "Tin Shortsword";
				case -26:
					return "Tin Broadsword";
				case -25:
					return "Tin Pickaxe";
				case -24:
					return "Yellow Phasesaber";
				case -23:
					return "White Phasesaber";
				case -22:
					return "Purple Phasesaber";
				case -21:
					return "Green Phasesaber";
				case -20:
					return "Red Phasesaber";
				case -19:
					return "Blue Phasesaber";
				case -18:
					return "Copper Bow";
				case -17:
					return "Copper Hammer";
				case -16:
					return "Copper Axe";
				case -15:
					return "Copper Shortsword";
				case -14:
					return "Copper Broadsword";
				case -13:
					return "Copper Pickaxe";
				case -12:
					return "Silver Bow";
				case -11:
					return "Silver Hammer";
				case -10:
					return "Silver Axe";
				case -9:
					return "Silver Shortsword";
				case -8:
					return "Silver Broadsword";
				case -7:
					return "Silver Pickaxe";
				case -6:
					return "Gold Bow";
				case -5:
					return "Gold Hammer";
				case -4:
					return "Gold Axe";
				case -3:
					return "Gold Shortsword";
				case -2:
					return "Gold Broadsword";
				case -1:
					return "Gold Pickaxe";
				case 1:
					return "Iron Pickaxe";
				case 2:
					return "Dirt Block";
				case 3:
					return "Stone Block";
				case 4:
					return "Iron Broadsword";
				case 5:
					return "Mushroom";
				case 6:
					return "Iron Shortsword";
				case 7:
					return "Iron Hammer";
				case 8:
					return "Torch";
				case 9:
					return "Wood";
				case 10:
					return "Iron Axe";
				case 11:
					return "Iron Ore";
				case 12:
					return "Copper Ore";
				case 13:
					return "Gold Ore";
				case 14:
					return "Silver Ore";
				case 15:
					return "Copper Watch";
				case 16:
					return "Silver Watch";
				case 17:
					return "Gold Watch";
				case 18:
					return "Depth Meter";
				case 19:
					return "Gold Bar";
				case 20:
					return "Copper Bar";
				case 21:
					return "Silver Bar";
				case 22:
					return "Iron Bar";
				case 23:
					return "Gel";
				case 24:
					return "Wooden Sword";
				case 25:
					return "Wooden Door";
				case 26:
					return "Stone Wall";
				case 27:
					return "Acorn";
				case 28:
					return "Lesser Healing Potion";
				case 29:
					return "Life Crystal";
				case 30:
					return "Dirt Wall";
				case 31:
					return "Bottle";
				case 32:
					return "Wooden Table";
				case 33:
					return "Furnace";
				case 34:
					return "Wooden Chair";
				case 35:
					return "Iron Anvil";
				case 36:
					return "Work Bench";
				case 37:
					return "Goggles";
				case 38:
					return "Lens";
				case 39:
					return "Wooden Bow";
				case 40:
					return "Wooden Arrow";
				case 41:
					return "Flaming Arrow";
				case 42:
					return "Shuriken";
				case 43:
					return "Suspicious Looking Eye";
				case 44:
					return "Demon Bow";
				case 45:
					return "War Axe of the Night";
				case 46:
					return "Light's Bane";
				case 47:
					return "Unholy Arrow";
				case 48:
					return "Chest";
				case 49:
					return "Band of Regeneration";
				case 50:
					return "Magic Mirror";
				case 51:
					return "Jester's Arrow";
				case 52:
					return "Angel Statue";
				case 53:
					return "Cloud in a Bottle";
				case 54:
					return "Hermes Boots";
				case 55:
					return "Enchanted Boomerang";
				case 56:
					return "Demonite Ore";
				case 57:
					return "Demonite Bar";
				case 58:
					return "Heart";
				case 59:
					return "Corrupt Seeds";
				case 60:
					return "Vile Mushroom";
				case 61:
					return "Ebonstone Block";
				case 62:
					return "Grass Seeds";
				case 63:
					return "Sunflower";
				case 64:
					return "Vilethorn";
				case 65:
					return "Starfury";
				case 66:
					return "Purification Powder";
				case 67:
					return "Vile Powder";
				case 68:
					return "Rotten Chunk";
				case 69:
					return "Worm Tooth";
				case 70:
					return "Worm Food";
				case 71:
					return "Copper Coin";
				case 72:
					return "Silver Coin";
				case 73:
					return "Gold Coin";
				case 74:
					return "Platinum Coin";
				case 75:
					return "Fallen Star";
				case 76:
					return "Copper Greaves";
				case 77:
					return "Iron Greaves";
				case 78:
					return "Silver Greaves";
				case 79:
					return "Gold Greaves";
				case 80:
					return "Copper Chainmail";
				case 81:
					return "Iron Chainmail";
				case 82:
					return "Silver Chainmail";
				case 83:
					return "Gold Chainmail";
				case 84:
					return "Grappling Hook";
				case 85:
					return "Chain";
				case 86:
					return "Shadow Scale";
				case 87:
					return "Piggy Bank";
				case 88:
					return "Mining Helmet";
				case 89:
					return "Copper Helmet";
				case 90:
					return "Iron Helmet";
				case 91:
					return "Silver Helmet";
				case 92:
					return "Gold Helmet";
				case 93:
					return "Wood Wall";
				case 94:
					return "Wood Platform";
				case 95:
					return "Flintlock Pistol";
				case 96:
					return "Musket";
				case 97:
					return "Musket Ball";
				case 98:
					return "Minishark";
				case 99:
					return "Iron Bow";
				case 100:
					return "Shadow Greaves";
				case 101:
					return "Shadow Scalemail";
				case 102:
					return "Shadow Helmet";
				case 103:
					return "Nightmare Pickaxe";
				case 104:
					return "The Breaker";
				case 105:
					return "Candle";
				case 106:
					return "Copper Chandelier";
				case 107:
					return "Silver Chandelier";
				case 108:
					return "Gold Chandelier";
				case 109:
					return "Mana Crystal";
				case 110:
					return "Lesser Mana Potion";
				case 111:
					return "Band of Starpower";
				case 112:
					return "Flower of Fire";
				case 113:
					return "Magic Missile";
				case 114:
					return "Dirt Rod";
				case 115:
					return "Shadow Orb";
				case 116:
					return "Meteorite";
				case 117:
					return "Meteorite Bar";
				case 118:
					return "Hook";
				case 119:
					return "Flamarang";
				case 120:
					return "Molten Fury";
				case 121:
					return "Fiery Greatsword";
				case 122:
					return "Molten Pickaxe";
				case 123:
					return "Meteor Helmet";
				case 124:
					return "Meteor Suit";
				case 125:
					return "Meteor Leggings";
				case 126:
					return "Bottled Water";
				case 127:
					return "Space Gun";
				case 128:
					return "Rocket Boots";
				case 129:
					return "Gray Brick";
				case 130:
					return "Gray Brick Wall";
				case 131:
					return "Red Brick";
				case 132:
					return "Red Brick Wall";
				case 133:
					return "Clay Block";
				case 134:
					return "Blue Brick";
				case 135:
					return "Blue Brick Wall";
				case 136:
					return "Chain Lantern";
				case 137:
					return "Green Brick";
				case 138:
					return "Green Brick Wall";
				case 139:
					return "Pink Brick";
				case 140:
					return "Pink Brick Wall";
				case 141:
					return "Gold Brick";
				case 142:
					return "Gold Brick Wall";
				case 143:
					return "Silver Brick";
				case 144:
					return "Silver Brick Wall";
				case 145:
					return "Copper Brick";
				case 146:
					return "Copper Brick Wall";
				case 147:
					return "Spike";
				case 148:
					return "Water Candle";
				case 149:
					return "Book";
				case 150:
					return "Cobweb";
				case 151:
					return "Necro Helmet";
				case 152:
					return "Necro Breastplate";
				case 153:
					return "Necro Greaves";
				case 154:
					return "Bone";
				case 155:
					return "Muramasa";
				case 156:
					return "Cobalt Shield";
				case 157:
					return "Aqua Scepter";
				case 158:
					return "Lucky Horseshoe";
				case 159:
					return "Shiny Red Balloon";
				case 160:
					return "Harpoon";
				case 161:
					return "Spiky Ball";
				case 162:
					return "Ball O' Hurt";
				case 163:
					return "Blue Moon";
				case 164:
					return "Handgun";
				case 165:
					return "Water Bolt";
				case 166:
					return "Bomb";
				case 167:
					return "Dynamite";
				case 168:
					return "Grenade";
				case 169:
					return "Sand Block";
				case 170:
					return "Glass";
				case 171:
					return "Sign";
				case 172:
					return "Ash Block";
				case 173:
					return "Obsidian";
				case 174:
					return "Hellstone";
				case 175:
					return "Hellstone Bar";
				case 176:
					return "Mud Block";
				case 177:
					return "Sapphire";
				case 178:
					return "Ruby";
				case 179:
					return "Emerald";
				case 180:
					return "Topaz";
				case 181:
					return "Amethyst";
				case 182:
					return "Diamond";
				case 183:
					return "Glowing Mushroom";
				case 184:
					return "Star";
				case 185:
					return "Ivy Whip";
				case 186:
					return "Breathing Reed";
				case 187:
					return "Flipper";
				case 188:
					return "Healing Potion";
				case 189:
					return "Mana Potion";
				case 190:
					return "Blade of Grass";
				case 191:
					return "Thorn Chakram";
				case 192:
					return "Obsidian Brick";
				case 193:
					return "Obsidian Skull";
				case 194:
					return "Mushroom Grass Seeds";
				case 195:
					return "Jungle Grass Seeds";
				case 196:
					return "Wooden Hammer";
				case 197:
					return "Star Cannon";
				case 198:
					return "Blue Phaseblade";
				case 199:
					return "Red Phaseblade";
				case 200:
					return "Green Phaseblade";
				case 201:
					return "Purple Phaseblade";
				case 202:
					return "White Phaseblade";
				case 203:
					return "Yellow Phaseblade";
				case 204:
					return "Meteor Hamaxe";
				case 205:
					return "Empty Bucket";
				case 206:
					return "Water Bucket";
				case 207:
					return "Lava Bucket";
				case 208:
					return "Jungle Rose";
				case 209:
					return "Stinger";
				case 210:
					return "Vine";
				case 211:
					return "Feral Claws";
				case 212:
					return "Anklet of the Wind";
				case 213:
					return "Staff of Regrowth";
				case 214:
					return "Hellstone Brick";
				case 215:
					return "Whoopie Cushion";
				case 216:
					return "Shackle";
				case 217:
					return "Molten Hamaxe";
				case 218:
					return "Flamelash";
				case 219:
					return "Phoenix Blaster";
				case 220:
					return "Sunfury";
				case 221:
					return "Hellforge";
				case 222:
					return "Clay Pot";
				case 223:
					return "Nature's Gift";
				case 224:
					return "Bed";
				case 225:
					return "Silk";
				case 226:
					return "Lesser Restoration Potion";
				case 227:
					return "Restoration Potion";
				case 228:
					return "Jungle Hat";
				case 229:
					return "Jungle Shirt";
				case 230:
					return "Jungle Pants";
				case 231:
					return "Molten Helmet";
				case 232:
					return "Molten Breastplate";
				case 233:
					return "Molten Greaves";
				case 234:
					return "Meteor Shot";
				case 235:
					return "Sticky Bomb";
				case 236:
					return "Black Lens";
				case 237:
					return "Sunglasses";
				case 238:
					return "Wizard Hat";
				case 239:
					return "Top Hat";
				case 240:
					return "Tuxedo Shirt";
				case 241:
					return "Tuxedo Pants";
				case 242:
					return "Summer Hat";
				case 243:
					return "Bunny Hood";
				case 244:
					return "Plumber's Hat";
				case 245:
					return "Plumber's Shirt";
				case 246:
					return "Plumber's Pants";
				case 247:
					return "Hero's Hat";
				case 248:
					return "Hero's Shirt";
				case 249:
					return "Hero's Pants";
				case 250:
					return "Fish Bowl";
				case 251:
					return "Archaeologist's Hat";
				case 252:
					return "Archaeologist's Jacket";
				case 253:
					return "Archaeologist's Pants";
				case 254:
					return "Black Thread";
				case 255:
					return "Green Thread";
				case 256:
					return "Ninja Hood";
				case 257:
					return "Ninja Shirt";
				case 258:
					return "Ninja Pants";
				case 259:
					return "Leather";
				case 260:
					return "Red Hat";
				case 261:
					return "Goldfish";
				case 262:
					return "Robe";
				case 263:
					return "Robot Hat";
				case 264:
					return "Gold Crown";
				case 265:
					return "Hellfire Arrow";
				case 266:
					return "Sandgun";
				case 267:
					return "Guide Voodoo Doll";
				case 268:
					return "Diving Helmet";
				case 269:
					return "Familiar Shirt";
				case 270:
					return "Familiar Pants";
				case 271:
					return "Familiar Wig";
				case 272:
					return "Demon Scythe";
				case 273:
					return "Night's Edge";
				case 274:
					return "Dark Lance";
				case 275:
					return "Coral";
				case 276:
					return "Cactus";
				case 277:
					return "Trident";
				case 278:
					return "Silver Bullet";
				case 279:
					return "Throwing Knife";
				case 280:
					return "Spear";
				case 281:
					return "Blowpipe";
				case 282:
					return "Glowstick";
				case 283:
					return "Seed";
				case 284:
					return "Wooden Boomerang";
				case 285:
					return "Aglet";
				case 286:
					return "Sticky Glowstick";
				case 287:
					return "Poisoned Knife";
				case 288:
					return "Obsidian Skin Potion";
				case 289:
					return "Regeneration Potion";
				case 290:
					return "Swiftness Potion";
				case 291:
					return "Gills Potion";
				case 292:
					return "Ironskin Potion";
				case 293:
					return "Mana Regeneration Potion";
				case 294:
					return "Magic Power Potion";
				case 295:
					return "Featherfall Potion";
				case 296:
					return "Spelunker Potion";
				case 297:
					return "Invisibility Potion";
				case 298:
					return "Shine Potion";
				case 299:
					return "Night Owl Potion";
				case 300:
					return "Battle Potion";
				case 301:
					return "Thorns Potion";
				case 302:
					return "Water Walking Potion";
				case 303:
					return "Archery Potion";
				case 304:
					return "Hunter Potion";
				case 305:
					return "Gravitation Potion";
				case 306:
					return "Gold Chest";
				case 307:
					return "Daybloom Seeds";
				case 308:
					return "Moonglow Seeds";
				case 309:
					return "Blinkroot Seeds";
				case 310:
					return "Deathweed Seeds";
				case 311:
					return "Waterleaf Seeds";
				case 312:
					return "Fireblossom Seeds";
				case 313:
					return "Daybloom";
				case 314:
					return "Moonglow";
				case 315:
					return "Blinkroot";
				case 316:
					return "Deathweed";
				case 317:
					return "Waterleaf";
				case 318:
					return "Fireblossom";
				case 319:
					return "Shark Fin";
				case 320:
					return "Feather";
				case 321:
					return "Tombstone";
				case 322:
					return "Mime Mask";
				case 323:
					return "Antlion Mandible";
				case 324:
					return "Illegal Gun Parts";
				case 325:
					return "The Doctor's Shirt";
				case 326:
					return "The Doctor's Pants";
				case 327:
					return "Golden Key";
				case 328:
					return "Shadow Chest";
				case 329:
					return "Shadow Key";
				case 330:
					return "Obsidian Brick Wall";
				case 331:
					return "Jungle Spores";
				case 332:
					return "Loom";
				case 333:
					return "Piano";
				case 334:
					return "Dresser";
				case 335:
					return "Bench";
				case 336:
					return "Bathtub";
				case 337:
					return "Red Banner";
				case 338:
					return "Green Banner";
				case 339:
					return "Blue Banner";
				case 340:
					return "Yellow Banner";
				case 341:
					return "Lamp Post";
				case 342:
					return "Tiki Torch";
				case 343:
					return "Barrel";
				case 344:
					return "Chinese Lantern";
				case 345:
					return "Cooking Pot";
				case 346:
					return "Safe";
				case 347:
					return "Skull Lantern";
				case 348:
					return "Trash Can";
				case 349:
					return "Candelabra";
				case 350:
					return "Pink Vase";
				case 351:
					return "Mug";
				case 352:
					return "Keg";
				case 353:
					return "Ale";
				case 354:
					return "Bookcase";
				case 355:
					return "Throne";
				case 356:
					return "Bowl";
				case 357:
					return "Bowl of Soup";
				case 358:
					return "Toilet";
				case 359:
					return "Grandfather Clock";
				case 360:
					return "Armor Statue";
				case 361:
					return "Goblin Battle Standard";
				case 362:
					return "Tattered Cloth";
				case 363:
					return "Sawmill";
				case 364:
					return "Cobalt Ore";
				case 365:
					return "Mythril Ore";
				case 366:
					return "Adamantite Ore";
				case 367:
					return "Pwnhammer";
				case 368:
					return "Excalibur";
				case 369:
					return "Hallowed Seeds";
				case 370:
					return "Ebonsand Block";
				case 371:
					return "Cobalt Hat";
				case 372:
					return "Cobalt Helmet";
				case 373:
					return "Cobalt Mask";
				case 374:
					return "Cobalt Breastplate";
				case 375:
					return "Cobalt Leggings";
				case 376:
					return "Mythril Hood";
				case 377:
					return "Mythril Helmet";
				case 378:
					return "Mythril Hat";
				case 379:
					return "Mythril Chainmail";
				case 380:
					return "Mythril Greaves";
				case 381:
					return "Cobalt Bar";
				case 382:
					return "Mythril Bar";
				case 383:
					return "Cobalt Chainsaw";
				case 384:
					return "Mythril Chainsaw";
				case 385:
					return "Cobalt Drill";
				case 386:
					return "Mythril Drill";
				case 387:
					return "Adamantite Chainsaw";
				case 388:
					return "Adamantite Drill";
				case 389:
					return "Dao of Pow";
				case 390:
					return "Mythril Halberd";
				case 391:
					return "Adamantite Bar";
				case 392:
					return "Glass Wall";
				case 393:
					return "Compass";
				case 394:
					return "Diving Gear";
				case 395:
					return "GPS";
				case 396:
					return "Obsidian Horseshoe";
				case 397:
					return "Obsidian Shield";
				case 398:
					return "Tinkerer's Workshop";
				case 399:
					return "Cloud in a Balloon";
				case 400:
					return "Adamantite Headgear";
				case 401:
					return "Adamantite Helmet";
				case 402:
					return "Adamantite Mask";
				case 403:
					return "Adamantite Breastplate";
				case 404:
					return "Adamantite Leggings";
				case 405:
					return "Spectre Boots";
				case 406:
					return "Adamantite Glaive";
				case 407:
					return "Toolbelt";
				case 408:
					return "Pearlsand Block";
				case 409:
					return "Pearlstone Block";
				case 410:
					return "Mining Shirt";
				case 411:
					return "Mining Pants";
				case 412:
					return "Pearlstone Brick";
				case 413:
					return "Iridescent Brick";
				case 414:
					return "Mudstone Block";
				case 415:
					return "Cobalt Brick";
				case 416:
					return "Mythril Brick";
				case 417:
					return "Pearlstone Brick Wall";
				case 418:
					return "Iridescent Brick Wall";
				case 419:
					return "Mudstone Brick Wall";
				case 420:
					return "Cobalt Brick Wall";
				case 421:
					return "Mythril Brick Wall";
				case 422:
					return "Holy Water";
				case 423:
					return "Unholy Water";
				case 424:
					return "Silt Block";
				case 425:
					return "Fairy Bell";
				case 426:
					return "Breaker Blade";
				case 427:
					return "Blue Torch";
				case 428:
					return "Red Torch";
				case 429:
					return "Green Torch";
				case 430:
					return "Purple Torch";
				case 431:
					return "White Torch";
				case 432:
					return "Yellow Torch";
				case 433:
					return "Demon Torch";
				case 434:
					return "Clockwork Assault Rifle";
				case 435:
					return "Cobalt Repeater";
				case 436:
					return "Mythril Repeater";
				case 437:
					return "Dual Hook";
				case 438:
					return "Star Statue";
				case 439:
					return "Sword Statue";
				case 440:
					return "Slime Statue";
				case 441:
					return "Goblin Statue";
				case 442:
					return "Shield Statue";
				case 443:
					return "Bat Statue";
				case 444:
					return "Fish Statue";
				case 445:
					return "Bunny Statue";
				case 446:
					return "Skeleton Statue";
				case 447:
					return "Reaper Statue";
				case 448:
					return "Woman Statue";
				case 449:
					return "Imp Statue";
				case 450:
					return "Gargoyle Statue";
				case 451:
					return "Gloom Statue";
				case 452:
					return "Hornet Statue";
				case 453:
					return "Bomb Statue";
				case 454:
					return "Crab Statue";
				case 455:
					return "Hammer Statue";
				case 456:
					return "Potion Statue";
				case 457:
					return "Spear Statue";
				case 458:
					return "Cross Statue";
				case 459:
					return "Jellyfish Statue";
				case 460:
					return "Bow Statue";
				case 461:
					return "Boomerang Statue";
				case 462:
					return "Boot Statue";
				case 463:
					return "Chest Statue";
				case 464:
					return "Bird Statue";
				case 465:
					return "Axe Statue";
				case 466:
					return "Corrupt Statue";
				case 467:
					return "Tree Statue";
				case 468:
					return "Anvil Statue";
				case 469:
					return "Pickaxe Statue";
				case 470:
					return "Mushroom Statue";
				case 471:
					return "Eyeball Statue";
				case 472:
					return "Pillar Statue";
				case 473:
					return "Heart Statue";
				case 474:
					return "Pot Statue";
				case 475:
					return "Sunflower Statue";
				case 476:
					return "King Statue";
				case 477:
					return "Queen Statue";
				case 478:
					return "Piranha Statue";
				case 479:
					return "Planked Wall";
				case 480:
					return "Wooden Beam";
				case 481:
					return "Adamantite Repeater";
				case 482:
					return "Adamantite Sword";
				case 483:
					return "Cobalt Sword";
				case 484:
					return "Mythril Sword";
				case 485:
					return "Moon Charm";
				case 486:
					return "Ruler";
				case 487:
					return "Crystal Ball";
				case 488:
					return "Disco Ball";
				case 489:
					return "Sorcerer Emblem";
				case 490:
					return "Warrior Emblem";
				case 491:
					return "Ranger Emblem";
				case 492:
					return "Demon Wings";
				case 493:
					return "Angel Wings";
				case 494:
					return "Magical Harp";
				case 495:
					return "Rainbow Rod";
				case 496:
					return "Ice Rod";
				case 497:
					return "Neptune's Shell";
				case 498:
					return "Mannequin";
				case 499:
					return "Greater Healing Potion";
				case 500:
					return "Greater Mana Potion";
				case 501:
					return "Pixie Dust";
				case 502:
					return "Crystal Shard";
				case 503:
					return "Clown Hat";
				case 504:
					return "Clown Shirt";
				case 505:
					return "Clown Pants";
				case 506:
					return "Flamethrower";
				case 507:
					return "Bell";
				case 508:
					return "Harp";
				case 509:
					return "Wrench";
				case 510:
					return "Wire Cutter";
				case 511:
					return "Active Stone Block";
				case 512:
					return "Inactive Stone Block";
				case 513:
					return "Lever";
				case 514:
					return "Laser Rifle";
				case 515:
					return "Crystal Bullet";
				case 516:
					return "Holy Arrow";
				case 517:
					return "Magic Dagger";
				case 518:
					return "Crystal Storm";
				case 519:
					return "Cursed Flames";
				case 520:
					return "Soul of Light";
				case 521:
					return "Soul of Night";
				case 522:
					return "Cursed Flame";
				case 523:
					return "Cursed Torch";
				case 524:
					return "Adamantite Forge";
				case 525:
					return "Mythril Anvil";
				case 526:
					return "Unicorn Horn";
				case 527:
					return "Dark Shard";
				case 528:
					return "Light Shard";
				case 529:
					return "Red Pressure Plate";
				case 530:
					return "Wire";
				case 531:
					return "Spell Tome";
				case 532:
					return "Star Cloak";
				case 533:
					return "Megashark";
				case 534:
					return "Shotgun";
				case 535:
					return "Philosopher's Stone";
				case 536:
					return "Titan Glove";
				case 537:
					return "Cobalt Naginata";
				case 538:
					return "Switch";
				case 539:
					return "Dart Trap";
				case 540:
					return "Boulder";
				case 541:
					return "Green Pressure Plate";
				case 542:
					return "Gray Pressure Plate";
				case 543:
					return "Brown Pressure Plate";
				case 544:
					return "Mechanical Eye";
				case 545:
					return "Cursed Arrow";
				case 546:
					return "Cursed Bullet";
				case 547:
					return "Soul of Fright";
				case 548:
					return "Soul of Might";
				case 549:
					return "Soul of Sight";
				case 550:
					return "Gungnir";
				case 551:
					return "Hallowed Plate Mail";
				case 552:
					return "Hallowed Greaves";
				case 553:
					return "Hallowed Helmet";
				case 554:
					return "Cross Necklace";
				case 555:
					return "Mana Flower";
				case 556:
					return "Mechanical Worm";
				case 557:
					return "Mechanical Skull";
				case 558:
					return "Hallowed Headgear";
				case 559:
					return "Hallowed Mask";
				case 560:
					return "Slime Crown";
				case 561:
					return "Light Disc";
				case 562:
					return "Music Box (Overworld Day)";
				case 563:
					return "Music Box (Eerie)";
				case 564:
					return "Music Box (Night)";
				case 565:
					return "Music Box (Title)";
				case 566:
					return "Music Box (Underground)";
				case 567:
					return "Music Box (Boss 1)";
				case 568:
					return "Music Box (Jungle)";
				case 569:
					return "Music Box (Corruption)";
				case 570:
					return "Music Box (Underground Corruption)";
				case 571:
					return "Music Box (The Hallow)";
				case 572:
					return "Music Box (Boss 2)";
				case 573:
					return "Music Box (Underground Hallow)";
				case 574:
					return "Music Box (Boss 3)";
				case 575:
					return "Soul of Flight";
				case 576:
					return "Music Box";
				case 577:
					return "Demonite Brick";
				case 578:
					return "Hallowed Repeater";
				case 579:
					return "Drax";
				case 580:
					return "Explosives";
				case 581:
					return "Inlet Pump";
				case 582:
					return "Outlet Pump";
				case 583:
					return "1 Second Timer";
				case 584:
					return "3 Second Timer";
				case 585:
					return "5 Second Timer";
				case 586:
					return "Candy Cane Block";
				case 587:
					return "Candy Cane Wall";
				case 588:
					return "Santa Hat";
				case 589:
					return "Santa Shirt";
				case 590:
					return "Santa Pants";
				case 591:
					return "Green Candy Cane Block";
				case 592:
					return "Green Candy Cane Wall";
				case 593:
					return "Snow Block";
				case 594:
					return "Snow Brick";
				case 595:
					return "Snow Brick Wall";
				case 596:
					return "Blue Light";
				case 597:
					return "Red Light";
				case 598:
					return "Green Light";
				case 599:
					return "Blue Present";
				case 600:
					return "Green Present";
				case 601:
					return "Yellow Present";
				case 602:
					return "Snow Globe";
				case 603:
					return "Carrot";
				case 604:
					return "Adamantite Beam";
				case 605:
					return "Adamantite Beam Wall";
				case 606:
					return "Demonite Brick Wall";
				case 607:
					return "Sandstone Brick";
				case 608:
					return "Sandstone Brick Wall";
				case 609:
					return "Ebonstone Brick";
				case 610:
					return "Ebonstone Brick Wall";
				case 611:
					return "Red Stucco";
				case 612:
					return "Yellow Stucco";
				case 613:
					return "Green Stucco";
				case 614:
					return "Gray Stucco";
				case 615:
					return "Red Stucco Wall";
				case 616:
					return "Yellow Stucco Wall";
				case 617:
					return "Green Stucco Wall";
				case 618:
					return "Gray Stucco Wall";
				case 619:
					return "Ebonwood";
				case 620:
					return "Rich Mahogany";
				case 621:
					return "Pearlwood";
				case 622:
					return "Ebonwood Wall";
				case 623:
					return "Rich Mahogany Wall";
				case 624:
					return "Pearlwood Wall";
				case 625:
					return "Ebonwood Chest";
				case 626:
					return "Rich Mahogany Chest";
				case 627:
					return "Pearlwood Chest";
				case 628:
					return "Ebonwood Chair";
				case 629:
					return "Rich Mahogany Chair";
				case 630:
					return "Pearlwood Chair";
				case 631:
					return "Ebonwood Platform";
				case 632:
					return "Rich Mahogany Platform";
				case 633:
					return "Pearlwood Platform";
				case 634:
					return "Bone Platform";
				case 635:
					return "Ebonwood Work Bench";
				case 636:
					return "Rich Mahogany Work Bench";
				case 637:
					return "Pearlwood Work Bench";
				case 638:
					return "Ebonwood Table";
				case 639:
					return "Rich Mahogany Table";
				case 640:
					return "Pearlwood Table";
				case 641:
					return "Ebonwood Piano";
				case 642:
					return "Rich Mahogany Piano";
				case 643:
					return "Pearlwood Piano";
				case 644:
					return "Ebonwood Bed";
				case 645:
					return "Rich Mahogany Bed";
				case 646:
					return "Pearlwood Bed";
				case 647:
					return "Ebonwood Dresser";
				case 648:
					return "Rich Mahogany Dresser";
				case 649:
					return "Pearlwood Dresser";
				case 650:
					return "Ebonwood Door";
				case 651:
					return "Rich Mahogany Door";
				case 652:
					return "Pearlwood Door";
				case 653:
					return "Ebonwood Sword";
				case 654:
					return "Ebonwood Hammer";
				case 655:
					return "Ebonwood Bow";
				case 656:
					return "Rich Mahogany Sword";
				case 657:
					return "Rich Mahogany Hammer";
				case 658:
					return "Rich Mahogany Bow";
				case 659:
					return "Pearlwood Sword";
				case 660:
					return "Pearlwood Hammer";
				case 661:
					return "Pearlwood Bow";
				case 662:
					return "Rainbow Brick";
				case 663:
					return "Rainbow Brick Wall";
				case 664:
					return "Ice Block";
				case 665:
					return "Red's Wings";
				case 666:
					return "Red's Helmet";
				case 667:
					return "Red's Breastplate";
				case 668:
					return "Red's Leggings";
				case 669:
					return "Fish";
				case 670:
					return "Ice Boomerang";
				case 671:
					return "Keybrand";
				case 672:
					return "Cutlass";
				case 673:
					return "Icemourne";
				case 674:
					return "True Excalibur";
				case 675:
					return "True Night's Edge";
				case 676:
					return "Frostbrand";
				case 677:
					return "Scythe";
				case 678:
					return "Soul Scythe";
				case 679:
					return "Tactical Shotgun";
				case 680:
					return "Ivy Chest";
				case 681:
					return "Ice Chest";
				case 682:
					return "Marrow";
				case 683:
					return "Unholy Trident";
				case 684:
					return "Frost Helmet";
				case 685:
					return "Frost Breastplate";
				case 686:
					return "Frost Leggings";
				case 687:
					return "Tin Helmet";
				case 688:
					return "Tin Chainmail";
				case 689:
					return "Tin Greaves";
				case 690:
					return "Lead Helmet";
				case 691:
					return "Lead Chainmail";
				case 692:
					return "Lead Greaves";
				case 693:
					return "Tungsten Helmet";
				case 694:
					return "Tungsten Chainmail";
				case 695:
					return "Tungsten Greaves";
				case 696:
					return "Platinum Helmet";
				case 697:
					return "Platinum Chainmail";
				case 698:
					return "Platinum Greaves";
				case 699:
					return "Tin Ore";
				case 700:
					return "Lead Ore";
				case 701:
					return "Tungsten Ore";
				case 702:
					return "Platinum Ore";
				case 703:
					return "Tin Bar";
				case 704:
					return "Lead Bar";
				case 705:
					return "Tungsten Bar";
				case 706:
					return "Platinum Bar";
				case 707:
					return "Tin Watch";
				case 708:
					return "Tungsten Watch";
				case 709:
					return "Platinum Watch";
				case 710:
					return "Tin Chandelier";
				case 711:
					return "Tungsten Chandelier";
				case 712:
					return "Platinum Chandelier";
				case 713:
					return "Platinum Candle";
				case 714:
					return "Platinum Candelabra";
				case 715:
					return "Platinum Crown";
				case 716:
					return "Lead Anvil";
				case 717:
					return "Tin Brick";
				case 718:
					return "Tungsten Brick";
				case 719:
					return "Platinum Brick";
				case 720:
					return "Tin Brick Wall";
				case 721:
					return "Tungsten Brick Wall";
				case 722:
					return "Platinum Brick Wall";
				case 723:
					return "Beam Sword";
				case 724:
					return "Ice Blade";
				case 725:
					return "Ice Bow";
				case 726:
					return "Frost Staff";
				case 727:
					return "Wood Helmet";
				case 728:
					return "Wood Breastplate";
				case 729:
					return "Wood Greaves";
				case 730:
					return "Ebonwood Helmet";
				case 731:
					return "Ebonwood Breastplate";
				case 732:
					return "Ebonwood Greaves";
				case 733:
					return "Rich Mahogany Helmet";
				case 734:
					return "Rich Mahogany Breastplate";
				case 735:
					return "Rich Mahogany Greaves";
				case 736:
					return "Pearlwood Helmet";
				case 737:
					return "Pearlwood Breastplate";
				case 738:
					return "Pearlwood Greaves";
				case 739:
					return "Amethyst Staff";
				case 740:
					return "Topaz Staff";
				case 741:
					return "Sapphire Staff";
				case 742:
					return "Emerald Staff";
				case 743:
					return "Ruby Staff";
				case 744:
					return "Diamond Staff";
				case 745:
					return "Grass Wall";
				case 746:
					return "Jungle Wall";
				case 747:
					return "Flower Wall";
				case 748:
					return "Jetpack";
				case 749:
					return "Butterfly Wings";
				case 750:
					return "Cactus Wall";
				case 751:
					return "Cloud";
				case 752:
					return "Cloud Wall";
				case 753:
					return "Seaweed";
				case 754:
					return "Rune Hat";
				case 755:
					return "Rune Robe";
				case 756:
					return "Mushroom Spear";
				case 757:
					return "Terra Blade";
				case 758:
					return "Grenade Launcher";
				case 759:
					return "Rocket Launcher";
				case 760:
					return "Proximity Mine Launcher";
				case 761:
					return "Fairy Wings";
				case 762:
					return "Slime Block";
				case 763:
					return "Flesh Block";
				case 764:
					return "Mushroom Wall";
				case 765:
					return "Rain Cloud";
				case 766:
					return "Bone Block";
				case 767:
					return "Frozen Slime Block";
				case 768:
					return "Bone Block Wall";
				case 769:
					return "Slime Block Wall";
				case 770:
					return "Flesh Block Wall";
				case 771:
					return "Rocket I";
				case 772:
					return "Rocket II";
				case 773:
					return "Rocket III";
				case 774:
					return "Rocket IV";
				case 775:
					return "Asphalt Block";
				case 776:
					return "Cobalt Pickaxe";
				case 777:
					return "Mythril Pickaxe";
				case 778:
					return "Adamantite Pickaxe";
				case 779:
					return "Clentaminator";
				case 780:
					return "Green Solution";
				case 781:
					return "Blue Solution";
				case 782:
					return "Purple Solution";
				case 783:
					return "Dark Blue Solution";
				case 784:
					return "Red Solution";
				case 785:
					return "Harpy Wings";
				case 786:
					return "Bone Wings";
				case 787:
					return "Hammush";
				case 788:
					return "Nettle Burst";
				case 789:
					return "Ankh Banner";
				case 790:
					return "Snake Banner";
				case 791:
					return "Omega Banner";
				case 792:
					return "Crimson Helmet";
				case 793:
					return "Crimson Scalemail";
				case 794:
					return "Crimson Greaves";
				case 795:
					return "Blood Butcherer";
				case 796:
					return "Tendon Bow";
				case 797:
					return "Flesh Grinder";
				case 798:
					return "Deathbringer Pickaxe";
				case 799:
					return "Blood Lust Cluster";
				case 800:
					return "The Undertaker";
				case 801:
					return "The Meatball";
				case 802:
					return "The Rotted Fork";
				case 803:
					return "Eskimo Hood";
				case 804:
					return "Eskimo Coat";
				case 805:
					return "Eskimo Pants";
				case 806:
					return "Living Wood Chair";
				case 807:
					return "Cactus Chair";
				case 808:
					return "Bone Chair";
				case 809:
					return "Flesh Chair";
				case 810:
					return "Mushroom Chair";
				case 811:
					return "Bone Work Bench";
				case 812:
					return "Cactus Work Bench";
				case 813:
					return "Flesh Work Bench";
				case 814:
					return "Mushroom Work Bench";
				case 815:
					return "Slime Work Bench";
				case 816:
					return "Cactus Door";
				case 817:
					return "Flesh Door";
				case 818:
					return "Mushroom Door";
				case 819:
					return "Living Wood Door";
				case 820:
					return "Bone Door";
				case 821:
					return "Flame Wings";
				case 822:
					return "Frozen Wings";
				case 823:
					return "Ghost Wings";
				case 824:
					return "Sunplate Block";
				case 825:
					return "Disc Wall";
				case 826:
					return "Skyware Chair";
				case 827:
					return "Bone Table";
				case 828:
					return "Flesh Table";
				case 829:
					return "Living Wood Table";
				case 830:
					return "Skyware Table";
				case 831:
					return "Living Wood Chest";
				case 832:
					return "Living Wood Wand";
				case 833:
					return "Purple Ice Block";
				case 834:
					return "Pink Ice Block";
				case 835:
					return "Red Ice Block";
				case 836:
					return "Crimstone Block";
				case 837:
					return "Skyware Door";
				case 838:
					return "Skyware Chest";
				case 839:
					return "Steampunk Hat";
				case 840:
					return "Steampunk Shirt";
				case 841:
					return "Steampunk Pants";
				case 842:
					return "Bee Hat";
				case 843:
					return "Bee Shirt";
				case 844:
					return "Bee Pants";
				case 845:
					return "World Banner";
				case 846:
					return "Sun Banner";
				case 847:
					return "Gravity Banner";
				case 848:
					return "Pharaoh's Mask";
				case 849:
					return "Actuator";
				case 850:
					return "Blue Wrench";
				case 851:
					return "Green Wrench";
				case 852:
					return "Blue Pressure Plate";
				case 853:
					return "Yellow Pressure Plate";
				case 854:
					return "Discount Card";
				case 855:
					return "Lucky Coin";
				case 856:
					return "Unicorn on a Stick";
				case 857:
					return "Sandstorm in a Bottle";
				case 858:
					return "bl";
				case 859:
					return "Beach Ball";
				case 860:
					return "Charm of Myths";
				case 861:
					return "Moon Shell";
				case 862:
					return "Star Veil";
				case 863:
					return "Water Walking Boots";
				case 864:
					return "Tiara";
				case 865:
					return "Princess Dress";
				case 866:
					return "Pharaoh's Robe";
				case 867:
					return "Green Cap";
				case 868:
					return "Mushroom Cap";
				case 869:
					return "Tam O' Shanter";
				case 870:
					return "Mummy Mask";
				case 871:
					return "Mummy Shirt";
				case 872:
					return "Mummy Pants";
				case 873:
					return "Cowboy Hat";
				case 874:
					return "Cowboy Jacket";
				case 875:
					return "Cowboy Pants";
				case 876:
					return "Pirate Hat";
				case 877:
					return "Pirate Shirt";
				case 878:
					return "Pirate Pants";
				case 879:
					return "Viking Helmet";
				case 880:
					return "Crimtane Ore";
				case 881:
					return "Cactus Sword";
				case 882:
					return "Cactus Pickaxe";
				case 883:
					return "Ice Brick";
				case 884:
					return "Ice Brick Wall";
				case 885:
					return "Adhesive Bandage";
				case 886:
					return "Armor Polish";
				case 887:
					return "Bezoar";
				case 888:
					return "Blindfold";
				case 889:
					return "Fast Clock";
				case 890:
					return "Megaphone";
				case 891:
					return "Nazar";
				case 892:
					return "Vitamins";
				case 893:
					return "Trifold Map";
				case 894:
					return "Cactus Helmet";
				case 895:
					return "Cactus Breastplate";
				case 896:
					return "Cactus Leggings";
				case 897:
					return "Power Glove";
				case 898:
					return "Lightning Boots";
				case 899:
					return "Sun Stone";
				case 900:
					return "Moon Stone";
				case 901:
					return "Armor Bracing";
				case 902:
					return "Medicated Bandage";
				case 903:
					return "The Plan";
				case 904:
					return "Countercurse Mantra";
				case 905:
					return "Coin Gun";
				case 906:
					return "Lava Charm";
				case 907:
					return "Obsidian Water Walking Boots";
				case 908:
					return "Lava Waders";
				case 909:
					return "Pure Water Fountain";
				case 910:
					return "Desert Water Fountain";
				case 911:
					return "Shadewood";
				case 912:
					return "Shadewood Door";
				case 913:
					return "Shadewood Platform";
				case 914:
					return "Shadewood Chest";
				case 915:
					return "Shadewood Chair";
				case 916:
					return "Shadewood Work Bench";
				case 917:
					return "Shadewood Table";
				case 918:
					return "Shadewood Dresser";
				case 919:
					return "Shadewood Piano";
				case 920:
					return "Shadewood Bed";
				case 921:
					return "Shadewood Sword";
				case 922:
					return "Shadewood Hammer";
				case 923:
					return "Shadewood Bow";
				case 924:
					return "Shadewood Helmet";
				case 925:
					return "Shadewood Breastplate";
				case 926:
					return "Shadewood Greaves";
				case 927:
					return "Shadewood Wall";
				case 928:
					return "Cannon";
				case 929:
					return "Cannonball";
				case 930:
					return "Flare Gun";
				case 931:
					return "Flare";
				case 932:
					return "Bone Wand";
				case 933:
					return "Leaf Wand";
				case 934:
					return "Flying Carpet";
				case 935:
					return "Avenger Emblem";
				case 936:
					return "Mechanical Glove";
				case 937:
					return "Land Mine";
				case 938:
					return "Paladin's Shield";
				case 939:
					return "Web Slinger";
				case 940:
					return "Jungle Water Fountain";
				case 941:
					return "Icy Water Fountain";
				case 942:
					return "Corrupt Water Fountain";
				case 943:
					return "Crimson Water Fountain";
				case 944:
					return "Hallowed Water Fountain";
				case 945:
					return "Blood Water Fountain";
				case 946:
					return "Umbrella";
				case 947:
					return "Chlorophyte Ore";
				case 948:
					return "Steampunk Wings";
				case 949:
					return "Snowball";
				case 950:
					return "Ice Skates";
				case 951:
					return "Snowball Launcher";
				case 952:
					return "Web Covered Chest";
				case 953:
					return "Climbing Claws";
				case 954:
					return "Ancient Iron Helmet";
				case 955:
					return "Ancient Gold Helmet";
				case 956:
					return "Ancient Shadow Helmet";
				case 957:
					return "Ancient Shadow Scalemail";
				case 958:
					return "Ancient Shadow Greaves";
				case 959:
					return "Ancient Necro Helmet";
				case 960:
					return "Ancient Cobalt Helmet";
				case 961:
					return "Ancient Cobalt Breastplate";
				case 962:
					return "Ancient Cobalt Leggings";
				case 963:
					return "Black Belt";
				case 964:
					return "Boomstick";
				case 965:
					return "Rope";
				case 966:
					return "Campfire";
				case 967:
					return "Marshmallow";
				case 968:
					return "Marshmallow on a Stick";
				case 969:
					return "Cooked Marshmallow";
				case 970:
					return "Red Rocket";
				case 971:
					return "Green Rocket";
				case 972:
					return "Blue Rocket";
				case 973:
					return "Yellow Rocket";
				case 974:
					return "Ice Torch";
				case 975:
					return "Shoe Spikes";
				case 976:
					return "Tiger Climbing Gear";
				case 977:
					return "Tabi";
				case 978:
					return "Pink Eskimo Hood";
				case 979:
					return "Pink Eskimo Coat";
				case 980:
					return "Pink Eskimo Pants";
				case 981:
					return "Pink Thread";
				case 982:
					return "Mana Regeneration Band";
				case 983:
					return "Sandstorm in a Balloon";
				case 984:
					return "Master Ninja Gear";
				case 985:
					return "Rope Coil";
				case 986:
					return "Blowgun";
				case 987:
					return "Blizzard in a Bottle";
				case 988:
					return "Frostburn Arrow";
				case 989:
					return "Enchanted Sword";
				case 990:
					return "Pickaxe Axe";
				case 991:
					return "Cobalt Waraxe";
				case 992:
					return "Mythril Waraxe";
				case 993:
					return "Adamantite Waraxe";
				case 994:
					return "Eater's Bone";
				case 995:
					return "Blend-O-Matic";
				case 996:
					return "Meat Grinder";
				case 997:
					return "Extractinator";
				case 998:
					return "Solidifier";
				case 999:
					return "Amber";
				case 1000:
					return "Confetti Gun";
				case 1001:
					return "Chlorophyte Mask";
				case 1002:
					return "Chlorophyte Helmet";
				case 1003:
					return "Chlorophyte Headgear";
				case 1004:
					return "Chlorophyte Plate Mail";
				case 1005:
					return "Chlorophyte Greaves";
				case 1006:
					return "Chlorophyte Bar";
				case 1007:
					return "Red Dye";
				case 1008:
					return "Orange Dye";
				case 1009:
					return "Yellow Dye";
				case 1010:
					return "Lime Dye";
				case 1011:
					return "Green Dye";
				case 1012:
					return "Teal Dye";
				case 1013:
					return "Cyan Dye";
				case 1014:
					return "Sky Blue Dye";
				case 1015:
					return "Blue Dye";
				case 1016:
					return "Purple Dye";
				case 1017:
					return "Violet Dye";
				case 1018:
					return "Pink Dye";
				case 1019:
					return "Red and Black Dye";
				case 1020:
					return "Orange and Black Dye";
				case 1021:
					return "Yellow and Black Dye";
				case 1022:
					return "Lime and Black Dye";
				case 1023:
					return "Green and Black Dye";
				case 1024:
					return "Teal and Black Dye";
				case 1025:
					return "Cyan and Black Dye";
				case 1026:
					return "Sky Blue and Black Dye";
				case 1027:
					return "Blue and Black Dye";
				case 1028:
					return "Purple and Black Dye";
				case 1029:
					return "Violet and Black Dye";
				case 1030:
					return "Pink and Black Dye";
				case 1031:
					return "Flame Dye";
				case 1032:
					return "Flame and Black Dye";
				case 1033:
					return "Green Flame Dye";
				case 1034:
					return "Green Flame and Black Dye";
				case 1035:
					return "Blue Flame Dye";
				case 1036:
					return "Blue Flame and Black Dye";
				case 1037:
					return "Silver Dye";
				case 1038:
					return "Bright Red Dye";
				case 1039:
					return "Bright Orange Dye";
				case 1040:
					return "Bright Yellow Dye";
				case 1041:
					return "Bright Lime Dye";
				case 1042:
					return "Bright Green Dye";
				case 1043:
					return "Bright Teal Dye";
				case 1044:
					return "Bright Cyan Dye";
				case 1045:
					return "Bright Sky Blue Dye";
				case 1046:
					return "Bright Blue Dye";
				case 1047:
					return "Bright Purple Dye";
				case 1048:
					return "Bright Violet Dye";
				case 1049:
					return "Bright Pink Dye";
				case 1050:
					return "Black Dye";
				case 1051:
					return "Red and Silver Dye";
				case 1052:
					return "Orange and Silver Dye";
				case 1053:
					return "Yellow and Silver Dye";
				case 1054:
					return "Lime and Silver Dye";
				case 1055:
					return "Green and Silver Dye";
				case 1056:
					return "Teal and Silver Dye";
				case 1057:
					return "Cyan and Silver Dye";
				case 1058:
					return "Sky Blue and Silver Dye";
				case 1059:
					return "Blue and Silver Dye";
				case 1060:
					return "Purple and Silver Dye";
				case 1061:
					return "Violet and Silver Dye";
				case 1062:
					return "Pink and Silver Dye";
				case 1063:
					return "Intense Flame Dye";
				case 1064:
					return "Intense Green Flame Dye";
				case 1065:
					return "Intense Blue Flame Dye";
				case 1066:
					return "Rainbow Dye";
				case 1067:
					return "Intense Rainbow Dye";
				case 1068:
					return "Yellow Gradient Dye";
				case 1069:
					return "Cyan Gradient Dye";
				case 1070:
					return "Violet Gradient Dye";
				case 1071:
					return "Paintbrush";
				case 1072:
					return "Paint Roller";
				case 1073:
					return "Red Paint";
				case 1074:
					return "Orange Paint";
				case 1075:
					return "Yellow Paint";
				case 1076:
					return "Lime Paint";
				case 1077:
					return "Green Paint";
				case 1078:
					return "Teal Paint";
				case 1079:
					return "Cyan Paint";
				case 1080:
					return "Sky Blue Paint";
				case 1081:
					return "Blue Paint";
				case 1082:
					return "Purple Paint";
				case 1083:
					return "Violet Paint";
				case 1084:
					return "Pink Paint";
				case 1085:
					return "Deep Red Paint";
				case 1086:
					return "Deep Orange Paint";
				case 1087:
					return "Deep Yellow Paint";
				case 1088:
					return "Deep Lime Paint";
				case 1089:
					return "Deep Green Paint";
				case 1090:
					return "Deep Teal Paint";
				case 1091:
					return "Deep Cyan Paint";
				case 1092:
					return "Deep Sky Blue Paint";
				case 1093:
					return "Deep Blue Paint";
				case 1094:
					return "Deep Purple Paint";
				case 1095:
					return "Deep Violet Paint";
				case 1096:
					return "Deep Pink Paint";
				case 1097:
					return "Black Paint";
				case 1098:
					return "White Paint";
				case 1099:
					return "Gray Paint";
				case 1100:
					return "Paint Scraper";
				case 1101:
					return "Lihzahrd Brick";
				case 1102:
					return "Lihzahrd Brick Wall";
				case 1103:
					return "Slush Block";
				case 1104:
					return "Palladium Ore";
				case 1105:
					return "Orichalcum Ore";
				case 1106:
					return "Titanium Ore";
				case 1107:
					return "Teal Mushroom";
				case 1108:
					return "Green Mushroom";
				case 1109:
					return "Sky Blue Flower";
				case 1110:
					return "Yellow Marigold";
				case 1111:
					return "Blue Berries";
				case 1112:
					return "Lime Kelp";
				case 1113:
					return "Pink Prickly Pear";
				case 1114:
					return "Orange Bloodroot";
				case 1115:
					return "Red Husk";
				case 1116:
					return "Cyan Husk";
				case 1117:
					return "Violet Husk";
				case 1118:
					return "Purple Mucos";
				case 1119:
					return "Black Ink";
				case 1120:
					return "Dye Vat";
				case 1121:
					return "Bee Gun";
				case 1122:
					return "Possessed Hatchet";
				case 1123:
					return "Bee Keeper";
				case 1124:
					return "Hive";
				case 1125:
					return "Honey Block";
				case 1126:
					return "Hive Wall";
				case 1127:
					return "Crispy Honey Block";
				case 1128:
					return "Honey Bucket";
				case 1129:
					return "Hive Wand";
				case 1130:
					return "Beenade";
				case 1131:
					return "Gravity Globe";
				case 1132:
					return "Honey Comb";
				case 1133:
					return "Abeemination";
				case 1134:
					return "Bottled Honey";
				case 1135:
					return "Rain Hat";
				case 1136:
					return "Rain Coat";
				case 1137:
					return "Lihzahrd Door";
				case 1138:
					return "Dungeon Door";
				case 1139:
					return "Lead Door";
				case 1140:
					return "Iron Door";
				case 1141:
					return "Temple Key";
				case 1142:
					return "Lihzahrd Chest";
				case 1143:
					return "Lihzahrd Chair";
				case 1144:
					return "Lihzahrd Table";
				case 1145:
					return "Lihzahrd Work Bench";
				case 1146:
					return "Super Dart Trap";
				case 1147:
					return "Flame Trap";
				case 1148:
					return "Spiky Ball Trap";
				case 1149:
					return "Spear Trap";
				case 1150:
					return "Wooden Spike";
				case 1151:
					return "Lihzahrd Pressure Plate";
				case 1152:
					return "Lihzahrd Statue";
				case 1153:
					return "Lihzahrd Watcher Statue";
				case 1154:
					return "Lihzahrd Guardian Statue";
				case 1155:
					return "Wasp Gun";
				case 1156:
					return "Piranha Gun";
				case 1157:
					return "Pygmy Staff";
				case 1158:
					return "Pygmy Necklace";
				case 1159:
					return "Tiki Mask";
				case 1160:
					return "Tiki Shirt";
				case 1161:
					return "Tiki Pants";
				case 1162:
					return "Leaf Wings";
				case 1163:
					return "Blizzard in a Balloon";
				case 1164:
					return "Bundle of Balloons";
				case 1165:
					return "Bat Wings";
				case 1166:
					return "Bone Sword";
				case 1167:
					return "Hercules Beetle";
				case 1168:
					return "Smoke Bomb";
				case 1169:
					return "Bone Key";
				case 1170:
					return "Nectar";
				case 1171:
					return "Tiki Totem";
				case 1172:
					return "Lizard Egg";
				case 1173:
					return "Grave Marker";
				case 1174:
					return "Cross Grave Marker";
				case 1175:
					return "Headstone";
				case 1176:
					return "Gravestone";
				case 1177:
					return "Obelisk";
				case 1178:
					return "Leaf Blower";
				case 1179:
					return "Chlorophyte Bullet";
				case 1180:
					return "Parrot Cracker";
				case 1181:
					return "Strange Glowing Mushroom";
				case 1182:
					return "Seedling";
				case 1183:
					return "Wisp in a Bottle";
				case 1184:
					return "Palladium Bar";
				case 1185:
					return "Palladium Sword";
				case 1186:
					return "Palladium Pike";
				case 1187:
					return "Palladium Repeater";
				case 1188:
					return "Palladium Pickaxe";
				case 1189:
					return "Palladium Drill";
				case 1190:
					return "Palladium Chainsaw";
				case 1191:
					return "Orichalcum Bar";
				case 1192:
					return "Orichalcum Sword";
				case 1193:
					return "Orichalcum Halberd";
				case 1194:
					return "Orichalcum Repeater";
				case 1195:
					return "Orichalcum Pickaxe";
				case 1196:
					return "Orichalcum Drill";
				case 1197:
					return "Orichalcum Chainsaw";
				case 1198:
					return "Titanium Bar";
				case 1199:
					return "Titanium Sword";
				case 1200:
					return "Titanium Trident";
				case 1201:
					return "Titanium Repeater";
				case 1202:
					return "Titanium Pickaxe";
				case 1203:
					return "Titanium Drill";
				case 1204:
					return "Titanium Chainsaw";
				case 1205:
					return "Palladium Mask";
				case 1206:
					return "Palladium Helmet";
				case 1207:
					return "Palladium Headgear";
				case 1208:
					return "Palladium Breastplate";
				case 1209:
					return "Palladium Leggings";
				case 1210:
					return "Orichalcum Mask";
				case 1211:
					return "Orichalcum Helmet";
				case 1212:
					return "Orichalcum Headgear";
				case 1213:
					return "Orichalcum Breastplate";
				case 1214:
					return "Orichalcum Leggings";
				case 1215:
					return "Titanium Mask";
				case 1216:
					return "Titanium Helmet";
				case 1217:
					return "Titanium Headgear";
				case 1218:
					return "Titanium Breastplate";
				case 1219:
					return "Titanium Leggings";
				case 1220:
					return "Orichalcum Anvil";
				case 1221:
					return "Titanium Forge";
				case 1222:
					return "Palladium Waraxe";
				case 1223:
					return "Orichalcum Waraxe";
				case 1224:
					return "Titanium Waraxe";
				case 1225:
					return "Hallowed Bar";
				case 1226:
					return "Chlorophyte Claymore";
				case 1227:
					return "Chlorophyte Saber";
				case 1228:
					return "Chlorophyte Partisan";
				case 1229:
					return "Chlorophyte Shotbow";
				case 1230:
					return "Chlorophyte Pickaxe";
				case 1231:
					return "Chlorophyte Drill";
				case 1232:
					return "Chlorophyte Chainsaw";
				case 1233:
					return "Chlorophyte Greataxe";
				case 1234:
					return "Chlorophyte Warhammer";
				case 1235:
					return "Chlorophyte Arrow";
				case 1236:
					return "Amethyst Hook";
				case 1237:
					return "Topaz Hook";
				case 1238:
					return "Sapphire Hook";
				case 1239:
					return "Emerald Hook";
				case 1240:
					return "Ruby Hook";
				case 1241:
					return "Diamond Hook";
				case 1242:
					return "Amber Mosquito";
				case 1243:
					return "Umbrella Hat";
				case 1244:
					return "Nimbus Rod";
				case 1245:
					return "Orange Torch";
				case 1246:
					return "Crimsand Block";
				case 1247:
					return "Bee Cloak";
				case 1248:
					return "Eye of the Golem";
				case 1249:
					return "Honey Balloon";
				case 1250:
					return "Blue Horseshoe Balloon";
				case 1251:
					return "White Horseshoe Balloon";
				case 1252:
					return "Yellow Horseshoe Balloon";
				case 1253:
					return "Frozen Turtle Shell";
				case 1254:
					return "Sniper Rifle";
				case 1255:
					return "Venus Magnum";
				case 1256:
					return "Crimson Rod";
				case 1257:
					return "Crimtane Bar";
				case 1258:
					return "Stynger";
				case 1259:
					return "Flower Pow";
				case 1260:
					return "Rainbow Gun";
				case 1261:
					return "Stynger Bolt";
				case 1262:
					return "Chlorophyte Jackhammer";
				case 1263:
					return "Teleporter";
				case 1264:
					return "Flower of Frost";
				case 1265:
					return "Uzi";
				case 1266:
					return "Magnet Sphere";
				case 1267:
					return "Purple Stained Glass";
				case 1268:
					return "Yellow Stained Glass";
				case 1269:
					return "Blue Stained Glass";
				case 1270:
					return "Green Stained Glass";
				case 1271:
					return "Red Stained Glass";
				case 1272:
					return "Multicolored Stained Glass";
				case 1273:
					return "Skeletron Hand";
				case 1274:
					return "Skull";
				case 1275:
					return "Balla Hat";
				case 1276:
					return "Gangsta Hat";
				case 1277:
					return "Sailor Hat";
				case 1278:
					return "Eye Patch";
				case 1279:
					return "Sailor Shirt";
				case 1280:
					return "Sailor Pants";
				case 1281:
					return "Skeletron Mask";
				case 1282:
					return "Amethyst Robe";
				case 1283:
					return "Topaz Robe";
				case 1284:
					return "Sapphire Robe";
				case 1285:
					return "Emerald Robe";
				case 1286:
					return "Ruby Robe";
				case 1287:
					return "Diamond Robe";
				case 1288:
					return "White Tuxedo Shirt";
				case 1289:
					return "White Tuxedo Pants";
				case 1290:
					return "Panic Necklace";
				case 1291:
					return "Life Fruit";
				case 1292:
					return "Lihzahrd Altar";
				case 1293:
					return "Lihzahrd Power Cell";
				case 1294:
					return "Picksaw";
				case 1295:
					return "Heat Ray";
				case 1296:
					return "Staff of Earth";
				case 1297:
					return "Golem Fist";
				case 1298:
					return "Water Chest";
				case 1299:
					return "Binoculars";
				case 1300:
					return "Rifle Scope";
				case 1301:
					return "Destroyer Emblem";
				case 1302:
					return "High Velocity Bullet";
				case 1303:
					return "Jellyfish Necklace";
				case 1304:
					return "Zombie Arm";
				case 1305:
					return "The Axe";
				case 1306:
					return "Ice Sickle";
				case 1307:
					return "Clothier Voodoo Doll";
				case 1308:
					return "Poison Staff";
				case 1309:
					return "Slime Staff";
				case 1310:
					return "Poison Dart";
				case 1311:
					return "Eye Spring";
				case 1312:
					return "Toy Sled";
				case 1313:
					return "Book of Skulls";
				case 1314:
					return "KO Cannon";
				case 1315:
					return "Pirate Map";
				case 1316:
					return "Turtle Helmet";
				case 1317:
					return "Turtle Scale Mail";
				case 1318:
					return "Turtle Leggings";
				case 1319:
					return "Snowball Cannon";
				case 1320:
					return "Bone Pickaxe";
				case 1321:
					return "Magic Quiver";
				case 1322:
					return "Magma Stone";
				case 1323:
					return "Obsidian Rose";
				case 1324:
					return "Bananarang";
				case 1325:
					return "Chain Knife";
				case 1326:
					return "Rod of Discord";
				case 1327:
					return "Death Sickle";
				case 1328:
					return "Turtle Shell";
				case 1329:
					return "Tissue Sample";
				case 1330:
					return "Vertebrae";
				case 1331:
					return "Bloody Spine";
				case 1332:
					return "Ichor";
				case 1333:
					return "Ichor Torch";
				case 1334:
					return "Ichor Arrow";
				case 1335:
					return "Ichor Bullet";
				case 1336:
					return "Golden Shower";
				case 1337:
					return "Bunny Cannon";
				case 1338:
					return "Explosive Bunny";
				case 1339:
					return "Vial of Venom";
				case 1340:
					return "Flask of Venom";
				case 1341:
					return "Venom Arrow";
				case 1342:
					return "Venom Bullet";
				case 1343:
					return "Fire Gauntlet";
				case 1344:
					return "Cog";
				case 1345:
					return "Confetti";
				case 1346:
					return "Nanites";
				case 1347:
					return "Explosive Powder";
				case 1348:
					return "Gold Dust";
				case 1349:
					return "Party Bullet";
				case 1350:
					return "Nano Bullet";
				case 1351:
					return "Exploding Bullet";
				case 1352:
					return "Golden Bullet";
				case 1353:
					return "Flask of Cursed Flames";
				case 1354:
					return "Flask of Fire";
				case 1355:
					return "Flask of Gold";
				case 1356:
					return "Flask of Ichor";
				case 1357:
					return "Flask of Nanites";
				case 1358:
					return "Flask of Party";
				case 1359:
					return "Flask of Poison";
				case 1360:
					return "Eye of Cthulhu Trophy";
				case 1361:
					return "Eater of Worlds Trophy";
				case 1362:
					return "Brain of Cthulhu Trophy";
				case 1363:
					return "Skeletron Trophy";
				case 1364:
					return "Queen Bee Trophy";
				case 1365:
					return "Wall of Flesh Trophy";
				case 1366:
					return "Destroyer Trophy";
				case 1367:
					return "Skeletron Prime Trophy";
				case 1368:
					return "Retinazer Trophy";
				case 1369:
					return "Spazmatism Trophy";
				case 1370:
					return "Plantera Trophy";
				case 1371:
					return "Golem Trophy";
				case 1372:
					return "Blood Moon Rising";
				case 1373:
					return "The Hanged Man";
				case 1374:
					return "Glory of the Fire";
				case 1375:
					return "Bone Warp";
				case 1376:
					return "Wall Skeleton";
				case 1377:
					return "Hanging Skeleton";
				case 1378:
					return "Blue Slab Wall";
				case 1379:
					return "Blue Tiled Wall";
				case 1380:
					return "Pink Slab Wall";
				case 1381:
					return "Pink Tiled Wall";
				case 1382:
					return "Green Slab Wall";
				case 1383:
					return "Green Tiled Wall";
				case 1384:
					return "Blue Brick Platform";
				case 1385:
					return "Pink Brick Platform";
				case 1386:
					return "Green Brick Platform";
				case 1387:
					return "Metal Shelf";
				case 1388:
					return "Brass Shelf";
				case 1389:
					return "Wood Shelf";
				case 1390:
					return "Brass Lantern";
				case 1391:
					return "Caged Lantern";
				case 1392:
					return "Carriage Lantern";
				case 1393:
					return "Alchemy Lantern";
				case 1394:
					return "Diablost Lamp";
				case 1395:
					return "Oil Rag Sconse";
				case 1396:
					return "Blue Dungeon Chair";
				case 1397:
					return "Blue Dungeon Table";
				case 1398:
					return "Blue Dungeon Work Bench";
				case 1399:
					return "Green Dungeon Chair";
				case 1400:
					return "Green Dungeon Table";
				case 1401:
					return "Green Dungeon Work Bench";
				case 1402:
					return "Pink Dungeon Chair";
				case 1403:
					return "Pink Dungeon Table";
				case 1404:
					return "Pink Dungeon Work Bench";
				case 1405:
					return "Blue Dungeon Candle";
				case 1406:
					return "Green Dungeon Candle";
				case 1407:
					return "Pink Dungeon Candle";
				case 1408:
					return "Blue Dungeon Vase";
				case 1409:
					return "Green Dungeon Vase";
				case 1410:
					return "Pink Dungeon Vase";
				case 1411:
					return "Blue Dungeon Door";
				case 1412:
					return "Green Dungeon Door";
				case 1413:
					return "Pink Dungeon Door";
				case 1414:
					return "Blue Dungeon Bookcase";
				case 1415:
					return "Green Dungeon Bookcase";
				case 1416:
					return "Pink Dungeon Bookcase";
				case 1417:
					return "Catacomb";
				case 1418:
					return "Dungeon Shelf";
				case 1419:
					return "Skellington J Skellingsworth";
				case 1420:
					return "The Cursed Man";
				case 1421:
					return "The Eye Sees the End";
				case 1422:
					return "Something Evil is Watching You";
				case 1423:
					return "The Twins Have Awoken";
				case 1424:
					return "The Screamer";
				case 1425:
					return "Goblins Playing Poker";
				case 1426:
					return "Dryadisque";
				case 1427:
					return "Sunflowers";
				case 1428:
					return "Terrarian Gothic";
				case 1429:
					return "Beanie";
				case 1430:
					return "Imbuing Station";
				case 1431:
					return "Star in a Bottle";
				case 1432:
					return "Empty Bullet";
				case 1433:
					return "Impact";
				case 1434:
					return "Powered by Birds";
				case 1435:
					return "The Destroyer";
				case 1436:
					return "The Persistency of Eyes";
				case 1437:
					return "Unicorn Crossing the Hallows";
				case 1438:
					return "Great Wave";
				case 1439:
					return "Starry Night";
				case 1440:
					return "Guide Picasso";
				case 1441:
					return "The Guardian's Gaze";
				case 1442:
					return "Father of Someone";
				case 1443:
					return "Nurse Lisa";
				case 1444:
					return "Shadowbeam Staff";
				case 1445:
					return "Inferno Fork";
				case 1446:
					return "Spectre Staff";
				case 1447:
					return "Wooden Fence";
				case 1448:
					return "Metal Fence";
				case 1449:
					return "Bubble Machine";
				case 1450:
					return "Bubble Wand";
				case 1451:
					return "Marching Bones Banner";
				case 1452:
					return "Necromantic Sign";
				case 1453:
					return "Rusted Company Standard";
				case 1454:
					return "Ragged Brotherhood Sigil";
				case 1455:
					return "Molten Legion Flag";
				case 1456:
					return "Diabolic Sigil";
				case 1457:
					return "Obsidian Platform";
				case 1458:
					return "Obsidian Door";
				case 1459:
					return "Obsidian Chair";
				case 1460:
					return "Obsidian Table";
				case 1461:
					return "Obsidian Work Bench";
				case 1462:
					return "Obsidian Vase";
				case 1463:
					return "Obsidian Bookcase";
				case 1464:
					return "Hellbound Banner";
				case 1465:
					return "Hell Hammer Banner";
				case 1466:
					return "Helltower Banner";
				case 1467:
					return "Lost Hopes of Man Banner";
				case 1468:
					return "Obsidian Watcher Banner";
				case 1469:
					return "Lava Erupts Banner";
				case 1470:
					return "Blue Dungeon Bed";
				case 1471:
					return "Green Dungeon Bed";
				case 1472:
					return "Red Dungeon Bed";
				case 1473:
					return "Obsidian Bed";
				case 1474:
					return "Waldo";
				case 1475:
					return "Darkness";
				case 1476:
					return "Dark Soul Reaper";
				case 1477:
					return "Land";
				case 1478:
					return "Trapped Ghost";
				case 1479:
					return "Demon's Eye";
				case 1480:
					return "Finding Gold";
				case 1481:
					return "First Encounter";
				case 1482:
					return "Good Morning";
				case 1483:
					return "Underground Reward";
				case 1484:
					return "Through the Window";
				case 1485:
					return "Place Above the Clouds";
				case 1486:
					return "Do Not Step on the Grass";
				case 1487:
					return "Cold Waters in the White Land";
				case 1488:
					return "Lightless Chasms";
				case 1489:
					return "The Land of Deceiving Looks";
				case 1490:
					return "Daylight";
				case 1491:
					return "Secret of the Sands";
				case 1492:
					return "Deadland Comes Alive";
				case 1493:
					return "Evil Presence";
				case 1494:
					return "Sky Guardian";
				case 1495:
					return "American Explosive";
				case 1496:
					return "Discover";
				case 1497:
					return "Hand Earth";
				case 1498:
					return "Old Miner";
				case 1499:
					return "Skelehead";
				case 1500:
					return "Facing the Cerebral Mastermind";
				case 1501:
					return "Lake of Fire";
				case 1502:
					return "Trio Super Heroes";
				case 1503:
					return "Spectre Hood";
				case 1504:
					return "Spectre Robe";
				case 1505:
					return "Spectre Pants";
				case 1506:
					return "Spectre Pickaxe";
				case 1507:
					return "Spectre Hamaxe";
				case 1508:
					return "Ectoplasm";
				case 1509:
					return "Gothic Chair";
				case 1510:
					return "Gothic Table";
				case 1511:
					return "Gothic Work Bench";
				case 1512:
					return "Gothic Bookcase";
				case 1513:
					return "Paladin's Hammer";
				case 1514:
					return "SWAT Helmet";
				case 1515:
					return "Bee Wings";
				case 1516:
					return "Giant Harpy Feather";
				case 1517:
					return "Bone Feather";
				case 1518:
					return "Fire Feather";
				case 1519:
					return "Ice Feather";
				case 1520:
					return "Broken Bat Wing";
				case 1521:
					return "Tattered Bee Wing";
				case 1522:
					return "Large Amethyst";
				case 1523:
					return "Large Topaz";
				case 1524:
					return "Large Sapphire";
				case 1525:
					return "Large Emerald";
				case 1526:
					return "Large Ruby";
				case 1527:
					return "Large Diamond";
				case 1528:
					return "Jungle Chest";
				case 1529:
					return "Corruption Chest";
				case 1530:
					return "Crimson Chest";
				case 1531:
					return "Hallowed Chest";
				case 1532:
					return "Frozen Chest";
				case 1533:
					return "Jungle Key";
				case 1534:
					return "Corruption Key";
				case 1535:
					return "Crimson Key";
				case 1536:
					return "Hallowed Key";
				case 1537:
					return "Frozen Key";
				case 1538:
					return "Imp Face";
				case 1539:
					return "Ominous Presence";
				case 1540:
					return "Shining Moon";
				case 1541:
					return "Living Gore";
				case 1542:
					return "Flowing Magma";
				case 1543:
					return "Spectre Paintbrush";
				case 1544:
					return "Spectre Paint Roller";
				case 1545:
					return "Spectre Paint Scraper";
				case 1546:
					return "Shroomite Headgear";
				case 1547:
					return "Shroomite Mask";
				case 1548:
					return "Shroomite Helmet";
				case 1549:
					return "Shroomite Breastplate";
				case 1550:
					return "Shroomite Leggings";
				case 1551:
					return "Autohammer";
				case 1552:
					return "Shroomite Bar";
				case 1553:
					return "S.D.M.G.";
				case 1554:
					return "Cenx's Tiara";
				case 1555:
					return "Cenx's Breastplate";
				case 1556:
					return "Cenx's Leggings";
				case 1557:
					return "Crowno's Mask";
				case 1558:
					return "Crowno's Breastplate";
				case 1559:
					return "Crowno's Leggings";
				case 1560:
					return "Will's Helmet";
				case 1561:
					return "Will's Breastplate";
				case 1562:
					return "Will's Leggings";
				case 1563:
					return "Jim's Helmet";
				case 1564:
					return "Jim's Breastplate";
				case 1565:
					return "Jim's Leggings";
				case 1566:
					return "Aaron's Helmet";
				case 1567:
					return "Aaron's Breastplate";
				case 1568:
					return "Aaron's Leggings";
				case 1569:
					return "Vampire Knives";
				case 1570:
					return "Broken Hero Sword";
				case 1571:
					return "Scourge of the Corruptor";
				case 1572:
					return "Staff of the Frost Hydra";
				case 1573:
					return "The Creation of the Guide";
				case 1574:
					return "The Merchant";
				case 1575:
					return "Crowno Devours His Lunch";
				case 1576:
					return "Rare Enchantment";
				case 1577:
					return "Glorious Night";
				case 1578:
					return "Sweetheart Necklace";
				case 1579:
					return "Flurry Boots";
				case 1580:
					return "D-Town's Helmet";
				case 1581:
					return "D-Town's Breastplate";
				case 1582:
					return "D-Town's Leggings";
				case 1583:
					return "D-Town's Wings";
				case 1584:
					return "Will's Wings";
				case 1585:
					return "Crowno's Wings";
				case 1586:
					return "Cenx's Wings";
				case 1587:
					return "Cenx's Dress";
				case 1588:
					return "Cenx's Dress Pants";
				case 1589:
					return "Palladium Column";
				case 1590:
					return "Palladium Column Wall";
				case 1591:
					return "Bubblegum Block";
				case 1592:
					return "Bubblegum Block Wall";
				case 1593:
					return "Titanstone Block";
				case 1594:
					return "Titanstone Block Wall";
				case 1595:
					return "Magic Cuffs";
				case 1596:
					return "Music Box (Snow)";
				case 1597:
					return "Music Box (Space)";
				case 1598:
					return "Music Box (Crimson)";
				case 1599:
					return "Music Box (Boss 4)";
				case 1600:
					return "Music Box (Alt Overworld Day)";
				case 1601:
					return "Music Box (Rain)";
				case 1602:
					return "Music Box (Ice)";
				case 1603:
					return "Music Box (Desert)";
				case 1604:
					return "Music Box (Ocean)";
				case 1605:
					return "Music Box (Dungeon)";
				case 1606:
					return "Music Box (Plantera)";
				case 1607:
					return "Music Box (Boss 5)";
				case 1608:
					return "Music Box (Temple)";
				case 1609:
					return "Music Box (Eclipse)";
				case 1610:
					return "Music Box (Mushrooms)";
				case 1611:
					return "Butterfly Dust";
				case 1612:
					return "Ankh Charm";
				case 1613:
					return "Ankh Shield";
				case 1614:
					return "Blue Flare";
				case 1615:
					return "Angler Fish Banner";
				case 1616:
					return "Angry Nimbus Banner";
				case 1617:
					return "Anomura Fungus Banner";
				case 1618:
					return "Antlion Banner";
				case 1619:
					return "Arapaima Banner";
				case 1620:
					return "Armored Skeleton Banner";
				case 1621:
					return "Bat Banner";
				case 1622:
					return "Bird Banner";
				case 1623:
					return "Black Recluse Banner";
				case 1624:
					return "Blood Feeder Banner";
				case 1625:
					return "Blood Jelly Banner";
				case 1626:
					return "Blood Crawler Banner";
				case 1627:
					return "Bone Serpent Banner";
				case 1628:
					return "Bunny Banner";
				case 1629:
					return "Chaos Elemental Banner";
				case 1630:
					return "Mimic Banner";
				case 1631:
					return "Clown Banner";
				case 1632:
					return "Corrupt Bunny Banner";
				case 1633:
					return "Corrupt Goldfish Banner";
				case 1634:
					return "Crab Banner";
				case 1635:
					return "Crimera Banner";
				case 1636:
					return "Crimson Axe Banner";
				case 1637:
					return "Cursed Hammer Banner";
				case 1638:
					return "Demon Banner";
				case 1639:
					return "Demon Eye Banner";
				case 1640:
					return "Derpling Banner";
				case 1641:
					return "Eater of Souls Banner";
				case 1642:
					return "Enchanted Sword Banner";
				case 1643:
					return "Zombie Eskimo Banner";
				case 1644:
					return "Face Monster Banner";
				case 1645:
					return "Floaty Gross Banner";
				case 1646:
					return "Flying Fish Banner";
				case 1647:
					return "Flying Snake Banner";
				case 1648:
					return "Frankenstein Banner";
				case 1649:
					return "Fungi Bulb Banner";
				case 1650:
					return "Fungo Fish Banner";
				case 1651:
					return "Gastropod Banner";
				case 1652:
					return "Goblin Archer Banner";
				case 1653:
					return "Goblin Sorcerer Banner";
				case 1654:
					return "Goblin Scout Banner";
				case 1655:
					return "Goblin Thief Banner";
				case 1656:
					return "Goblin Warrior Banner";
				case 1657:
					return "Goldfish Banner";
				case 1658:
					return "Harpy Banner";
				case 1659:
					return "Hellbat Banner";
				case 1660:
					return "Herpling Banner";
				case 1661:
					return "Hornet Banner";
				case 1662:
					return "Ice Elemental Banner";
				case 1663:
					return "Icy Merman Banner";
				case 1664:
					return "Fire Imp Banner";
				case 1665:
					return "Jellyfish Banner";
				case 1666:
					return "Jungle Creeper Banner";
				case 1667:
					return "Lihzahrd Banner";
				case 1668:
					return "Man Eater Banner";
				case 1669:
					return "Meteor Head Banner";
				case 1670:
					return "Moth Banner";
				case 1671:
					return "Mummy Banner";
				case 1672:
					return "Mushi Ladybug Banner";
				case 1673:
					return "Parrot Banner";
				case 1674:
					return "Pigron Banner";
				case 1675:
					return "Piranha Banner";
				case 1676:
					return "Pirate Banner";
				case 1677:
					return "Pixie Banner";
				case 1678:
					return "Raincoat Zombie Banner";
				case 1679:
					return "Reaper Banner";
				case 1680:
					return "Shark Banner";
				case 1681:
					return "Skeleton Banner";
				case 1682:
					return "Skeleton Mage Banner";
				case 1683:
					return "Slime Banner";
				case 1684:
					return "Snow Flinx Banner";
				case 1685:
					return "Spider Banner";
				case 1686:
					return "Spore Zombie Banner";
				case 1687:
					return "Swamp Thing Banner";
				case 1688:
					return "Tortoise Banner";
				case 1689:
					return "Toxic Sludge Banner";
				case 1690:
					return "Umbrella Slime Banner";
				case 1691:
					return "Unicorn Banner";
				case 1692:
					return "Vampire Banner";
				case 1693:
					return "Vulture Banner";
				case 1694:
					return "Nypmh Banner";
				case 1695:
					return "Werewolf Banner";
				case 1696:
					return "Wolf Banner";
				case 1697:
					return "World Feeder Banner";
				case 1698:
					return "Worm Banner";
				case 1699:
					return "Wraith Banner";
				case 1700:
					return "Wyvern Banner";
				case 1701:
					return "Zombie Banner";
				case 1702:
					return "Glass Platform";
				case 1703:
					return "Glass Chair";
				case 1704:
					return "Golden Chair";
				case 1705:
					return "Golden Toilet";
				case 1706:
					return "Bar Stool";
				case 1707:
					return "Honey Chair";
				case 1708:
					return "Steam Punk Chair";
				case 1709:
					return "Glass Door";
				case 1710:
					return "Golden Door";
				case 1711:
					return "Honey Door";
				case 1712:
					return "Steam Punk Door";
				case 1713:
					return "Glass Table";
				case 1714:
					return "Banquet Table";
				case 1715:
					return "Bar";
				case 1716:
					return "Golden Table";
				case 1717:
					return "Honey Table";
				case 1718:
					return "Steam Punk Table";
				case 1719:
					return "Glass Bed";
				case 1720:
					return "Golden Bed";
				case 1721:
					return "Honey Bed";
				case 1722:
					return "Steam Punk Bed";
				case 1723:
					return "Living Wood Wall";
				case 1724:
					return "Fart in a Jar";
				}
			}
			else
			{
				if (Lang.lang == 2)
				{
					switch (l)
					{
					case -24:
						return "Gelbes Laserschwert";
					case -23:
						return "Weisses Laserschwert";
					case -22:
						return "Lila Laserschwert";
					case -21:
						return "Gruenes Laserschwert";
					case -20:
						return "Rotes Laserschwert";
					case -19:
						return "Blaues Laserschwert";
					case -18:
						return "Kupferbogen";
					case -17:
						return "Kupferhammer";
					case -16:
						return "Kupferaxt";
					case -15:
						return "Kupferkurzschwert";
					case -14:
						return "Kupferbreitschwert";
					case -13:
						return "Kupferspitzhacke";
					case -12:
						return "Silberbogen";
					case -11:
						return "Silberhammer";
					case -10:
						return "Silberaxt";
					case -9:
						return "Silberkurzschwert";
					case -8:
						return "Silberbreitschwert";
					case -7:
						return "Silberspitzhacke";
					case -6:
						return "Goldbogen";
					case -5:
						return "Goldhammer";
					case -4:
						return "Goldaxt";
					case -3:
						return "Goldkurzschwert";
					case -2:
						return "Goldbreitschwert";
					case -1:
						return "Goldspitzhacke";
					case 1:
						return "Eisenspitzhacke";
					case 2:
						return "Dreckblock";
					case 3:
						return "Steinblock";
					case 4:
						return "Eisenbreitschwert";
					case 5:
						return "Pilz";
					case 6:
						return "Eisenkurzschwert";
					case 7:
						return "Eisenhammer";
					case 8:
						return "Fackel";
					case 9:
						return "Holz";
					case 10:
						return "Eisenaxt";
					case 11:
						return "Eisenerz";
					case 12:
						return "Kupfererz";
					case 13:
						return "Golderz";
					case 14:
						return "Silbererz";
					case 15:
						return "Kupferuhr";
					case 16:
						return "Silberuhr";
					case 17:
						return "Golduhr";
					case 18:
						return "Taucheruhr";
					case 19:
						return "Goldbarren";
					case 20:
						return "Kupferbarren";
					case 21:
						return "Silberbarren";
					case 22:
						return "Eisenbarren";
					case 23:
						return "Glibber";
					case 24:
						return "Holzschwert";
					case 25:
						return "Holztuer";
					case 26:
						return "Steinwand";
					case 27:
						return "Eichel";
					case 28:
						return "Schwacher Heiltrank";
					case 29:
						return "Lebenskristall";
					case 30:
						return "Dreckwand";
					case 31:
						return "Flasche";
					case 32:
						return "Holztisch";
					case 33:
						return "Ofen";
					case 34:
						return "Holzstuhl";
					case 35:
						return "Eisenamboss";
					case 36:
						return "Werkbank";
					case 37:
						return "Schutzbrille";
					case 38:
						return "Linse";
					case 39:
						return "Holzbogen";
					case 40:
						return "Holzpfeil";
					case 41:
						return "Flammenpfeil";
					case 42:
						return "Shuriken";
					case 43:
						return "Verdaechtig ausschauendes Auge";
					case 44:
						return "Daemonenbogen";
					case 45:
						return "Kriegsaxt der Nacht";
					case 46:
						return "Schrecken des Tages";
					case 47:
						return "Unheiliger Pfeil";
					case 48:
						return "Truhe";
					case 49:
						return "Wiederbelebungsband";
					case 50:
						return "Magischer Spiegel";
					case 51:
						return "Dominopfeil";
					case 52:
						return "Engelsstatue";
					case 53:
						return "Wolke in einer Flasche";
					case 54:
						return "Hermes-Stiefel";
					case 55:
						return "Verzauberter Bumerang";
					case 56:
						return "Daemoniterz";
					case 57:
						return "Daemonitbarren";
					case 58:
						return "Herz";
					case 59:
						return "Verderbte Saat";
					case 60:
						return "Ekelpilz";
					case 61:
						return "Ebensteinblock";
					case 62:
						return "Grassaat";
					case 63:
						return "Sonnenblume";
					case 64:
						return "Ekeldorn";
					case 65:
						return "Sternenwut";
					case 66:
						return "Reinigungspulver";
					case 67:
						return "Ekelpulver";
					case 68:
						return "Verfaultes";
					case 69:
						return "Wurmzahn";
					case 70:
						return "Wurmkoeder";
					case 71:
						return "Kupfermuenze";
					case 72:
						return "Silbermuenze";
					case 73:
						return "Goldmuenze";
					case 74:
						return "Platinmuenze";
					case 75:
						return "Sternschnuppe";
					case 76:
						return "Kupferbeinschuetzer";
					case 77:
						return "Eisenbeinschuetzer";
					case 78:
						return "Silberbeinschuetzer";
					case 79:
						return "Goldbeinschuetzer";
					case 80:
						return "Kupferkettenhemd";
					case 81:
						return "Eisenkettenhemd";
					case 82:
						return "Silberkettenhemd";
					case 83:
						return "Goldkettenhemd";
					case 84:
						return "Enterhaken";
					case 85:
						return "Eisenkette";
					case 86:
						return "Schattenschuppe";
					case 87:
						return "Sparschwein";
					case 88:
						return "Bergmannshelm";
					case 89:
						return "Kupferhelm";
					case 90:
						return "Eisenhelm";
					case 91:
						return "Silberhelm";
					case 92:
						return "Goldhelm";
					case 93:
						return "Holzwand";
					case 94:
						return "Holzklappe";
					case 95:
						return "Steinschlosspistole";
					case 96:
						return "Muskete";
					case 97:
						return "Musketenkugel";
					case 98:
						return "Minihai";
					case 99:
						return "Eisenbogen";
					case 100:
						return "Schattenbeinschuetzer";
					case 101:
						return "Schattenschuppenhemd";
					case 102:
						return "Schattenhelm";
					case 103:
						return "Albtraum-Spitzhacke";
					case 104:
						return "Zerschmetterer";
					case 105:
						return "Kerze";
					case 106:
						return "Kupferkronleuchter";
					case 107:
						return "Silberkronleuchter";
					case 108:
						return "Goldkronleuchter";
					case 109:
						return "Mana-Kristall";
					case 110:
						return "Schwacher Manatrank";
					case 111:
						return "Sternenkraftband";
					case 112:
						return "Feuerblume";
					case 113:
						return "Magische Rakete";
					case 114:
						return "Dreckrute";
					case 115:
						return "Lichtkugel";
					case 116:
						return "Meteorit";
					case 117:
						return "Meteoritenbarren";
					case 118:
						return "Haken";
					case 119:
						return "Flamarang";
					case 120:
						return "Geschmolzene Wut";
					case 121:
						return "Feuriges Grossschwert";
					case 122:
						return "Geschmolzene Spitzhacke";
					case 123:
						return "Meteorhelm";
					case 124:
						return "Meteoranzug";
					case 125:
						return "Meteor Leggings";
					case 126:
						return "Flaschenwasser";
					case 127:
						return "Raum Gun";
					case 128:
						return "Raketenstiefel";
					case 129:
						return "Grauer Ziegel";
					case 130:
						return "Graue Ziegelsteinwand";
					case 131:
						return "Roter Ziegel";
					case 132:
						return "Rote Ziegelwand";
					case 133:
						return "Lehmblock";
					case 134:
						return "Blauer Ziegel";
					case 135:
						return "Blaue Ziegelwand";
					case 136:
						return "Haengelaterne";
					case 137:
						return "Gruener Ziegel";
					case 138:
						return "Gruene Ziegelwand";
					case 139:
						return "Rosa Ziegel";
					case 140:
						return "Rosa Ziegelwand";
					case 141:
						return "Goldziegel";
					case 142:
						return "Goldziegelwand";
					case 143:
						return "Silberziegel";
					case 144:
						return "Silberziegelwand";
					case 145:
						return "Kupferziegel";
					case 146:
						return "Kupferziegelwand";
					case 147:
						return "Stachel";
					case 148:
						return "Wasserkerze";
					case 149:
						return "Buch";
					case 150:
						return "Spinnennetz";
					case 151:
						return "Necrohelm";
					case 152:
						return "Necro-Brustplatte";
					case 153:
						return "Necro-Beinschuetzer";
					case 154:
						return "Knochen";
					case 155:
						return "Muramasa";
					case 156:
						return "Kobaltschild";
					case 157:
						return "Aqua-Zepter";
					case 158:
						return "Glueckshufeisen";
					case 159:
						return "Leuchtend roter Ballon";
					case 160:
						return "Harpune";
					case 161:
						return "Stachelball";
					case 162:
						return "Ball des Schmerzes";
					case 163:
						return "Blauer Mond";
					case 164:
						return "Pistole";
					case 165:
						return "Wasserbolzen";
					case 166:
						return "Bombe";
					case 167:
						return "Dynamit";
					case 168:
						return "Granate";
					case 169:
						return "Sandblock";
					case 170:
						return "Glas";
					case 171:
						return "Spruchschild";
					case 172:
						return "Aschenblock";
					case 173:
						return "Obsidian";
					case 174:
						return "HOeLLENSTEIN";
					case 175:
						return "HOeLLENSTEIN-Barren";
					case 176:
						return "Matschblock";
					case 177:
						return "Saphir";
					case 178:
						return "Rubin";
					case 179:
						return "Smaragd";
					case 180:
						return "Topas";
					case 181:
						return "Amethyst";
					case 182:
						return "Diamant";
					case 183:
						return "Gluehender Pilz";
					case 184:
						return "Stern";
					case 185:
						return "Efeupeitsche";
					case 186:
						return "Schnorchelschilf";
					case 187:
						return "Flosse";
					case 188:
						return "Heiltrank";
					case 189:
						return "Manatrank";
					case 190:
						return "Grasklinge";
					case 191:
						return "Dornen-Chakram";
					case 192:
						return "Obsidianziegel";
					case 193:
						return "Obsidianschaedel";
					case 194:
						return "Pilzgras-Saat";
					case 195:
						return "Dschungelgras-Saat";
					case 196:
						return "Holzhammer";
					case 197:
						return "Sternenkanone";
					case 198:
						return "Blaue Laserklinge";
					case 199:
						return "Rote Laserklinge";
					case 200:
						return "Gruene Laserklinge";
					case 201:
						return "Lila Laserklinge";
					case 202:
						return "Weisse Laserklinge";
					case 203:
						return "Gelbe Laserklinge";
					case 204:
						return "Meteor-Hamaxt";
					case 205:
						return "Leerer Eimer";
					case 206:
						return "Wassereimer";
					case 207:
						return "Lavaeimer";
					case 208:
						return "Dschungelrose";
					case 209:
						return "Hornissenstachel";
					case 210:
						return "Weinrebe";
					case 211:
						return "Wilde Klauen";
					case 212:
						return "Fusskette des Windes";
					case 213:
						return "Stab des Nachwachsens";
					case 214:
						return "Hoellensteinziegel";
					case 215:
						return "Furzkissen";
					case 216:
						return "Fessel";
					case 217:
						return "Geschmolzene Hamaxt";
					case 218:
						return "Flammenpeitsche";
					case 219:
						return "Phoenix-Blaster";
					case 220:
						return "Sonnenwut";
					case 221:
						return "Hoellenschmiede";
					case 222:
						return "Tontopf";
					case 223:
						return "Geschenk der Natur";
					case 224:
						return "Bett";
					case 225:
						return "Seide";
					case 226:
						return "Schwacher Wiederherstellungstrank";
					case 227:
						return "Wiederherstellungstrank";
					case 228:
						return "Dschungelhut";
					case 229:
						return "Dschungelhemd";
					case 230:
						return "Dschungelhosen";
					case 231:
						return "Geschmolzener Helm";
					case 232:
						return "Geschmolzene Brustplatte";
					case 233:
						return "Geschmolzene Beinschuetzer";
					case 234:
						return "Meteorenschuss";
					case 235:
						return "Haftbombe";
					case 236:
						return "Schwarze Linsen";
					case 237:
						return "Sonnenbrille";
					case 238:
						return "Zaubererhut";
					case 239:
						return "Zylinderhut";
					case 240:
						return "Smokinghemd";
					case 241:
						return "Smokinghosen";
					case 242:
						return "Sommerhut";
					case 243:
						return "Hasenkapuze";
					case 244:
						return "Klempnerhut";
					case 245:
						return "Klempnerhemd";
					case 246:
						return "Klempnerhosen";
					case 247:
						return "Heldenhut";
					case 248:
						return "Heldenhemd";
					case 249:
						return "Heldenhosen";
					case 250:
						return "Fischglas";
					case 251:
						return "Archaeologenhut";
					case 252:
						return "Archaeologenjacke";
					case 253:
						return "Archaeologenhosen";
					case 254:
						return "Schwarzer Farbstoff";
					case 255:
						return "Gruener Farbstoff";
					case 256:
						return "Ninja-Kapuze";
					case 257:
						return "Ninjahemd";
					case 258:
						return "Ninjahosen";
					case 259:
						return "Leder";
					case 260:
						return "Roter Hut";
					case 261:
						return "Goldfisch";
					case 262:
						return "Robe";
					case 263:
						return "Roboterhut";
					case 264:
						return "Goldkrone";
					case 265:
						return "Hoellenfeuer-Pfeil";
					case 266:
						return "Sandgewehr";
					case 267:
						return "Fremdenfuehrer-Voodoo-Puppe";
					case 268:
						return "Taucherhelm";
					case 269:
						return "Vertrautes Hemd";
					case 270:
						return "Vertraute Hosen";
					case 271:
						return "Vertraute Frisur";
					case 272:
						return "Daemonensense";
					case 273:
						return "Klinge der Nacht";
					case 274:
						return "Dunkle Lanze";
					case 275:
						return "Koralle";
					case 276:
						return "Kaktus";
					case 277:
						return "Dreizack";
					case 278:
						return "Silberkugel";
					case 279:
						return "Wurfmesser";
					case 280:
						return "Speer";
					case 281:
						return "Blasrohr";
					case 282:
						return "Leuchtstab";
					case 283:
						return "Saat";
					case 284:
						return "Holzbumerang";
					case 285:
						return "Schnuersenkelkappe";
					case 286:
						return "Klebriger Leuchtstab";
					case 287:
						return "Giftmesser";
					case 288:
						return "Obsidianhaut-Trank";
					case 289:
						return "Wiederbelebungstrank";
					case 290:
						return "Flinkheitstrank";
					case 291:
						return "Kiementrank";
					case 292:
						return "Eisenhaut-Trank";
					case 293:
						return "Mana-Wiederherstellungstrank";
					case 294:
						return "Magiekraft-Trank";
					case 295:
						return "Federsturz-Trank";
					case 296:
						return "Hoehlenforschertrank";
					case 297:
						return "Unsichtbarkeitstrank";
					case 298:
						return "Strahlentrank";
					case 299:
						return "Nachteulentrank";
					case 300:
						return "Kampftrank";
					case 301:
						return "Dornentrank";
					case 302:
						return "Wasserlauftrank";
					case 303:
						return "Bogenschiessrank";
					case 304:
						return "Jaegertrank";
					case 305:
						return "Gravitationstrank";
					case 306:
						return "Goldtruhe";
					case 307:
						return "Tagesblumensaat";
					case 308:
						return "Mondscheinsaat";
					case 309:
						return "Leuchtwurzel-Saat";
					case 310:
						return "Todeskraut-Saat";
					case 311:
						return "Wasserblatt-Saat";
					case 312:
						return "Feuerblueten-Saat";
					case 313:
						return "Tagesblume";
					case 314:
						return "Mondglanz";
					case 315:
						return "Leuchtwurzel";
					case 316:
						return "Todeskraut";
					case 317:
						return "Wasserblatt";
					case 318:
						return "Feuerbluete";
					case 319:
						return "Haifinne";
					case 320:
						return "Feder";
					case 321:
						return "Grabstein";
					case 322:
						return "Imitatormaske";
					case 323:
						return "Ameisenloewenkiefer";
					case 324:
						return "Illegale Gewehrteile";
					case 325:
						return "Hemd des Arztes";
					case 326:
						return "Hosen des Arztes";
					case 327:
						return "Goldener Schluessel";
					case 328:
						return "Schattentruhe";
					case 329:
						return "Schattenschluessel";
					case 330:
						return "Obsidianziegelwand";
					case 331:
						return "Dschungelsporen";
					case 332:
						return "Webstuhl";
					case 333:
						return "Piano";
					case 334:
						return "Kommode";
					case 335:
						return "Sitzbank";
					case 336:
						return "Badewanne";
					case 337:
						return "Rotes Dekoband";
					case 338:
						return "Gruenes Dekoband";
					case 339:
						return "Blaues Dekoband";
					case 340:
						return "Gelbes Dekoband";
					case 341:
						return "Laternenpfahl";
					case 342:
						return "Petroleumfackel";
					case 343:
						return "Fass";
					case 344:
						return "Chinesische Laterne";
					case 345:
						return "Kochtopf";
					case 346:
						return "Tresor";
					case 347:
						return "Schaedellaterne";
					case 348:
						return "Muelleimer";
					case 349:
						return "Kandelaber";
					case 350:
						return "Rosa Vase";
					case 351:
						return "Masskrug";
					case 352:
						return "Gaerbottich";
					case 353:
						return "Bier";
					case 354:
						return "Buecherregal";
					case 355:
						return "Thron";
					case 356:
						return "Schuessel";
					case 357:
						return "Schuessel mit Suppe";
					case 358:
						return "Toilette";
					case 359:
						return "Standuhr";
					case 360:
						return "Ruestungsstatue";
					case 361:
						return "Goblin-Kampfstandarte";
					case 362:
						return "Zerfetzter Stoff";
					case 363:
						return "Saegewerk";
					case 364:
						return "Kobalterz";
					case 365:
						return "Mithrilerz";
					case 366:
						return "Adamantiterz";
					case 367:
						return "Pwnhammer";
					case 368:
						return "Excalibur";
					case 369:
						return "Gesegnete Saat";
					case 370:
						return "Ebensandblock";
					case 371:
						return "Kobalthut";
					case 372:
						return "Kobalthelm";
					case 373:
						return "Kobalt-Maske";
					case 374:
						return "Kobalt-Brustplatte";
					case 375:
						return "Kobalt-Gamaschen";
					case 376:
						return "Mithril-Kapuze";
					case 377:
						return "Mithril-Helm";
					case 378:
						return "Mithrilhut";
					case 379:
						return "Mithril-Kettenhemd";
					case 380:
						return "Mithril-Beinschuetzer";
					case 381:
						return "Kobaltbarren";
					case 382:
						return "Mithrilbarren";
					case 383:
						return "Kobalt-Kettensaege";
					case 384:
						return "Mithril-Kettensaege";
					case 385:
						return "Kobaltbohrer";
					case 386:
						return "Mithrilbohrer";
					case 387:
						return "Adamantit-Kettensaege";
					case 388:
						return "Adamantitbohrer";
					case 389:
						return "Dao von Pow";
					case 390:
						return "Mithril-Hellebarde";
					case 391:
						return "Adamantitbarren";
					case 392:
						return "Glaswand";
					case 393:
						return "Kompass";
					case 394:
						return "Tauchausruestung";
					case 395:
						return "GPS";
					case 396:
						return "Obsidian-Hufeisen";
					case 397:
						return "Obsidianschild";
					case 398:
						return "Tueftler-Werkstatt";
					case 399:
						return "Wolke in einem Ballon";
					case 400:
						return "Adamantitkopfschutz";
					case 401:
						return "Adamantithelm";
					case 402:
						return "Adamantitmaske";
					case 403:
						return "Adamantitbrustplatte";
					case 404:
						return "Adamantitgamaschen";
					case 405:
						return "Geisterstiefel";
					case 406:
						return "Adamantitgleve";
					case 407:
						return "Werkzeugguertel";
					case 408:
						return "Perlsandblock";
					case 409:
						return "Perlsteinblock";
					case 410:
						return "Bergbauhemd";
					case 411:
						return "Bergbauhosen";
					case 412:
						return "Perlsteinziegel";
					case 413:
						return "Schillernder Ziegel";
					case 414:
						return "Schlammsteinblock";
					case 415:
						return "Kobaltziegel";
					case 416:
						return "Mithrilziegel";
					case 417:
						return "Perlsteinziegelwand";
					case 418:
						return "Schillernde Ziegelwand";
					case 419:
						return "Schlammsteinziegelwand";
					case 420:
						return "Kobaltziegelwand";
					case 421:
						return "Mithrilziegelwand";
					case 422:
						return "Heiliges Wasser";
					case 423:
						return "Unheiliges Wasser";
					case 424:
						return "Schlickblock";
					case 425:
						return "Feenglocke";
					case 426:
						return "Schmetterklinge";
					case 427:
						return "Blaue Fackel";
					case 428:
						return "Rote Fackel";
					case 429:
						return "Gruene Fackel";
					case 430:
						return "Lila Fackel";
					case 431:
						return "Weisse Fackel";
					case 432:
						return "Gelbe Fackel";
					case 433:
						return "Daemonenfackel";
					case 434:
						return "Automatiksturmwaffe";
					case 435:
						return "Kobaltrepetierer";
					case 436:
						return "Mithrilrepetierer";
					case 437:
						return "Dual-Haken";
					case 438:
						return "Sternstatue";
					case 439:
						return "Schwertstatue";
					case 440:
						return "Schleimistatue";
					case 441:
						return "Goblinstatue";
					case 442:
						return "Schildstatue";
					case 443:
						return "Fledermausstatue";
					case 444:
						return "Fischstatue";
					case 445:
						return "Haeschenstatue";
					case 446:
						return "Skelettstatue";
					case 447:
						return "Sensenmannstatue";
					case 448:
						return "Frauenstatue";
					case 449:
						return "Impstatue";
					case 450:
						return "Wasserspeier-Statue";
					case 451:
						return "Vanitasstatue";
					case 452:
						return "Hornissenstatue";
					case 453:
						return "Bombenstatue";
					case 454:
						return "Krabbenstatue";
					case 455:
						return "Hammerstatue";
					case 456:
						return "Trankstatue";
					case 457:
						return "Speerstatue";
					case 458:
						return "Kreuzstatue";
					case 459:
						return "Quallenstatue";
					case 460:
						return "Bogenstatue";
					case 461:
						return "Bumerangstatue";
					case 462:
						return "Stiefelstatue";
					case 463:
						return "Truhenstatue";
					case 464:
						return "Vogelstatue";
					case 465:
						return "Axtstatue";
					case 466:
						return "Verderbnisstatue";
					case 467:
						return "Baumstatue";
					case 468:
						return "Amboss-Statue";
					case 469:
						return "Spitzhackenstatue";
					case 470:
						return "Pilzstatue";
					case 471:
						return "Augapfelstatue";
					case 472:
						return "Saeulenstatue";
					case 473:
						return "Herzstatue";
					case 474:
						return "Topfstatue";
					case 475:
						return "Sonnenblumenstatue";
					case 476:
						return "Koenigstatue";
					case 477:
						return "Koeniginstatue";
					case 478:
						return "Pirahnastatue";
					case 479:
						return "Plankenwand";
					case 480:
						return "Holzbalken";
					case 481:
						return "Adamantitrepetierer";
					case 482:
						return "Adamantitschwert";
					case 483:
						return "Kobaltschwert";
					case 484:
						return "Mithrilschwert";
					case 485:
						return "Mondzauber";
					case 486:
						return "Massgitter";
					case 487:
						return "Kristallkugel";
					case 488:
						return "Diskokugel";
					case 489:
						return "Hexeremblem";
					case 490:
						return "Kriegeremblem";
					case 491:
						return "Waldlaeufer-Emblem";
					case 492:
						return "Daemonenfluegel";
					case 493:
						return "Engelsfluegel";
					case 494:
						return "Magische Harfe";
					case 495:
						return "Regenbogenrute";
					case 496:
						return "Eisrute";
					case 497:
						return "Neptuns Muschel";
					case 498:
						return "Mannequin";
					case 499:
						return "Grosser Heiltrank";
					case 500:
						return "Grosser Manatrank";
					case 501:
						return "Pixie-Staub";
					case 502:
						return "Kristallscherbe";
					case 503:
						return "Clownshut";
					case 504:
						return "Clownshemd";
					case 505:
						return "Clownshosen";
					case 506:
						return "Flammenwerfer";
					case 507:
						return "Glocke";
					case 508:
						return "Harfe";
					case 509:
						return "Schraubenschluessel";
					case 510:
						return "Kabelcutter";
					case 511:
						return "Aktiver Steinblock";
					case 512:
						return "Inaktiver Steinblock";
					case 513:
						return "Hebel";
					case 514:
						return "Lasergewehr";
					case 515:
						return "Kristallgeschoss";
					case 516:
						return "Heiliger Pfeil";
					case 517:
						return "Magischer Dolch";
					case 518:
						return "Kristallsturm";
					case 519:
						return "Verfluchte Flammen";
					case 520:
						return "Seele des Lichts";
					case 521:
						return "Seele der Nacht";
					case 522:
						return "Verfluchte Flamme";
					case 523:
						return "Verfluchte Fackel";
					case 524:
						return "Adamantitschmiede";
					case 525:
						return "Mithrilamboss";
					case 526:
						return "Horn des Einhorns";
					case 527:
						return "Dunkle Scherbe";
					case 528:
						return "Lichtscherbe";
					case 529:
						return "Rote Druckplatte";
					case 530:
						return "Kabel";
					case 531:
						return "Buch der Flueche";
					case 532:
						return "Sternenumhang";
					case 533:
						return "Maxihai";
					case 534:
						return "Schrotflinte";
					case 535:
						return "Stein der Weisen";
					case 536:
						return "Titanhandschuh";
					case 537:
						return "Kobalt-Naginata";
					case 538:
						return "Schalter";
					case 539:
						return "Pfeilfalle";
					case 540:
						return "Felsbrocken";
					case 541:
						return "Gruene Druckplatte";
					case 542:
						return "Graue Druckplatte";
					case 543:
						return "Braune Druckplatte";
					case 544:
						return "Mechanisches Auge";
					case 545:
						return "Verfluchter Pfeil";
					case 546:
						return "Verfluchte Kugel";
					case 547:
						return "Seele des Schreckens";
					case 548:
						return "Seele der Macht";
					case 549:
						return "Seele der Einsicht";
					case 550:
						return "Gungnir";
					case 551:
						return "Gesegneter Plattenpanzer";
					case 552:
						return "Geheiligte Beinschuetzer";
					case 553:
						return "Gesegneter Helm";
					case 554:
						return "Kreuzhalskette";
					case 555:
						return "Mana-Blume";
					case 556:
						return "Mechanischer Wurm";
					case 557:
						return "Mechanischer Schaedel";
					case 558:
						return "Gesegneter Kopfschutz";
					case 559:
						return "Gesegnete Maske";
					case 560:
						return "Schleimikrone";
					case 561:
						return "Lichtscheibe";
					case 562:
						return "Musikbox (Tag auf der Oberwelt)";
					case 563:
						return "Musikbox (Gespenstisch)";
					case 564:
						return "Musikbox (Nacht)";
					case 565:
						return "Musikbox (Titel)";
					case 566:
						return "Musikbox (Unterirdisch)";
					case 567:
						return "Musikbox (Boss 1)";
					case 568:
						return "Musikbox (Dschungel)";
					case 569:
						return "Musikbox (Verderben)";
					case 570:
						return "Musikbox(Unterirdisches Verderben)";
					case 571:
						return "Musikbox (Das Gesegnete)";
					case 572:
						return "Musikbox (Boss 2)";
					case 573:
						return "Musikbox (Unterirdisches Gesegnetes)";
					case 574:
						return "Musikbox (Boss 3)";
					case 575:
						return "Seele des Flugs";
					case 576:
						return "Musikbox";
					case 577:
						return "Daemonitziegel";
					case 578:
						return "Gesegneter Repetierer";
					case 579:
						return "Drax";
					case 580:
						return "Explosiva";
					case 581:
						return "Einlasspumpe";
					case 582:
						return "Auslasspumpe";
					case 583:
						return "1-Sekunden-Timer";
					case 584:
						return "3-Sekunden-Timer";
					case 585:
						return "5-Sekunden-Timer";
					case 586:
						return "Candy Cane-Block";
					case 587:
						return "Candy Cane Wand";
					case 588:
						return "Weihnachtsmütze";
					case 589:
						return "Santa Shirt";
					case 590:
						return "von Santa Pants";
					case 591:
						return "Grüne Candy Cane-Block";
					case 592:
						return "Grüne Candy Cane Wand";
					case 593:
						return "Schnee-Block";
					case 594:
						return "Schnee Brick";
					case 595:
						return "Schnee Brick Wall";
					case 596:
						return "Blue Light";
					case 597:
						return "Rotlicht";
					case 598:
						return "Green Light";
					case 599:
						return "blaue Gegenwart";
					case 600:
						return "grüne Gegenwart";
					case 601:
						return "Yellow Gegenwart";
					case 602:
						return "Snow Globe";
					case 603:
						return "Karotte";
					}
				}
				else
				{
					if (Lang.lang == 3)
					{
						switch (l)
						{
						case -24:
							return "Spada laser gialla";
						case -23:
							return "Spada laser bianca";
						case -22:
							return "Spada laser viola";
						case -21:
							return "Spada laser verde";
						case -20:
							return "Spada laser rossa";
						case -19:
							return "Spada laser blu";
						case -18:
							return "Arco di rame";
						case -17:
							return "Martello di rame";
						case -16:
							return "Ascia di rame";
						case -15:
							return "Spada corta di rame";
						case -14:
							return "Spadone di rame";
						case -13:
							return "Piccone di rame";
						case -12:
							return "Arco d'argento";
						case -11:
							return "Martello d'argento";
						case -10:
							return "Ascia d'argento";
						case -9:
							return "Spada corta d'argento";
						case -8:
							return "Spadone d'argento";
						case -7:
							return "Piccone d'argento";
						case -6:
							return "Arco d'oro";
						case -5:
							return "Martello d'oro";
						case -4:
							return "Ascia d'oro";
						case -3:
							return "Spada corta d'oro";
						case -2:
							return "Spadone d'oro";
						case -1:
							return "Piccone d'oro";
						case 1:
							return "Piccone di ferro";
						case 2:
							return "Blocco di terra";
						case 3:
							return "Blocco di pietra";
						case 4:
							return "Spadone di ferro";
						case 5:
							return "Fungo";
						case 6:
							return "Spada corta di ferro";
						case 7:
							return "Martello di ferro";
						case 8:
							return "Fiaccola";
						case 9:
							return "Legno";
						case 10:
							return "Ascia di ferro";
						case 11:
							return "Minerale di ferro";
						case 12:
							return "Minerale di rame";
						case 13:
							return "Minerale d'oro";
						case 14:
							return "Minerale d'argento";
						case 15:
							return "Orologio di rame";
						case 16:
							return "Orologio d'argento";
						case 17:
							return "Orologio d'oro";
						case 18:
							return "Misuratore di profondità";
						case 19:
							return "Sbarra d'oro";
						case 20:
							return "Sbarra di rame";
						case 21:
							return "Sbarra d'argento";
						case 22:
							return "Sbarra di ferro";
						case 23:
							return "Gel";
						case 24:
							return "Spada di legno";
						case 25:
							return "Porta di legno";
						case 26:
							return "Muro di pietra";
						case 27:
							return "Ghianda";
						case 28:
							return "Pozione curativa inferiore";
						case 29:
							return "Cristallo di vita";
						case 30:
							return "Muro di terra";
						case 31:
							return "Bottiglia";
						case 32:
							return "Tavolo di legno";
						case 33:
							return "Forno";
						case 34:
							return "Sedia di legno";
						case 35:
							return "Incudine di ferro";
						case 36:
							return "Banco di lavoro";
						case 37:
							return "Occhiali protettivi";
						case 38:
							return "Lenti";
						case 39:
							return "Arco di legno";
						case 40:
							return "Freccia di legno";
						case 41:
							return "Freccia infuocata";
						case 42:
							return "Shuriken";
						case 43:
							return "Occhio diffidente";
						case 44:
							return "Arco demoniaco";
						case 45:
							return "Ascia da guerra della notte";
						case 46:
							return "Flagello di luce";
						case 47:
							return "Freccia empia";
						case 48:
							return "Cassa";
						case 49:
							return "Benda di rigenerazione";
						case 50:
							return "Specchio magico";
						case 51:
							return "Freccia del giullare";
						case 52:
							return "Statua dell'angelo";
						case 53:
							return "Nuvola in bottiglia";
						case 54:
							return "Stivali di Ermes";
						case 55:
							return "Boomerang incantato";
						case 56:
							return "Minerale demoniaco";
						case 57:
							return "Sbarra demoniaca";
						case 58:
							return "Cuore";
						case 59:
							return "Semi distrutti";
						case 60:
							return "Fungo disgustoso";
						case 61:
							return "Blocco pietra d'ebano";
						case 62:
							return "Semi d'erba";
						case 63:
							return "Girasole";
						case 64:
							return "Spina vile";
						case 65:
							return "Furia stellare";
						case 66:
							return "Polvere purificatrice";
						case 67:
							return "Polvere disgustosa";
						case 68:
							return "Ceppo marcio";
						case 69:
							return "Dente di verme";
						case 70:
							return "Esca di verme";
						case 71:
							return "Moneta di rame";
						case 72:
							return "Moneta d'argento";
						case 73:
							return "Moneta d'oro";
						case 74:
							return "Moneta di platino";
						case 75:
							return "Stella cadente";
						case 76:
							return "Gambali di rame";
						case 77:
							return "Gambali di ferro";
						case 78:
							return "Gambali d'argento";
						case 79:
							return "Gambali d'oro";
						case 80:
							return "Maglia metallica di rame";
						case 81:
							return "Maglia metallica di ferro";
						case 82:
							return "Maglia metallica d'argento";
						case 83:
							return "Maglia metallica d'oro";
						case 84:
							return "Rampino";
						case 85:
							return "Catena di ferro";
						case 86:
							return "Scaglia d'ombra";
						case 87:
							return "Salvadanaio";
						case 88:
							return "Casco da minatore";
						case 89:
							return "Casco di rame";
						case 90:
							return "Casco di ferro";
						case 91:
							return "Casco d'argento";
						case 92:
							return "Casco d'oro";
						case 93:
							return "Muro di legno";
						case 94:
							return "Piattaforma di legno";
						case 95:
							return "Pistola a pietra focaia";
						case 96:
							return "Moschetto";
						case 97:
							return "Palla di moschetto";
						case 98:
							return "Minishark";
						case 99:
							return "Arco di ferro";
						case 100:
							return "Gambali ombra";
						case 101:
							return "Armatura a scaglie ombra";
						case 102:
							return "Casco ombra";
						case 103:
							return "Piccone dell'incubo";
						case 104:
							return "Il Distruttore";
						case 105:
							return "Candela";
						case 106:
							return "Lampadario di rame";
						case 107:
							return "Lampadario d'argento";
						case 108:
							return "Lampadario d'oro";
						case 109:
							return "Cristallo mana";
						case 110:
							return "Pozione mana inferiore";
						case 111:
							return "Benda della forza stellare";
						case 112:
							return "Fiore di fuoco";
						case 113:
							return "Missile magico";
						case 114:
							return "Bastone di terra";
						case 115:
							return "Orbita di luce";
						case 116:
							return "Meteorite";
						case 117:
							return "Sbarra di meteorite";
						case 118:
							return "Uncino";
						case 119:
							return "Flamarang";
						case 120:
							return "Furia fusa";
						case 121:
							return "Spadone di fuoco";
						case 122:
							return "Piccone fuso";
						case 123:
							return "Casco meteorite";
						case 124:
							return "Tunica di meteorite";
						case 125:
							return "Meteora pantaloni";
						case 126:
							return "Acqua imbottigliata";
						case 127:
							return "Spazio pistola";
						case 128:
							return "Stivali razzo";
						case 129:
							return "Mattone grigio";
						case 130:
							return "Muro grigio";
						case 131:
							return "Mattone rosso";
						case 132:
							return "Muro rosso";
						case 133:
							return "Blocco d'argilla";
						case 134:
							return "Mattone blu";
						case 135:
							return "Muro blu";
						case 136:
							return "Lanterna con catena";
						case 137:
							return "Mattone verde";
						case 138:
							return "Muro verde";
						case 139:
							return "Mattone rosa";
						case 140:
							return "Muro rosa";
						case 141:
							return "Mattone dorato";
						case 142:
							return "Muro dorato";
						case 143:
							return "Mattone argentato";
						case 144:
							return "Muro argentato";
						case 145:
							return "Mattone di rame";
						case 146:
							return "Muro di rame";
						case 147:
							return "Spina";
						case 148:
							return "Candela d'acqua";
						case 149:
							return "Libro";
						case 150:
							return "Ragnatela";
						case 151:
							return "Casco funebre";
						case 152:
							return "Pettorale funebre";
						case 153:
							return "Gambali funebri";
						case 154:
							return "Osso";
						case 155:
							return "Muramasa";
						case 156:
							return "Scudo di cobalto";
						case 157:
							return "Scettro d'acqua";
						case 158:
							return "Ferro di cavallo fortunato";
						case 159:
							return "Palloncino rosso splendente";
						case 160:
							return "Arpione";
						case 161:
							return "Palla chiodata";
						case 162:
							return "Palla del dolore";
						case 163:
							return "Luna blu";
						case 164:
							return "Pistola";
						case 165:
							return "Dardo d'acqua";
						case 166:
							return "Bomba";
						case 167:
							return "Dinamite";
						case 168:
							return "Granata";
						case 169:
							return "Blocco di sabbia";
						case 170:
							return "Vetro";
						case 171:
							return "Cartello";
						case 172:
							return "Blocco di cenere";
						case 173:
							return "Ossidiana";
						case 174:
							return "Pietra infernale";
						case 175:
							return "Sbarra di pietra infernale";
						case 176:
							return "Blocco di fango";
						case 177:
							return "Zaffiro";
						case 178:
							return "Rubino";
						case 179:
							return "Smeraldo";
						case 180:
							return "Topazio";
						case 181:
							return "Ametista";
						case 182:
							return "Diamante";
						case 183:
							return "Fungo luminoso";
						case 184:
							return "Stella";
						case 185:
							return "Frusta di edera";
						case 186:
							return "Canna per la respirazione";
						case 187:
							return "Pinna";
						case 188:
							return "Pozione curativa";
						case 189:
							return "Pozione mana";
						case 190:
							return "Spada di erba";
						case 191:
							return "Artiglio di Chakram";
						case 192:
							return "Mattone di ossidiana";
						case 193:
							return "Teschio di ossidiana";
						case 194:
							return "Semi di fungo";
						case 195:
							return "Semi dell'erba della giungla";
						case 196:
							return "Martello di legno";
						case 197:
							return "Cannone stellare";
						case 198:
							return "Spada laser blu";
						case 199:
							return "Spada laser rossa";
						case 200:
							return "Spada laser verde";
						case 201:
							return "Spada laser viola";
						case 202:
							return "Spada laser bianca";
						case 203:
							return "Spada laser gialla";
						case 204:
							return "Maglio di meteorite";
						case 205:
							return "Secchio vuoto";
						case 206:
							return "Secchio d'acqua";
						case 207:
							return "Secchio di lava";
						case 208:
							return "Rosa della giungla";
						case 209:
							return "Artiglio";
						case 210:
							return "Vite";
						case 211:
							return "Artigli bestiali";
						case 212:
							return "Cavigliera del vento";
						case 213:
							return "Bastone della ricrescita";
						case 214:
							return "Mattone di pietra infernale";
						case 215:
							return "Cuscino rumoroso";
						case 216:
							return "Grillo";
						case 217:
							return "Maglio fuso";
						case 218:
							return "Lanciatore di fiamma";
						case 219:
							return "Blaster della fenice";
						case 220:
							return "Furia del sole";
						case 221:
							return "Creazione degli inferi";
						case 222:
							return "Vaso di argilla";
						case 223:
							return "Dono della natura";
						case 224:
							return "Letto";
						case 225:
							return "Seta";
						case 226:
							return "Pozione di ripristino inferiore";
						case 227:
							return "Pozione di ripristino";
						case 228:
							return "Cappello della giungla";
						case 229:
							return "Camicia della giungla";
						case 230:
							return "Pantaloni della giungla";
						case 231:
							return "Casco fuso";
						case 232:
							return "Pettorale fuso";
						case 233:
							return "Gambali fusi";
						case 234:
							return "Sparo di meteorite";
						case 235:
							return "Bomba appiccicosa";
						case 236:
							return "Lenti nere";
						case 237:
							return "Occhiali da sole";
						case 238:
							return "Cappello dello stregone";
						case 239:
							return "Cilindro";
						case 240:
							return "Camicia da smoking";
						case 241:
							return "Pantaloni smoking";
						case 242:
							return "Cappello estivo";
						case 243:
							return "Cappuccio da coniglio";
						case 244:
							return "Cappello da idraulico";
						case 245:
							return "Camicia da idraulico";
						case 246:
							return "Pantaloni da idraulico";
						case 247:
							return "Cappello da eroe";
						case 248:
							return "Camicia da eroe";
						case 249:
							return "Pantaloni da eroe";
						case 250:
							return "Boccia dei pesci rossi";
						case 251:
							return "Cappello da archeologo";
						case 252:
							return "Giacca da archeologo";
						case 253:
							return "Pantaloni da archeologo";
						case 254:
							return "Tintura nera";
						case 255:
							return "Tintura verde";
						case 256:
							return "Cappuccio ninja";
						case 257:
							return "Camicia ninja";
						case 258:
							return "Pantaloni ninja";
						case 259:
							return "Pelle";
						case 260:
							return "Cappello rosso";
						case 261:
							return "Pesce rosso";
						case 262:
							return "Mantello";
						case 263:
							return "Cappello da robot";
						case 264:
							return "Corona d'oro";
						case 265:
							return "Freccia di fuoco infernale";
						case 266:
							return "Pistola di sabbia";
						case 267:
							return "Bambola voodoo guida";
						case 268:
							return "Casco da palombaro";
						case 269:
							return "Camicia comune";
						case 270:
							return "Pantaloni comuni";
						case 271:
							return "Parrucca comune";
						case 272:
							return "Falce demoniaca";
						case 273:
							return "Confine della notte";
						case 274:
							return "Lancia oscura";
						case 275:
							return "Corallo";
						case 276:
							return "Cactus";
						case 277:
							return "Tridente";
						case 278:
							return "Proiettile d'argento";
						case 279:
							return "Coltello da lancio";
						case 280:
							return "Lancia";
						case 281:
							return "Cerbottana";
						case 282:
							return "Bastone luminoso";
						case 283:
							return "Seme";
						case 284:
							return "Boomerang di legno";
						case 285:
							return "Aghetto";
						case 286:
							return "Bastone luminoso appiccicoso";
						case 287:
							return "Coltello avvelenato";
						case 288:
							return "Pozione pelle di ossidiana";
						case 289:
							return "Pozione rigeneratrice";
						case 290:
							return "Pozione della rapidità";
						case 291:
							return "Pozione branchie";
						case 292:
							return "Pozione pelle di ferro";
						case 293:
							return "Pozione rigenerazione mana";
						case 294:
							return "Pozione potenza magica";
						case 295:
							return "Pozione caduta dolce";
						case 296:
							return "Pozione speleologo";
						case 297:
							return "Pozione invisibilità";
						case 298:
							return "Pozione splendore";
						case 299:
							return "Pozione civetta";
						case 300:
							return "Pozione battaglia";
						case 301:
							return "Pozione spine";
						case 302:
							return "Pozione per camminare sull'acqua";
						case 303:
							return "Pozione arciere";
						case 304:
							return "Pozione cacciatore";
						case 305:
							return "Pozione gravità";
						case 306:
							return "Cassa d'oro";
						case 307:
							return "Semi Fiordigiorno";
						case 308:
							return "Semi Splendiluna";
						case 309:
							return "Semi Lampeggiaradice";
						case 310:
							return "Semi Erbamorte";
						case 311:
							return "Semi Acquafoglia";
						case 312:
							return "Semi Fiordifuoco";
						case 313:
							return "Fiordigiorno";
						case 314:
							return "Splendiluna";
						case 315:
							return "Lampeggiaradice";
						case 316:
							return "Erbamorte";
						case 317:
							return "Acquafoglia";
						case 318:
							return "Fiordifuoco";
						case 319:
							return "Pinna di squalo";
						case 320:
							return "Piuma";
						case 321:
							return "Lapide";
						case 322:
							return "Maschera sosia";
						case 323:
							return "Mandibola di formicaleone";
						case 324:
							return "Parti di pistola illegale";
						case 325:
							return "Camicia da medico";
						case 326:
							return "Pantaloni da medico";
						case 327:
							return "Chiave dorata";
						case 328:
							return "Cassa ombra";
						case 329:
							return "Chiave ombra";
						case 330:
							return "Muro di ossidiana";
						case 331:
							return "Spore della giungla";
						case 332:
							return "Telaio";
						case 333:
							return "Pianoforte";
						case 334:
							return "Cassettone";
						case 335:
							return "Panca";
						case 336:
							return "Vasca da bagno";
						case 337:
							return "Stendardo rosso";
						case 338:
							return "Stendardo verde";
						case 339:
							return "Stendardo blu";
						case 340:
							return "Stendardo giallo";
						case 341:
							return "Lampione";
						case 342:
							return "Torcia tiki";
						case 343:
							return "Barile";
						case 344:
							return "Lanterna cinese";
						case 345:
							return "Pentola";
						case 346:
							return "Caveau";
						case 347:
							return "Lanterna-teschio";
						case 348:
							return "Bidone";
						case 349:
							return "Candelabro";
						case 350:
							return "Vaso rosa";
						case 351:
							return "Boccale";
						case 352:
							return "Barilotto";
						case 353:
							return "Birra";
						case 354:
							return "Scaffale";
						case 355:
							return "Trono";
						case 356:
							return "Ciotola";
						case 357:
							return "Ciotola di zuppa";
						case 358:
							return "Toilette";
						case 359:
							return "Pendola";
						case 360:
							return "Statua armatura";
						case 361:
							return "Insegna di battaglia dei goblin";
						case 362:
							return "Abito a brandelli";
						case 363:
							return "Segheria";
						case 364:
							return "Minerale cobalto";
						case 365:
							return "Minerale mitrilio";
						case 366:
							return "Minerale adamantio";
						case 367:
							return "Martellone";
						case 368:
							return "Excalibur";
						case 369:
							return "Semi consacrati";
						case 370:
							return "Blocco sabbia d'ebano";
						case 371:
							return "Cappello di cobalto";
						case 372:
							return "Casco di cobalto";
						case 373:
							return "Maschera di cobalto";
						case 374:
							return "Corrazza di cobalto";
						case 375:
							return "Calzamaglia di cobalto";
						case 376:
							return "Cappuccio di mitrilio";
						case 377:
							return "Casco di mitrilio";
						case 378:
							return "Cappello di mitrilio";
						case 379:
							return "Maglia metallica di mitrilio";
						case 380:
							return "Gambali di mitrilio";
						case 381:
							return "Sbarra di cobalto";
						case 382:
							return "Sbarra di mitrilio";
						case 383:
							return "Motosega di cobalto";
						case 384:
							return "Motosega di mitrilio";
						case 385:
							return "Perforatrice di cobalto";
						case 386:
							return "Perforatrice di mitrilio";
						case 387:
							return "Motosega di adamantio";
						case 388:
							return "Perforatrice di adamantio";
						case 389:
							return "Frustona";
						case 390:
							return "Alabarda di mitrilio";
						case 391:
							return "Sbarra di adamantio";
						case 392:
							return "Muro di vetro";
						case 393:
							return "Bussola";
						case 394:
							return "Muta da sub";
						case 395:
							return "GPS";
						case 396:
							return "Ferro di cavallo di ossidiana";
						case 397:
							return "Scudo di ossidiana";
						case 398:
							return "Laboratorio dell'inventore";
						case 399:
							return "Nuvola in un palloncino";
						case 400:
							return "Copricapo di adamantio";
						case 401:
							return "Casco di adamantio";
						case 402:
							return "Maschera di adamantio";
						case 403:
							return "Corrazza di adamantio";
						case 404:
							return "Calzamaglia di adamantio";
						case 405:
							return "Stivali da fantasma";
						case 406:
							return "Alabarda di adamantio";
						case 407:
							return "Cintura porta attrezzi";
						case 408:
							return "Blocco sabbiaperla";
						case 409:
							return "Blocco pietraperla";
						case 410:
							return "Camicia da minatore";
						case 411:
							return "Pantaloni da minatore";
						case 412:
							return "Mattone pietraperla";
						case 413:
							return "Mattone iridescente";
						case 414:
							return "Blocco pietrafango";
						case 415:
							return "Mattone cobalto";
						case 416:
							return "Mattone mitrilio";
						case 417:
							return "Muro di pietraperla";
						case 418:
							return "Muro di mattoni iridescenti";
						case 419:
							return "Muro di pietrafango";
						case 420:
							return "Muro di mattoni di cobalto";
						case 421:
							return "Muro di mattoni di mitrilio";
						case 422:
							return "Acquasanta";
						case 423:
							return "Acqua profana";
						case 424:
							return "Blocco insabbiato";
						case 425:
							return "Campana della fata";
						case 426:
							return "Lama del distruttore";
						case 427:
							return "Torcia blu";
						case 428:
							return "Torcia rossa";
						case 429:
							return "Torcia verde";
						case 430:
							return "Torcia viola";
						case 431:
							return "Torcia bianca";
						case 432:
							return "Torcia gialla";
						case 433:
							return "Torcia demoniaca";
						case 434:
							return "Fucile d'assalto automatico";
						case 435:
							return "Balestra automatica di cobalto";
						case 436:
							return "Balestra automatica di mitrilio";
						case 437:
							return "Gancio doppio";
						case 438:
							return "Statua stella";
						case 439:
							return "Statua spada";
						case 440:
							return "Statua slime";
						case 441:
							return "Statua goblin";
						case 442:
							return "Statua scudo";
						case 443:
							return "Statua pipistrello";
						case 444:
							return "Statua pesce";
						case 445:
							return "Statua coniglio";
						case 446:
							return "Statua scheletro";
						case 447:
							return "Statua mietitore";
						case 448:
							return "Statua donna";
						case 449:
							return "Statua diavoletto";
						case 450:
							return "Statua gargoyle";
						case 451:
							return "Statua tenebre";
						case 452:
							return "Statua calabrone";
						case 453:
							return "Statua bomba";
						case 454:
							return "Statua granchio";
						case 455:
							return "Statua martello";
						case 456:
							return "Statua pozione";
						case 457:
							return "Statua arpione";
						case 458:
							return "Statua croce";
						case 459:
							return "Statua medusa";
						case 460:
							return "Statua arco";
						case 461:
							return "Statua boomerang";
						case 462:
							return "Statua stivali";
						case 463:
							return "Statua cassa";
						case 464:
							return "Statua Uucello";
						case 465:
							return "Statua ascia";
						case 466:
							return "Statua distruzione";
						case 467:
							return "Statua albero";
						case 468:
							return "Staua incudine";
						case 469:
							return "Statua piccone";
						case 470:
							return "Statua fungo";
						case 471:
							return "Statua bulbo oculare";
						case 472:
							return "Statua colonna";
						case 473:
							return "Statua cuore";
						case 474:
							return "Statua pentola";
						case 475:
							return "Statua girasole";
						case 476:
							return "Statua re";
						case 477:
							return "Statua regina";
						case 478:
							return "Statua piranha";
						case 479:
							return "Muro impalcato";
						case 480:
							return "Trave di legno";
						case 481:
							return "Mietitore di adamantio";
						case 482:
							return "Spada di adamantio";
						case 483:
							return "Spada di cobalto";
						case 484:
							return "Spada di mitrilio";
						case 485:
							return "Amuleto della luna";
						case 486:
							return "Righello";
						case 487:
							return "Sfera di cristallo";
						case 488:
							return "Palla disco";
						case 489:
							return "Emblema dell'incantatore";
						case 490:
							return "Emblema del guerriero";
						case 491:
							return "Emblema del guardiaboschi";
						case 492:
							return "Ali del demone";
						case 493:
							return "Ali dell'angelo";
						case 494:
							return "Arpa magica";
						case 495:
							return "Bastone dell'arcobaleno";
						case 496:
							return "Bastone di ghiaccio";
						case 497:
							return "Conchiglia di Nettuno";
						case 498:
							return "Manichino";
						case 499:
							return "Pozione curativa superiore";
						case 500:
							return "Pozione mana superiore";
						case 501:
							return "Polvere di fata";
						case 502:
							return "Frammento di cristallo";
						case 503:
							return "Cappello da clown";
						case 504:
							return "Camicia da clown";
						case 505:
							return "Pantaloni da clown";
						case 506:
							return "Lanciafiamme";
						case 507:
							return "Campana";
						case 508:
							return "Arpa";
						case 509:
							return "Chiave inglese";
						case 510:
							return "Tagliacavi";
						case 511:
							return "Blocco di pietra attivo";
						case 512:
							return "Blocco di pietra non attivo";
						case 513:
							return "Leva";
						case 514:
							return "Fucile laser";
						case 515:
							return "Proiettile di cristallo";
						case 516:
							return "Freccia sacra";
						case 517:
							return "Pugnale magico";
						case 518:
							return "Tempesta di cristallo";
						case 519:
							return "Fiamme maledette";
						case 520:
							return "Anima della luce";
						case 521:
							return "Anima della notte";
						case 522:
							return "Fiamma maledetta";
						case 523:
							return "Torcia maledetta";
						case 524:
							return "Fornace di adamantio";
						case 525:
							return "Incudine di mitrilio";
						case 526:
							return "Corno di unicorno";
						case 527:
							return "Frammento oscuro";
						case 528:
							return "Frammento di luce";
						case 529:
							return "Piastra a pressione rossa";
						case 530:
							return "Cavo";
						case 531:
							return "Tomo incantato";
						case 532:
							return "Mantello stellato";
						case 533:
							return "Megashark";
						case 534:
							return "Fucile";
						case 535:
							return "Pietra filosofale";
						case 536:
							return "Guanto del Titano";
						case 537:
							return "Naginata di cobalto";
						case 538:
							return "Interruttore";
						case 539:
							return "Trappola dardi";
						case 540:
							return "Masso";
						case 541:
							return "Piastra a pressione verde";
						case 542:
							return "Piastra a pressione grigia";
						case 543:
							return "Piastra a pressione marrone";
						case 544:
							return "Occhio meccanico";
						case 545:
							return "Freccia maledetta";
						case 546:
							return "Proiettile maledetto";
						case 547:
							return "Anima del terrore";
						case 548:
							return "Anima del potere";
						case 549:
							return "Anima della visione";
						case 550:
							return "Gungnir";
						case 551:
							return "Armatura sacra";
						case 552:
							return "Gambali sacri";
						case 553:
							return "Casco sacro";
						case 554:
							return "Collana con croce";
						case 555:
							return "Fiore di mana";
						case 556:
							return "Verme meccanico";
						case 557:
							return "Teschio meccanico";
						case 558:
							return "Copricapo sacro";
						case 559:
							return "Maschera sacra";
						case 560:
							return "Corona slime";
						case 561:
							return "Disco di luce";
						case 562:
							return "Musica (Giornata mondiale)";
						case 563:
							return "Musica (Mistero)";
						case 564:
							return "Musica (Notte)";
						case 565:
							return "Musica (Titolo)";
						case 566:
							return "Musica (Sottosuolo)";
						case 567:
							return "Musica (Boss 1)";
						case 568:
							return "Musica (Giungla)";
						case 569:
							return "Musica (Distruzione)";
						case 570:
							return "Musica (Distruzione sotterranea)";
						case 571:
							return "Musica (Il sacro)";
						case 572:
							return "Musica (Boss 2)";
						case 573:
							return "Musica (Sacro sotterraneo)";
						case 574:
							return "Musica (Boss 3)";
						case 575:
							return "Anima del volo";
						case 576:
							return "Musica";
						case 577:
							return "Mattone demoniaco";
						case 578:
							return "Balestra automatica sacra";
						case 579:
							return "Perforascia";
						case 580:
							return "Esplosivi";
						case 581:
							return "Pompa interna";
						case 582:
							return "Pompa esterna";
						case 583:
							return "Timer 2 secondo";
						case 584:
							return "Timer 3 secondi";
						case 585:
							return "Timer 5 secondi";
						case 586:
							return "Candy Cane Block";
						case 587:
							return "Candy Cane parete";
						case 588:
							return "Cappello da Babbo Natale";
						case 589:
							return "S. Shirt";
						case 590:
							return "Pantaloni di Santa";
						case 591:
							return "Blocco verde Candy Cane";
						case 592:
							return "Green Candy Cane Wall";
						case 593:
							return "Blocca neve";
						case 594:
							return "neve Brick";
						case 595:
							return "Neve Muro di mattoni";
						case 596:
							return "azzurro";
						case 597:
							return "Red Light";
						case 598:
							return "verde chiaro";
						case 599:
							return "Presente blu";
						case 600:
							return "Presente verde";
						case 601:
							return "Presente giallo";
						case 602:
							return "Snow Globe";
						case 603:
							return "Carota";
						}
					}
					else
					{
						if (Lang.lang == 4)
						{
							switch (l)
							{
							case -24:
								return "Sabre laser jaune";
							case -23:
								return "Sabre laser blanc";
							case -22:
								return "Sabre laser violet";
							case -21:
								return "Sabre laser vert";
							case -20:
								return "Sabre laser rouge";
							case -19:
								return "Sabre laser bleu";
							case -18:
								return "Arc en cuivre";
							case -17:
								return "Marteau en cuivre";
							case -16:
								return "Hache en cuivre";
							case -15:
								return "Épée courte en cuivre";
							case -14:
								return "Épée longue en cuivre";
							case -13:
								return "Pioche en cuivre";
							case -12:
								return "Arc en argent";
							case -11:
								return "Marteau en argent";
							case -10:
								return "Hache en argent";
							case -9:
								return "Épée courte en argent";
							case -8:
								return "Épée longue en argent";
							case -7:
								return "Pioche en argent";
							case -6:
								return "Arc en or";
							case -5:
								return "Marteau en or";
							case -4:
								return "Hache en or";
							case -3:
								return "Épée courte en or";
							case -2:
								return "Épée longue en or";
							case -1:
								return "Pioche en or";
							case 1:
								return "Pioche en fer";
							case 2:
								return "Bloc de terre";
							case 3:
								return "Bloc de pierre";
							case 4:
								return "Épée longue en fer";
							case 5:
								return "Champignon";
							case 6:
								return "Épée courte en fer";
							case 7:
								return "Marteau en fer";
							case 8:
								return "Torche";
							case 9:
								return "Bois";
							case 10:
								return "Hache en fer";
							case 11:
								return "Minerai de fer";
							case 12:
								return "Minerai de cuivre";
							case 13:
								return "Minerai d'or";
							case 14:
								return "Minerai d'argent";
							case 15:
								return "Montre en cuivre";
							case 16:
								return "Montre en argent";
							case 17:
								return "Montre en or";
							case 18:
								return "Altimètre";
							case 19:
								return "Lingot d'or";
							case 20:
								return "Lingot de cuivre";
							case 21:
								return "Lingot d'argent";
							case 22:
								return "Lingot de fer";
							case 23:
								return "Gel";
							case 24:
								return "Épée en bois";
							case 25:
								return "Porte en bois";
							case 26:
								return "Mur en pierre";
							case 27:
								return "Gland";
							case 28:
								return "Faible potion de soin";
							case 29:
								return "Cristal de vie";
							case 30:
								return "Mur en terre";
							case 31:
								return "Bouteille";
							case 32:
								return "Table en bois";
							case 33:
								return "Four";
							case 34:
								return "Chaise en bois";
							case 35:
								return "Enclume";
							case 36:
								return "Établi";
							case 37:
								return "Lunettes";
							case 38:
								return "Lentille";
							case 39:
								return "Arc en bois";
							case 40:
								return "Flèche en bois";
							case 41:
								return "Flèche enflammée";
							case 42:
								return "Shuriken";
							case 43:
								return "Œil observateur suspicieux";
							case 44:
								return "Arc démoniaque";
							case 45:
								return "Hache de guerre de la nuit";
							case 46:
								return "Fléau de lumière";
							case 47:
								return "Flèche impie";
							case 48:
								return "Coffre";
							case 49:
								return "Anneau de régénération";
							case 50:
								return "Miroir magique";
							case 51:
								return "Flèche du bouffon";
							case 52:
								return "Statue d'ange";
							case 53:
								return "Nuage en bouteille";
							case 54:
								return "Bottes d'Hermès";
							case 55:
								return "Boomerang enchanté";
							case 56:
								return "Barre de démonite";
							case 57:
								return "Lingot de démonite";
							case 58:
								return "Pilier";
							case 59:
								return "Graines corrompues";
							case 60:
								return "Champignon infect";
							case 61:
								return "Bloc d'ébonite";
							case 62:
								return "Graines d'herbe";
							case 63:
								return "Tournesols";
							case 64:
								return "Vileronce";
							case 65:
								return "Furie stellaire";
							case 66:
								return "Poudre de purification";
							case 67:
								return "Poudre infecte";
							case 68:
								return "Morceau pourri";
							case 69:
								return "Dent de ver";
							case 70:
								return "Nourriture pour ver";
							case 71:
								return "Pièce de cuivre";
							case 72:
								return "Pièce d'argent";
							case 73:
								return "Pièce d'or";
							case 74:
								return "Pièce de platine";
							case 75:
								return "Étoile filante";
							case 76:
								return "Jambières en cuivre";
							case 77:
								return "Jambières en fer";
							case 78:
								return "Jambières en argent";
							case 79:
								return "Jambière en or";
							case 80:
								return "Cotte de mailles en cuivre";
							case 81:
								return "Cotte de mailles en fer";
							case 82:
								return "Cotte de mailles en argent";
							case 83:
								return "Cotte de mailles en or";
							case 84:
								return "Grappin";
							case 85:
								return "Chaîne en fer";
							case 86:
								return "Écaille sombre";
							case 87:
								return "Tirelire";
							case 88:
								return "Casque de mineur";
							case 89:
								return "Casque en cuivre";
							case 90:
								return "Casque en fer";
							case 91:
								return "Casque en argent";
							case 92:
								return "Casque en or";
							case 93:
								return "Mur en bois";
							case 94:
								return "Plateforme en bois";
							case 95:
								return "Pistolet à silex";
							case 96:
								return "Mousquet";
							case 97:
								return "Balle de mousquet";
							case 98:
								return "Minishark";
							case 99:
								return "Arc en fer";
							case 100:
								return "Jambières de l'ombre";
							case 101:
								return "Armure d'écailles de l'ombre";
							case 102:
								return "Casque de l'ombre";
							case 103:
								return "Pioche cauchemardesque";
							case 104:
								return "Le briseur";
							case 105:
								return "Bougie";
							case 106:
								return "Chandelier en cuivre";
							case 107:
								return "Chandelier en argent";
							case 108:
								return "Chandelier en or";
							case 109:
								return "Cristal de mana";
							case 110:
								return "Potion de mana inférieure";
							case 111:
								return "Anneau de pouvoir stellaire";
							case 112:
								return "Fleur de feu";
							case 113:
								return "Missile magique";
							case 114:
								return "Bâtonnet de terre";
							case 115:
								return "Orbe de lumière";
							case 116:
								return "Météorite";
							case 117:
								return "Barre de météorite";
							case 118:
								return "Crochet";
							case 119:
								return "Flamarang";
							case 120:
								return "Furie en fusion";
							case 121:
								return "Grande épée ardente";
							case 122:
								return "Pioche en fusion";
							case 123:
								return "Casque de météore";
							case 124:
								return "Costume de météore";
							case 125:
								return "Leggings de météores";
							case 126:
								return "Eau en bouteille";
							case 127:
								return "Arme d'espace";
							case 128:
								return "Bottes roquettes";
							case 129:
								return "Brique grise";
							case 130:
								return "Mur en briques grises";
							case 131:
								return "Brique rouge";
							case 132:
								return "Mur de briques rouges";
							case 133:
								return "Bloc d'argile";
							case 134:
								return "Brique bleue";
							case 135:
								return "Mur en briques bleues";
							case 136:
								return "Lanterne à chaîne";
							case 137:
								return "Brique verte";
							case 138:
								return "Mur de briques vertes";
							case 139:
								return "Brique rose";
							case 140:
								return "Mur de briques roses";
							case 141:
								return "Brique dorée";
							case 142:
								return "Mur de briques dorées";
							case 143:
								return "Brique argentée";
							case 144:
								return "Mur de briques argentées";
							case 145:
								return "Brique cuivrée";
							case 146:
								return "Mur de briques cuivrées";
							case 147:
								return "Pointe";
							case 148:
								return "Bougie d'eau";
							case 149:
								return "Livre";
							case 150:
								return "Toile d'araignée";
							case 151:
								return "Casque nécro";
							case 152:
								return "Plastron nécro";
							case 153:
								return "Jambières nécro";
							case 154:
								return "Os";
							case 155:
								return "Muramasa";
							case 156:
								return "Bouclier de cobalt";
							case 157:
								return "Sceptre aquatique";
							case 158:
								return "Fer à cheval porte-bonheur";
							case 159:
								return "Ballon rouge brillant";
							case 160:
								return "Harpon";
							case 161:
								return "Balle hérissée";
							case 162:
								return "Ball O' Hurt";
							case 163:
								return "Lune bleue";
							case 164:
								return "Pistolet";
							case 165:
								return "Trait d'eau";
							case 166:
								return "Bombe";
							case 167:
								return "Dynamite";
							case 168:
								return "Grenade";
							case 169:
								return "Bloc de sable";
							case 170:
								return "Verre";
							case 171:
								return "Panneau";
							case 172:
								return "Bloc de cendre";
							case 173:
								return "Obsidienne";
							case 174:
								return "Pierre de l'enfer";
							case 175:
								return "Barre de pierre de l'enfer";
							case 176:
								return "Bloc de boue";
							case 177:
								return "Saphir";
							case 178:
								return "Rubis";
							case 179:
								return "Émeraude";
							case 180:
								return "Topaze";
							case 181:
								return "Améthyste";
							case 182:
								return "Diamant";
							case 183:
								return "Champignon lumineux";
							case 184:
								return "Étoile";
							case 185:
								return "Grappin à lianes";
							case 186:
								return "Tuba";
							case 187:
								return "Palmes";
							case 188:
								return "Potion de soins";
							case 189:
								return "Potion de mana";
							case 190:
								return "Lame de l'herbe";
							case 191:
								return "Chakram d'épines";
							case 192:
								return "Brique d'obsidienne";
							case 193:
								return "Crâne d'obsidienne";
							case 194:
								return "Graines de champignon";
							case 195:
								return "Graines de la jungle";
							case 196:
								return "Marteau en bois";
							case 197:
								return "Canon à étoiles";
							case 198:
								return "Sabre laser bleu";
							case 199:
								return "Sabre laser rouge";
							case 200:
								return "Sabre laser vert";
							case 201:
								return "Sabre laser violet";
							case 202:
								return "Sabre laser blanc";
							case 203:
								return "Sabre laser jaune";
							case 204:
								return "Martache en météorite";
							case 205:
								return "Seau vide";
							case 206:
								return "Seau d'eau";
							case 207:
								return "Seau de lave";
							case 208:
								return "Rose de la jungle";
							case 209:
								return "Dard";
							case 210:
								return "Vigne";
							case 211:
								return "Griffes sauvages";
							case 212:
								return "Bracelet du vent";
							case 213:
								return "Crosse de repousse";
							case 214:
								return "Brique de pierre de l'enfer";
							case 215:
								return "Coussin péteur";
							case 216:
								return "Manille";
							case 217:
								return "Martache en fusion";
							case 218:
								return "Mèche enflammée";
							case 219:
								return "Blaster phénix";
							case 220:
								return "Furie solaire";
							case 221:
								return "Forge infernale";
							case 222:
								return "Pot d'argile";
							case 223:
								return "Don de la nature";
							case 224:
								return "Lit";
							case 225:
								return "Soie";
							case 226:
								return "Potion de restauration inférieure";
							case 227:
								return "Potion de restauration";
							case 228:
								return "Casque de la jungle";
							case 229:
								return "Plastron de la jungle";
							case 230:
								return "Jambières de la jungle";
							case 231:
								return "Casque en fusion";
							case 232:
								return "Plastron en fusion";
							case 233:
								return "Jambières en fusion";
							case 234:
								return "Balle météore";
							case 235:
								return "Bombe collante";
							case 236:
								return "Lentille noire";
							case 237:
								return "Lunettes de soleil";
							case 238:
								return "Chapeau de magicien";
							case 239:
								return "Haut de forme";
							case 240:
								return "Veste de smoking";
							case 241:
								return "Pantalon de smoking";
							case 242:
								return "Chapeau d'été";
							case 243:
								return "Capuche de lapin";
							case 244:
								return "Casquette de plombier";
							case 245:
								return "Veste de plombier";
							case 246:
								return "Pantalon de plombier";
							case 247:
								return "Capuche de héros";
							case 248:
								return "Veste de héros";
							case 249:
								return "Pantalon de héros";
							case 250:
								return "Bocal à poissons";
							case 251:
								return "Chapeau d'archéologue";
							case 252:
								return "Veste d'archéologue";
							case 253:
								return "Pantalon d'archéologue";
							case 254:
								return "Teinture noire";
							case 255:
								return "Teinture verte";
							case 256:
								return "Cagoule de ninja";
							case 257:
								return "Veste de ninja";
							case 258:
								return "Pantalon de ninja";
							case 259:
								return "Cuir";
							case 260:
								return "Chapeau rouge";
							case 261:
								return "Poisson doré";
							case 262:
								return "Robe";
							case 263:
								return "Chapeau de robot";
							case 264:
								return "Couronne d'or";
							case 265:
								return "Flèche du feu de l'enfer";
							case 266:
								return "Canon à sable";
							case 267:
								return "Poupée vaudou du guide";
							case 268:
								return "Casque de plongée";
							case 269:
								return "Chemise familière";
							case 270:
								return "Pantalon familier";
							case 271:
								return "Perruque familière";
							case 272:
								return "Faux de démon";
							case 273:
								return "Fil des Ténèbres";
							case 274:
								return "Lance sombre";
							case 275:
								return "Corail";
							case 276:
								return "Cactus";
							case 277:
								return "Trident";
							case 278:
								return "Balle d'argent";
							case 279:
								return "Couteau de lancer";
							case 280:
								return "Lance";
							case 281:
								return "Sarbacane";
							case 282:
								return "Bâton lumineux";
							case 283:
								return "Graine";
							case 284:
								return "Boomerang en bois";
							case 285:
								return "Embout de lacet";
							case 286:
								return "Bâton lumineux collant";
							case 287:
								return "Couteau empoisonné";
							case 288:
								return "Potion de peau d'obsidienne";
							case 289:
								return "Potion de régénération";
							case 290:
								return "Potion de rapidité";
							case 291:
								return "Potion de branchies";
							case 292:
								return "Potion de peau de fer";
							case 293:
								return "Potion de régénération de mana";
							case 294:
								return "Potion de pouvoir magique";
							case 295:
								return "Potion de poids plume";
							case 296:
								return "Potion de spéléologue";
							case 297:
								return "Potion d'invisibilité";
							case 298:
								return "Potion de brillance";
							case 299:
								return "Potion de vision nocturne";
							case 300:
								return "Potion de bataille";
							case 301:
								return "Potion d'épines";
							case 302:
								return "Potion de marche sur l'eau";
							case 303:
								return "Potion de tir à l'arc";
							case 304:
								return "Potion du chasseur";
							case 305:
								return "Potion de gravité";
							case 306:
								return "Coffre d'or";
							case 307:
								return "Graines de floraison du jour";
							case 308:
								return "Graines de lueur de lune";
							case 309:
								return "Graines de racine clignotante";
							case 310:
								return "Graines de mauvaise herbe morte";
							case 311:
								return "Graines de feuilles de l'eau";
							case 312:
								return "Graines de fleur de feu";
							case 313:
								return "Floraison du jour";
							case 314:
								return "Lueur de lune";
							case 315:
								return "Racine clignotante";
							case 316:
								return "Mauvaise herbe morte";
							case 317:
								return "Feuille de l'eau";
							case 318:
								return "Fleur de feu";
							case 319:
								return "Aileron de requin";
							case 320:
								return "Plume";
							case 321:
								return "Pierre tombale";
							case 322:
								return "Masque du mime";
							case 323:
								return "Mandibule de fourmilion";
							case 324:
								return "Pièces détachées";
							case 325:
								return "Veste du docteur";
							case 326:
								return "Pantalon du docteur";
							case 327:
								return "Clé dorée";
							case 328:
								return "Coffre sombre";
							case 329:
								return "Clé sombre";
							case 330:
								return "Mur de briques d'obsidienne";
							case 331:
								return "Spores de la jungle";
							case 332:
								return "Métier à tisser";
							case 333:
								return "Piano";
							case 334:
								return "Commode";
							case 335:
								return "Banc";
							case 336:
								return "Baignoire";
							case 337:
								return "Bannière rouge";
							case 338:
								return "Bannière verte";
							case 339:
								return "Bannière bleue";
							case 340:
								return "Bannière jaune";
							case 341:
								return "Lampadaire";
							case 342:
								return "Torche de tiki";
							case 343:
								return "Baril";
							case 344:
								return "Lanterne chinoise";
							case 345:
								return "Marmite";
							case 346:
								return "Coffre-fort";
							case 347:
								return "Lanterne crâne";
							case 348:
								return "Poubelle";
							case 349:
								return "Candélabre";
							case 350:
								return "Vase rose";
							case 351:
								return "Chope";
							case 352:
								return "Tonnelet";
							case 353:
								return "Bière";
							case 354:
								return "Bibliothèque";
							case 355:
								return "Trône";
							case 356:
								return "Bol";
							case 357:
								return "Bol de soupe";
							case 358:
								return "Toilettes";
							case 359:
								return "Horloge de grand-père";
							case 360:
								return "Statue d'armure";
							case 361:
								return "Étendard de bataille gobelin";
							case 362:
								return "Vêtements en lambeaux";
							case 363:
								return "Scierie";
							case 364:
								return "Minerai de cobalt";
							case 365:
								return "Minerai de mythril";
							case 366:
								return "Minerai d'adamantine";
							case 367:
								return "Pwnhammer";
							case 368:
								return "Excalibur";
							case 369:
								return "Graines sacrées";
							case 370:
								return "Bloc de sable d'ébène";
							case 371:
								return "Chapeau de cobalt";
							case 372:
								return "Casque de cobalt";
							case 373:
								return "Masque de cobalt";
							case 374:
								return "Plastron de cobalt";
							case 375:
								return "Jambières de cobalt";
							case 376:
								return "Capuche de mythril";
							case 377:
								return "Casque de mythril";
							case 378:
								return "Chapeau de mythril";
							case 379:
								return "Cotte de mailles de mythril";
							case 380:
								return "Jambières de mythril";
							case 381:
								return "Barre de cobalt";
							case 382:
								return "Barre de mythril";
							case 383:
								return "Tronçonneuse de cobalt";
							case 384:
								return "Tronçonneuse de mythril";
							case 385:
								return "Perceuse de cobalt";
							case 386:
								return "Perceuse de mythril";
							case 387:
								return "Tronçonneuse d'adamantine";
							case 388:
								return "Perceuse d'adamantine";
							case 389:
								return "Dao de Pow";
							case 390:
								return "Hallebarde de mythril";
							case 391:
								return "Barre d'amantine";
							case 392:
								return "Mur de verre";
							case 393:
								return "Boussole";
							case 394:
								return "Équipement de plongée";
							case 395:
								return "GPS";
							case 396:
								return "Fer à cheval d'obsidienne";
							case 397:
								return "Bouclier d'obsidienne";
							case 398:
								return "Atelier du bricoleur";
							case 399:
								return "Nuage dans un ballon";
							case 400:
								return "Coiffe d'adamantine";
							case 401:
								return "Casque d'adamantine";
							case 402:
								return "Masque d'adamantine";
							case 403:
								return "Plastron d'adamantine";
							case 404:
								return "Jambières en adamantine";
							case 405:
								return "Bottes spectrales";
							case 406:
								return "Glaive d'adamantine";
							case 407:
								return "Ceinture d'outils";
							case 408:
								return "Bloc de sable de perle";
							case 409:
								return "Bloc de pierre de perle";
							case 410:
								return "Veste de mineur";
							case 411:
								return "Pantalon de mineur";
							case 412:
								return "Brique de pierre de perle";
							case 413:
								return "Brique iridescente";
							case 414:
								return "Bloc de pierre de terre";
							case 415:
								return "Brique de cobalt";
							case 416:
								return "Brique de mythril";
							case 417:
								return "Mur de briques de pierre de perle";
							case 418:
								return "Mur de briques iridescentes";
							case 419:
								return "Mur de briques de pierre de terre";
							case 420:
								return "Mur de briques de cobalt";
							case 421:
								return "Mur de briques de mythril";
							case 422:
								return "Eau bénite";
							case 423:
								return "Eau impie";
							case 424:
								return "Bloc de limon";
							case 425:
								return "Clochette de fée";
							case 426:
								return "Lame du briseur";
							case 427:
								return "Torche bleue";
							case 428:
								return "Torche rouge";
							case 429:
								return "Torche verte";
							case 430:
								return "Torche violette";
							case 431:
								return "Torche blanche";
							case 432:
								return "Torche jaune";
							case 433:
								return "Torche du démon";
							case 434:
								return "Fusil d'assaut mécanique";
							case 435:
								return "Arbalète en cobalt";
							case 436:
								return "Arbalète en mythril";
							case 437:
								return "Crochet Double";
							case 438:
								return "Statue d'étoile";
							case 439:
								return "Statue d'épée";
							case 440:
								return "Statue de slime";
							case 441:
								return "Statue de gobelin";
							case 442:
								return "Statue de bouclier";
							case 443:
								return "Statue de chauve-souris";
							case 444:
								return "Statue de poisson";
							case 445:
								return "Statue de lapin";
							case 446:
								return "Statue de squelette";
							case 447:
								return "Statue de faucheur";
							case 448:
								return "Statue de femme";
							case 449:
								return "Statue de diablotin";
							case 450:
								return "Statue de gargouille";
							case 451:
								return "Statue de morosité";
							case 452:
								return "Statue de frelon";
							case 453:
								return "Statue de bombe";
							case 454:
								return "Statue de crabe";
							case 455:
								return "Statue de marteau";
							case 456:
								return "Statue de potion";
							case 457:
								return "Statue de lance";
							case 458:
								return "Statue de croix";
							case 459:
								return "Statue de méduse";
							case 460:
								return "Statue d'arc";
							case 461:
								return "Statue de boomerang";
							case 462:
								return "Statue de botte";
							case 463:
								return "Statue de coffre";
							case 464:
								return "Statue d'oiseau";
							case 465:
								return "Statue de hache";
							case 466:
								return "Statue corrompue";
							case 467:
								return "Statue d'arbre";
							case 468:
								return "Statue d'enclume";
							case 469:
								return "Statue de pioche";
							case 470:
								return "Statue de champignon";
							case 471:
								return "Statue d'œil";
							case 472:
								return "Statue de pilier";
							case 473:
								return "Statue de cœur";
							case 474:
								return "Statue de pot";
							case 475:
								return "Statue de tournesol";
							case 476:
								return "Statue de roi";
							case 477:
								return "Statue de reine";
							case 478:
								return "Statue de piranha";
							case 479:
								return "Mur de planches";
							case 480:
								return "Poutre de bois";
							case 481:
								return "Arbalète d'adamantine";
							case 482:
								return "Épée d'adamantine";
							case 483:
								return "Épée de cobalt";
							case 484:
								return "Épée de mythril";
							case 485:
								return "Sortilège lunaire";
							case 486:
								return "Règle";
							case 487:
								return "Boule de cristal";
							case 488:
								return "Boule à facettes";
							case 489:
								return "Emblème sorcier";
							case 490:
								return "Emblème guerrier";
							case 491:
								return "Emblème ranger";
							case 492:
								return "Ailes de démon";
							case 493:
								return "Ailes d'ange";
							case 494:
								return "Harpe magique";
							case 495:
								return "Bâton d'arc-en-ciel";
							case 496:
								return "Bâton de glace";
							case 497:
								return "Coquillage de Neptune";
							case 498:
								return "Mannequin";
							case 499:
								return "Potion de soins supérieure";
							case 500:
								return "Potion de mana supérieure";
							case 501:
								return "Poudre de fée";
							case 502:
								return "Éclat de cristal";
							case 503:
								return "Chapeau de clown";
							case 504:
								return "Veste de clown";
							case 505:
								return "Pantalon de clown";
							case 506:
								return "Lance-flammes";
							case 507:
								return "Cloche";
							case 508:
								return "Harpe";
							case 509:
								return "Clé à molette";
							case 510:
								return "Pince coupante";
							case 511:
								return "Bloc de pierre actif";
							case 512:
								return "Bloc de pierre inactif";
							case 513:
								return "Levier";
							case 514:
								return "Fusil laser";
							case 515:
								return "Balle de cristal";
							case 516:
								return "Flèche bénite";
							case 517:
								return "Dague magique";
							case 518:
								return "Tempête de cristal";
							case 519:
								return "Flammes maudites";
							case 520:
								return "Âme de lumière";
							case 521:
								return "Âme de la nuit";
							case 522:
								return "Flamme maudite";
							case 523:
								return "Torche maudite";
							case 524:
								return "Forge en adamantine";
							case 525:
								return "Enclume en mythril";
							case 526:
								return "Corne de licorne";
							case 527:
								return "Éclat sombre";
							case 528:
								return "Éclat de lumière";
							case 529:
								return "Plaque de pression rouge";
							case 530:
								return "Câble";
							case 531:
								return "Livre de sorts";
							case 532:
								return "Cape stellaire";
							case 533:
								return "Mégashark";
							case 534:
								return "Fusil à pompe";
							case 535:
								return "Pierre du philosophe";
							case 536:
								return "Gant du titan";
							case 537:
								return "Naginata en cobalt";
							case 538:
								return "Interrupteur";
							case 539:
								return "Piège à fléchette";
							case 540:
								return "Rocher";
							case 541:
								return "Plaque de pression verte";
							case 542:
								return "Plaque de pression grise";
							case 543:
								return "Plaque de pression marron";
							case 544:
								return "Œil mécanique";
							case 545:
								return "Flèche maudite";
							case 546:
								return "Balle maudite";
							case 547:
								return "Âme d'effroi";
							case 548:
								return "Âme de pouvoir";
							case 549:
								return "Âme de vision";
							case 550:
								return "Gungnir";
							case 551:
								return "Armure de plaques sacrée";
							case 552:
								return "Jambières sacrées";
							case 553:
								return "Casque sacré";
							case 554:
								return "Pendentif en croix";
							case 555:
								return "Fleur de mana";
							case 556:
								return "Ver mécanique";
							case 557:
								return "Crâne mécanique";
							case 558:
								return "Coiffe sacrée";
							case 559:
								return "Masque sacré";
							case 560:
								return "Couronne de slime";
							case 561:
								return "Disque de lumière";
							case 562:
								return "Boîte à musique (Jour du monde supérieur)";
							case 563:
								return "Boîte à musique (Surnaturel)";
							case 564:
								return "Boîte à musique (Nuit)";
							case 565:
								return "Boîte à musique (Titre)";
							case 566:
								return "Boîte à musique (Souterrain)";
							case 567:
								return "Boîte à musique (Boss 1)";
							case 568:
								return "Boîte à musique (Jungle)";
							case 569:
								return "Boîte à musique(Corruption)";
							case 570:
								return "Boîte à musique (Corruption du souterrain)";
							case 571:
								return "Boîte à musique (La purification)";
							case 572:
								return "Boîte à musique (Boss 2)";
							case 573:
								return "Boîte à musique (Purification du souterrain)";
							case 574:
								return "Boîte à musique (Boss 3)";
							case 575:
								return "Âme du vol";
							case 576:
								return "Boîte à musique";
							case 577:
								return "Brique de démonite";
							case 578:
								return "Arbalète bénie";
							case 579:
								return "Hâche-marteau";
							case 580:
								return "Explosifs";
							case 581:
								return "Poste de pompage";
							case 582:
								return "Sortie de pompage";
							case 583:
								return "Minuteur d'une seconde";
							case 584:
								return "Minuteur de 3 secondes";
							case 585:
								return "Minuteur de 5 secondes";
							case 586:
								return "Bloc Candy Cane";
							case 587:
								return "Candy Cane mur";
							case 588:
								return "Santa Hat";
							case 589:
								return "Père shirt";
							case 590:
								return "Pantalon de Santa";
							case 591:
								return "Bloc vert Candy Cane";
							case 592:
								return "Vert Candy Cane mur";
							case 593:
								return "neige bloc";
							case 594:
								return "brique de neige";
							case 595:
								return "Mur de briques de neige";
							case 596:
								return "Blue Light";
							case 597:
								return "Red Light";
							case 598:
								return "Green Light";
							case 599:
								return "présent Bleu";
							case 600:
								return "présent vert";
							case 601:
								return "présent jaune";
							case 602:
								return "Globe de neige";
							case 603:
								return "Carotte";
							}
						}
						else
						{
							if (Lang.lang == 5)
							{
								switch (l)
								{
								case -24:
									return "Sable de luz amarillo";
								case -23:
									return "Sable de luz blanco";
								case -22:
									return "Sable de luz morado";
								case -21:
									return "Sable de luz verde";
								case -20:
									return "Sable de luz rojo";
								case -19:
									return "Sable de luz azul";
								case -18:
									return "Arco de cobre";
								case -17:
									return "Martillo de cobre";
								case -16:
									return "Hacha de cobre";
								case -15:
									return "Espada corta de cobre";
								case -14:
									return "Espada larga de cobre";
								case -13:
									return "Pico de cobre";
								case -12:
									return "Arco de plata";
								case -11:
									return "Martillo de plata";
								case -10:
									return "Hacha de plata";
								case -9:
									return "Espada corta de plata";
								case -8:
									return "Espada larga de plata";
								case -7:
									return "Pico de plata";
								case -6:
									return "Arco de oro";
								case -5:
									return "Martillo de oro";
								case -4:
									return "Hacha de oro";
								case -3:
									return "Espada corta de oro";
								case -2:
									return "Espada larga de oro";
								case -1:
									return "Pico de oro";
								case 1:
									return "Pico de hierro";
								case 2:
									return "Bloque de tierra";
								case 3:
									return "Bloque de piedra";
								case 4:
									return "Espada larga de hierro";
								case 5:
									return "Champiñón";
								case 6:
									return "Espada corta de hierro";
								case 7:
									return "Martillo de hierro";
								case 8:
									return "Antorcha";
								case 9:
									return "Madera";
								case 10:
									return "Hacha de hierro";
								case 11:
									return "Mineral de hierro";
								case 12:
									return "Mineral de cobre";
								case 13:
									return "Mineral de oro";
								case 14:
									return "Mineral de plata";
								case 15:
									return "Reloj de cobre";
								case 16:
									return "Reloj de plata";
								case 17:
									return "Reloj de oro";
								case 18:
									return "Medidor de profundidad";
								case 19:
									return "Lingote de oro";
								case 20:
									return "Lingote de cobre";
								case 21:
									return "Lingote de plata";
								case 22:
									return "Lingote de hierro";
								case 23:
									return "Baba";
								case 24:
									return "Espada de madera";
								case 25:
									return "Puerta de madera";
								case 26:
									return "Pared de piedra";
								case 27:
									return "Bellota";
								case 28:
									return "Poción curativa menor";
								case 29:
									return "Cristal de vida";
								case 30:
									return "Pared de tierra";
								case 31:
									return "Botella";
								case 32:
									return "Mesa de madera";
								case 33:
									return "Horno";
								case 34:
									return "Silla de madera";
								case 35:
									return "Yunque de hierro";
								case 36:
									return "Banco de trabajo";
								case 37:
									return "Gafas de protección";
								case 38:
									return "Lentes";
								case 39:
									return "Arco de madera";
								case 40:
									return "Flecha de madera";
								case 41:
									return "Flecha ardiente";
								case 42:
									return "Cuchillas ninja";
								case 43:
									return "Ojo de mirada desconfiada";
								case 44:
									return "Arco demoníaco";
								case 45:
									return "Hacha de la noche";
								case 46:
									return "Espada de la luz";
								case 47:
									return "Flecha infame";
								case 48:
									return "Cofre";
								case 49:
									return "Banda de regeneración";
								case 50:
									return "Espejo mágico";
								case 51:
									return "Flecha de bufón";
								case 52:
									return "Estatua de ángel";
								case 53:
									return "Nube embotellada";
								case 54:
									return "Botas de Hermes";
								case 55:
									return "Bumerán encantado";
								case 56:
									return "Mineral endemoniado";
								case 57:
									return "Lingote endemoniado";
								case 58:
									return "Corazón";
								case 59:
									return "Semillas corrompidas";
								case 60:
									return "Champiñón vil";
								case 61:
									return "Bloque de piedra de ébano";
								case 62:
									return "Semillas de césped";
								case 63:
									return "Girasol";
								case 64:
									return "Lanzador de espina vil";
								case 65:
									return "Furia de estrellas";
								case 66:
									return "Polvo de purificación";
								case 67:
									return "Polvo vil";
								case 68:
									return "Trozo podrido";
								case 69:
									return "Diente de gusano";
								case 70:
									return "Cebo de gusanos";
								case 71:
									return "Moneda de cobre";
								case 72:
									return "Moneda de plata";
								case 73:
									return "Moneda de oro";
								case 74:
									return "Moneda de platino";
								case 75:
									return "Estrella caída";
								case 76:
									return "Grebas de cobre";
								case 77:
									return "Grebas de hierro";
								case 78:
									return "Grebas de plata";
								case 79:
									return "Grebas de oro";
								case 80:
									return "Cota de malla de cobre";
								case 81:
									return "Cota de malla de hierro";
								case 82:
									return "Cota de malla de plata";
								case 83:
									return "Cota de malla de oro";
								case 84:
									return "Garfio extensible";
								case 85:
									return "Cadena de hierro";
								case 86:
									return "Escama de las sombras";
								case 87:
									return "Hucha";
								case 88:
									return "Casco de minero";
								case 89:
									return "Casco de cobre";
								case 90:
									return "Casco de hierro";
								case 91:
									return "Casco de plata";
								case 92:
									return "Casco de oro";
								case 93:
									return "Pared de madera";
								case 94:
									return "Plataforma de madera";
								case 95:
									return "Pistola de pedernal";
								case 96:
									return "Mosquetón";
								case 97:
									return "Bala de mosquetón";
								case 98:
									return "Minitiburón";
								case 99:
									return "Arco de hierro";
								case 100:
									return "Grebas de las sombras";
								case 101:
									return "Cota de escamas de las sombras";
								case 102:
									return "Casco de las sombras";
								case 103:
									return "Pico de pesadilla";
								case 104:
									return "La despedazadora";
								case 105:
									return "Vela";
								case 106:
									return "Lámpara araña de cobre";
								case 107:
									return "Lámpara araña de plata";
								case 108:
									return "Lámpara araña de oro";
								case 109:
									return "Cristal de maná";
								case 110:
									return "Poción de maná menor";
								case 111:
									return "Banda de polvo de estrellas";
								case 112:
									return "Flor de fuego";
								case 113:
									return "Misil mágico";
								case 114:
									return "Varita de tierra";
								case 115:
									return "Orbe de Luz";
								case 116:
									return "Meteorito";
								case 117:
									return "Lingote de meteorito";
								case 118:
									return "Garfio";
								case 119:
									return "Bumerán de llamas";
								case 120:
									return "Furia fundida";
								case 121:
									return "Gran espada ardiente";
								case 122:
									return "Pico fundido";
								case 123:
									return "Casco de meteorito";
								case 124:
									return "Cota de meteorito";
								case 125:
									return "Polainas de meteoritos";
								case 126:
									return "Agua embotellada";
								case 127:
									return "Espacio de arma de fuego";
								case 128:
									return "Botas cohete";
								case 129:
									return "Ladrillo gris";
								case 130:
									return "Pared de ladrillo gris";
								case 131:
									return "Ladrillo rojo";
								case 132:
									return "Pared de ladrillo rojo";
								case 133:
									return "Bloque de arcilla";
								case 134:
									return "Ladrillo azul";
								case 135:
									return "Pared de ladrillo azul";
								case 136:
									return "Farolillo";
								case 137:
									return "Ladrillo verde";
								case 138:
									return "Pared de ladrillo verde";
								case 139:
									return "Ladrillo rosa";
								case 140:
									return "Pared de ladrillo rosa";
								case 141:
									return "Ladrillo dorado";
								case 142:
									return "Pared de ladrillo dorado";
								case 143:
									return "Ladrillo plateado";
								case 144:
									return "Pared de ladrillo plateado";
								case 145:
									return "Ladrillo cobrizo";
								case 146:
									return "Pared de ladrillo cobrizo";
								case 147:
									return "Púa";
								case 148:
									return "Vela de agua";
								case 149:
									return "Libro";
								case 150:
									return "Telaraña";
								case 151:
									return "Casco de los muertos";
								case 152:
									return "Peto de los muertos";
								case 153:
									return "Grebas de los muertos";
								case 154:
									return "Hueso";
								case 155:
									return "Catana Muramasa";
								case 156:
									return "Escudo de cobalto";
								case 157:
									return "Cetro de agua";
								case 158:
									return "Herradura de la suerte";
								case 159:
									return "Globo rojo brillante";
								case 160:
									return "Arpón";
								case 161:
									return "Bola con pinchos";
								case 162:
									return "Flagelo con bola";
								case 163:
									return "Luna azul";
								case 164:
									return "Pistola";
								case 165:
									return "Rayo de agua";
								case 166:
									return "Bomba";
								case 167:
									return "Dinamita";
								case 168:
									return "Granada";
								case 169:
									return "Bloque de arena";
								case 170:
									return "Cristal";
								case 171:
									return "Cartel";
								case 172:
									return "Bloque de ceniza";
								case 173:
									return "Obsidiana";
								case 174:
									return "Piedra infernal";
								case 175:
									return "Lingote de piedra infernal";
								case 176:
									return "Bloque de lodo";
								case 177:
									return "Zafiro";
								case 178:
									return "Rubí";
								case 179:
									return "Esmeralda";
								case 180:
									return "Topacio";
								case 181:
									return "Amatista";
								case 182:
									return "Diamante";
								case 183:
									return "Champiñón brillante";
								case 184:
									return "Estrella";
								case 185:
									return "Látigo de hiedra";
								case 186:
									return "Caña para respirar";
								case 187:
									return "Aletas";
								case 188:
									return "Poción curativa";
								case 189:
									return "Poción de maná";
								case 190:
									return "Espada de hierba";
								case 191:
									return "Chakram de espinas";
								case 192:
									return "Ladrillo de obsidiana";
								case 193:
									return "Cráneo de obsidiana";
								case 194:
									return "Semillas de césped para champiñón";
								case 195:
									return "Semillas de césped para selva";
								case 196:
									return "Martillo de madera";
								case 197:
									return "Cañón de estrellas";
								case 198:
									return "Espada de luz azul";
								case 199:
									return "Espada de luz roja";
								case 200:
									return "Espada de luz verde";
								case 201:
									return "Espada de luz morada";
								case 202:
									return "Espada de luz blanca";
								case 203:
									return "Espada de luz amarilla";
								case 204:
									return "Hacha-martillo de meteorito";
								case 205:
									return "Cubo vacío";
								case 206:
									return "Cubo de agua";
								case 207:
									return "Cubo de lava";
								case 208:
									return "Rosa de la selva";
								case 209:
									return "Aguijón";
								case 210:
									return "Enredadera";
								case 211:
									return "Garras de bestia";
								case 212:
									return "Tobillera de viento";
								case 213:
									return "Báculo de regeneración";
								case 214:
									return "Ladrillo de piedra infernal";
								case 215:
									return "Cojín flatulento";
								case 216:
									return "Argolla";
								case 217:
									return "Hacha-martillo fundido";
								case 218:
									return "Látigo de llamas";
								case 219:
									return "Desintegrador Fénix";
								case 220:
									return "Furia solar";
								case 221:
									return "Forjas infernal";
								case 222:
									return "Marmita de arcilla";
								case 223:
									return "Don de la naturaleza";
								case 224:
									return "Cama";
								case 225:
									return "Seda";
								case 226:
									return "Poción de recuperación menor";
								case 227:
									return "Poción de recuperación";
								case 228:
									return "Casco para la selva";
								case 229:
									return "Camisa para la selva";
								case 230:
									return "Pantalones para la selva";
								case 231:
									return "Casco fundido";
								case 232:
									return "Peto fundido";
								case 233:
									return "Grebas fundidas";
								case 234:
									return "proyectil de meteorito";
								case 235:
									return "Bomba lapa";
								case 236:
									return "Lentes negras";
								case 237:
									return "Gafas de sol";
								case 238:
									return "Sombrero de mago";
								case 239:
									return "Sombrero de copa";
								case 240:
									return "Camisa de esmoquin";
								case 241:
									return "Pantalones de esmoquin";
								case 242:
									return "Sombrero veraniego";
								case 243:
									return "Máscara de conejito";
								case 244:
									return "Gorra de fontanero";
								case 245:
									return "Camisa de fontanero";
								case 246:
									return "Pantalones de fontanero";
								case 247:
									return "Gorro de héroe";
								case 248:
									return "Camisa de héroe";
								case 249:
									return "Pantalones de héroe";
								case 250:
									return "Pecera";
								case 251:
									return "Sombrero de arqueólogo";
								case 252:
									return "Chaqueta de arqueólogo";
								case 253:
									return "Pantalones de arqueólogo";
								case 254:
									return "Tinte negro";
								case 255:
									return "Tinte verde";
								case 256:
									return "Gorro de ninja";
								case 257:
									return "Camisa de ninja";
								case 258:
									return "Pantalones de ninja";
								case 259:
									return "Cuero";
								case 260:
									return "Sombrero rojo";
								case 261:
									return "Pececillo";
								case 262:
									return "Vestido";
								case 263:
									return "Sombrero de robot";
								case 264:
									return "Corona de oro";
								case 265:
									return "Flecha de fuego infernal";
								case 266:
									return "Pistola de arena";
								case 267:
									return "Muñeco vudú del Guía";
								case 268:
									return "Casco de buceo";
								case 269:
									return "Camisa informal";
								case 270:
									return "Pantalones informales";
								case 271:
									return "Peluca informal";
								case 272:
									return "Guadaña demoníaca";
								case 273:
									return "Espada de la noche";
								case 274:
									return "Lanza de la oscuridad";
								case 275:
									return "Coral";
								case 276:
									return "Cactus";
								case 277:
									return "Tridente";
								case 278:
									return "Bala de plata";
								case 279:
									return "Cuchillo arrojadizo";
								case 280:
									return "Lanza";
								case 281:
									return "Cerbatana";
								case 282:
									return "Barrita luminosa";
								case 283:
									return "Semilla";
								case 284:
									return "Bumerán de madera";
								case 285:
									return "Herrete";
								case 286:
									return "Barrita luminosa lapa";
								case 287:
									return "Cuchillo envenenado";
								case 288:
									return "Poción de piel obsidiana";
								case 289:
									return "Poción de regeneración";
								case 290:
									return "Poción de rapidez";
								case 291:
									return "Poción de agallas";
								case 292:
									return "Poción de piel de hierro";
								case 293:
									return "Poción de regeneración de maná";
								case 294:
									return "Poción de poder mágico";
								case 295:
									return "Poción de caída de pluma";
								case 296:
									return "Poción de espeleólogo";
								case 297:
									return "Poción de invisibilidad";
								case 298:
									return "Poción de brillo";
								case 299:
									return "Poción de noctámbulo";
								case 300:
									return "Poción de batalla";
								case 301:
									return "Poción de espinas";
								case 302:
									return "Poción caminando sobre el agua";
								case 303:
									return "Poción de tiro con arco";
								case 304:
									return "Poción de cazador";
								case 305:
									return "Poción de gravedad";
								case 306:
									return "Cofre de oro";
								case 307:
									return "Semillas de resplandor del día";
								case 308:
									return "Semillas de luz de luna";
								case 309:
									return "Semillas de raíz de resplandor";
								case 310:
									return "Semillas de malahierba";
								case 311:
									return "Semillas de hoja de agua";
								case 312:
									return "Semillas de resplandor de fuego";
								case 313:
									return "Resplandor del día";
								case 314:
									return "Luz de luna";
								case 315:
									return "Raíz de resplandor";
								case 316:
									return "Malahierba";
								case 317:
									return "Hoja de agua";
								case 318:
									return "Resplandor de fuego";
								case 319:
									return "Aleta de tiburón";
								case 320:
									return "Pluma";
								case 321:
									return "Lápida";
								case 322:
									return "Máscara de mimo";
								case 323:
									return "Mandíbula de hormiga león";
								case 324:
									return "Accesorios de arma ilegales";
								case 325:
									return "Camisa del doctor";
								case 326:
									return "Pantalones del doctor";
								case 327:
									return "Llave dorada";
								case 328:
									return "Cofre de las sombras";
								case 329:
									return "Llave de las sombras";
								case 330:
									return "Pared de ladrillo de obsidiana";
								case 331:
									return "Esporas de la selva";
								case 332:
									return "Telar";
								case 333:
									return "Piano";
								case 334:
									return "Aparador";
								case 335:
									return "Banco";
								case 336:
									return "Bañera";
								case 337:
									return "Estandarte rojo";
								case 338:
									return "Estandarte verde";
								case 339:
									return "Estandarte azul";
								case 340:
									return "Estandarte amarillo";
								case 341:
									return "Farola";
								case 342:
									return "Antorcha Tiki";
								case 343:
									return "Barril";
								case 344:
									return "Farolillo de papel";
								case 345:
									return "Perol";
								case 346:
									return "Caja fuerte";
								case 347:
									return "Cráneo con vela";
								case 348:
									return "Cubo de basura";
								case 349:
									return "Candelabro";
								case 350:
									return "Probeta rosa";
								case 351:
									return "Taza";
								case 352:
									return "Barrica";
								case 353:
									return "Cerveza";
								case 354:
									return "Librería";
								case 355:
									return "Trono";
								case 356:
									return "Cuenco";
								case 357:
									return "Cuenco de sopa";
								case 358:
									return "Retrete";
								case 359:
									return "Reloj de pie";
								case 360:
									return "Estatua de armadura";
								case 361:
									return "Batalla de duendes convencional";
								case 362:
									return "Harapos";
								case 363:
									return "Serrería";
								case 364:
									return "Mineral de cobalto";
								case 365:
									return "Mineral de mithril";
								case 366:
									return "Mineral de adamantita";
								case 367:
									return "Gran martillo";
								case 368:
									return "Excalibur";
								case 369:
									return "Semillas bendecidas";
								case 370:
									return "Bloque de arena de ébano";
								case 371:
									return "Gorro de cobalto";
								case 372:
									return "Casco de cobalto";
								case 373:
									return "Máscara de cobalto";
								case 374:
									return "Peto de cobalto";
								case 375:
									return "Polainas de cobalto";
								case 376:
									return "Caperuza de mithril";
								case 377:
									return "Casco de mithril";
								case 378:
									return "Gorro de mithril";
								case 379:
									return "Cota de malla de mithril";
								case 380:
									return "Grebas de mithril";
								case 381:
									return "Lingote de cobalto";
								case 382:
									return "Lingote de mithril";
								case 383:
									return "Motosierra de cobalto";
								case 384:
									return "Motosierra de mithril";
								case 385:
									return "Taladro de cobalto";
								case 386:
									return "Taladro de mithril";
								case 387:
									return "Motosierra de adamantita";
								case 388:
									return "Taladro de adamantita";
								case 389:
									return "Flagelo Taoísta";
								case 390:
									return "Alabarda de mithril";
								case 391:
									return "Lingote de adamantita";
								case 392:
									return "Cristal de pared";
								case 393:
									return "Brújula";
								case 394:
									return "Equipo de buceo";
								case 395:
									return "GPS";
								case 396:
									return "Herradura de obsidiana";
								case 397:
									return "Escudo de obsidiana";
								case 398:
									return "Taller del reparador";
								case 399:
									return "Globo de nube";
								case 400:
									return "Tocado de adamantita";
								case 401:
									return "Casco de adamantita";
								case 402:
									return "Máscara de adamantita";
								case 403:
									return "Peto de adamantita";
								case 404:
									return "Polainas de adamantita";
								case 405:
									return "Botas de espectro";
								case 406:
									return "Lanza de adamantita";
								case 407:
									return "Cinturón de herramientas";
								case 408:
									return "Bloque de arena de perla";
								case 409:
									return "Bloque de piedra perlada";
								case 410:
									return "Camisa de minero";
								case 411:
									return "Pantalones de minero";
								case 412:
									return "Ladrillo de piedra perlada";
								case 413:
									return "Ladrillo tornasol";
								case 414:
									return "Bloque de lutita";
								case 415:
									return "Ladrillo de cobalto";
								case 416:
									return "Ladrillo de mithril";
								case 417:
									return "Pared de ladrillo de piedra perlada";
								case 418:
									return "Pared de ladrillo tornasol";
								case 419:
									return "Pared de ladrillo de lutita";
								case 420:
									return "Pared de ladrillo de cobalto";
								case 421:
									return "Pared de ladrillo de mithril";
								case 422:
									return "Agua sagrada";
								case 423:
									return "Agua impura";
								case 424:
									return "Bloque de limo";
								case 425:
									return "Campana de hada";
								case 426:
									return "Espada despedazadora";
								case 427:
									return "Antorcha azul";
								case 428:
									return "Antorcha rojo";
								case 429:
									return "Antorcha verde";
								case 430:
									return "Antorcha morada";
								case 431:
									return "Antorcha blanca";
								case 432:
									return "Antorcha amarilla";
								case 433:
									return "Antorcha demoníaca";
								case 434:
									return "Fusil de asalto de precisión";
								case 435:
									return "Repetidor de cobalto";
								case 436:
									return "Repetidor de mithril";
								case 437:
									return "Gancho doble";
								case 438:
									return "Estatua de estrella";
								case 439:
									return "Estatua de espada";
								case 440:
									return "Estatua de babosa";
								case 441:
									return "Estatua de duende";
								case 442:
									return "Estatua de escudo";
								case 443:
									return "Estatua de murciélago";
								case 444:
									return "Estatua de pez";
								case 445:
									return "Estatua de conejito";
								case 446:
									return "Estatua de esqueleto";
								case 447:
									return "Estatua de la Muerte";
								case 448:
									return "Estatua de mujer";
								case 449:
									return "Estatua de diablillo";
								case 450:
									return "Estatua de gárgola";
								case 451:
									return "Estatua de Melancolía";
								case 452:
									return "Estatua de avispón";
								case 453:
									return "Estatua de bomba";
								case 454:
									return "Estatua de cangrejo";
								case 455:
									return "Estatua de martilla";
								case 456:
									return "Estatua de poción";
								case 457:
									return "Estatua de lanza";
								case 458:
									return "Estatua de cruz";
								case 459:
									return "Estatua de medusa";
								case 460:
									return "Estatua de arco";
								case 461:
									return "Estatua de bumerán";
								case 462:
									return "Estatua de bota";
								case 463:
									return "Estatua de cofre";
								case 464:
									return "Estatua de pájaro";
								case 465:
									return "Estatua de hacha";
								case 466:
									return "Estatua de corrupción";
								case 467:
									return "Estatua de árbol";
								case 468:
									return "Estatua de yunque";
								case 469:
									return "Estatua de pico";
								case 470:
									return "Estatua de champiñón";
								case 471:
									return "Estatua de ojo";
								case 472:
									return "Estatua de columna";
								case 473:
									return "Estatua de corazón";
								case 474:
									return "Estatua de marmita";
								case 475:
									return "Estatua de girasol";
								case 476:
									return "Estatua de rey";
								case 477:
									return "Estatua de reina";
								case 478:
									return "Estatua de piraña";
								case 479:
									return "Pared de tablones";
								case 480:
									return "Viga de madera";
								case 481:
									return "Repetidor de adamantita";
								case 482:
									return "Espada de adamantita";
								case 483:
									return "Espada de cobalto";
								case 484:
									return "Espada de mithril";
								case 485:
									return "Hechizo de luna";
								case 486:
									return "Regla";
								case 487:
									return "Bola de cristal";
								case 488:
									return "Bola de discoteca";
								case 489:
									return "Emblema de hechicero";
								case 490:
									return "Emblema de guerrero";
								case 491:
									return "Emblema de guardián";
								case 492:
									return "Alas demoníacas";
								case 493:
									return "Alas de ángel";
								case 494:
									return "Arpa mágica";
								case 495:
									return "Varita multicolor";
								case 496:
									return "Varita helada";
								case 497:
									return "Concha de Neptuno";
								case 498:
									return "Maniquí";
								case 499:
									return "Poción curativa mayor";
								case 500:
									return "Poción de maná mayor";
								case 501:
									return "Polvo de hada";
								case 502:
									return "Fragmento de cristal";
								case 503:
									return "Sombrero de payaso";
								case 504:
									return "Camisa de payaso";
								case 505:
									return "Pantalones de payaso";
								case 506:
									return "Lanzallamas";
								case 507:
									return "Campana";
								case 508:
									return "Arpa";
								case 509:
									return "Llave inglesa";
								case 510:
									return "Alicates";
								case 511:
									return "Bloque de piedra activo";
								case 512:
									return "Bloque de piedra inactivo";
								case 513:
									return "Palanca";
								case 514:
									return "Fusil láser";
								case 515:
									return "Bala de cristal";
								case 516:
									return "Flecha sagrada";
								case 517:
									return "Daga mágica";
								case 518:
									return "Tormenta de cristal";
								case 519:
									return "Llamas malditas";
								case 520:
									return "Alma de luz";
								case 521:
									return "Alma de noche";
								case 522:
									return "Llama maldita";
								case 523:
									return "Antorcha maldita";
								case 524:
									return "Forja de adamantita";
								case 525:
									return "Yunque de mithril";
								case 526:
									return "Cuerno de unicornio";
								case 527:
									return "Fragmento de oscuridad";
								case 528:
									return "Fragmento de luz";
								case 529:
									return "Chapa de presión roja";
								case 530:
									return "Alambre";
								case 531:
									return "Tomo encantado";
								case 532:
									return "Manto de estrellas";
								case 533:
									return "Megatiburón";
								case 534:
									return "Escopeta";
								case 535:
									return "Piedra filosofal";
								case 536:
									return "Guante de Titán";
								case 537:
									return "Naginata de cobalto";
								case 538:
									return "Interruptor";
								case 539:
									return "Trampa de dardos";
								case 540:
									return "Roca";
								case 541:
									return "Chapa de presión verde";
								case 542:
									return "Chapa de presión gris";
								case 543:
									return "Chapa de presión marrón";
								case 544:
									return "Ojo mecánico";
								case 545:
									return "Flecha maldita";
								case 546:
									return "Bala maldita";
								case 547:
									return "Alma de terror";
								case 548:
									return "Alma de poder";
								case 549:
									return "Alma de visión";
								case 550:
									return "Gungnir";
								case 551:
									return "Cota de chapas bendecida";
								case 552:
									return "Grebas bendecidas";
								case 553:
									return "Casco bendecido";
								case 554:
									return "Collar con cruz";
								case 555:
									return "Flor de maná";
								case 556:
									return "Gusano mecánico";
								case 557:
									return "Cráneo mecánico";
								case 558:
									return "Tocado bendecido";
								case 559:
									return "Máscara bendecida";
								case 560:
									return "Corona de babosa";
								case 561:
									return "Disco de luz";
								case 562:
									return "Caja de música (Superficie de día)";
								case 563:
									return "Caja de música (Sobrecogedor)";
								case 564:
									return "Caja de música (Noche)";
								case 565:
									return "Caja de música (Título)";
								case 566:
									return "Caja de música (Subsuelo)";
								case 567:
									return "Caja de música (Jefe 1)";
								case 568:
									return "Caja de música (Selva)";
								case 569:
									return "Caja de música (Corrupción)";
								case 570:
									return "Caja de música (Corrupción en el Subsuelo)";
								case 571:
									return "Caja de música (La Bendición)";
								case 572:
									return "Caja de música (Jefe 2)";
								case 573:
									return "Caja de música (Bendición en el Subsuelo)";
								case 574:
									return "Caja de música (Jefe 3)";
								case 575:
									return "Alma de vuelo";
								case 576:
									return "Caja de música";
								case 577:
									return "Ladrillo endemoniado";
								case 578:
									return "Repetidor bendecido";
								case 579:
									return "Martitaladrahacha";
								case 580:
									return "Explosivos";
								case 581:
									return "Colector de entrada";
								case 582:
									return "Colector de salida";
								case 583:
									return "Temporizador de 1 segundo";
								case 584:
									return "Temporizador de 3 segundos";
								case 585:
									return "Temporizador de 5 segundos";
								case 586:
									return "Bloquear dulces de caña";
								case 587:
									return "Candy Cane pared";
								case 588:
									return "Gorro de Papá Noel";
								case 589:
									return "Santa Camisa";
								case 590:
									return "Pantalones de Santa";
								case 591:
									return "Caramelo verde de caña de bloques";
								case 592:
									return "Verde del bastón de caramelo pared";
								case 593:
									return "Bloque de nieve";
								case 594:
									return "nieve ladrillo";
								case 595:
									return "Snow Brick Wall";
								case 596:
									return "Nieve pared de ladrillo";
								case 597:
									return "azul claro";
								case 598:
									return "luz roja";
								case 599:
									return "Presente azul";
								case 600:
									return "Presente verde";
								case 601:
									return "Presente amarillo";
								case 602:
									return "Bola de Nieve";
								case 603:
									return "Zanahoria";
								}
							}
						}
					}
				}
			}
			if (!english && Lang.lang > 1)
			{
				return Lang.itemName(l, true);
			}
			return "";
		}
		public static string evilGood()
		{
			if (Lang.lang <= 1)
			{
				string text;
				if (WorldGen.tGood == 0)
				{
					text = string.Concat(new object[]
					{
						Main.worldName,
						" is ",
						WorldGen.tEvil,
						"% corrupt."
					});
				}
				else
				{
					if (WorldGen.tEvil == 0)
					{
						text = string.Concat(new object[]
						{
							Main.worldName,
							" is ",
							WorldGen.tGood,
							"% hallow."
						});
					}
					else
					{
						text = string.Concat(new object[]
						{
							Main.worldName,
							" is ",
							WorldGen.tGood,
							"% hallow, and ",
							WorldGen.tEvil,
							"% corrupt."
						});
					}
				}
				if (WorldGen.tGood > WorldGen.tEvil)
				{
					text += " Keep up the good work!";
				}
				else
				{
					if (WorldGen.tEvil > WorldGen.tGood && WorldGen.tEvil > 20)
					{
						text += " Things are grim indeed.";
					}
					else
					{
						text += " You should try harder.";
					}
				}
				return text;
			}
			if (Lang.lang == 2)
			{
				string text2;
				if (WorldGen.tGood == 0)
				{
					text2 = string.Concat(new object[]
					{
						Main.worldName,
						" ist zu ",
						WorldGen.tEvil,
						"% verderbt."
					});
				}
				else
				{
					if (WorldGen.tEvil == 0)
					{
						text2 = string.Concat(new object[]
						{
							Main.worldName,
							" ist zu ",
							WorldGen.tGood,
							"% gesegnet."
						});
					}
					else
					{
						text2 = string.Concat(new object[]
						{
							Main.worldName,
							" ist zu ",
							WorldGen.tGood,
							"% gesegnet und zu ",
							WorldGen.tEvil,
							"% verderbt."
						});
					}
				}
				if (WorldGen.tGood > WorldGen.tEvil)
				{
					text2 += " Gute Arbeit, weiter so!";
				}
				else
				{
					if (WorldGen.tEvil > WorldGen.tGood && WorldGen.tEvil > 20)
					{
						text2 += " Es steht nicht gut.";
					}
					else
					{
						text2 += " Streng dich mehr an!";
					}
				}
				return text2;
			}
			if (Lang.lang == 3)
			{
				string text3;
				if (WorldGen.tGood == 0)
				{
					text3 = string.Concat(new object[]
					{
						Main.worldName,
						" è distrutto al ",
						WorldGen.tEvil,
						"%."
					});
				}
				else
				{
					if (WorldGen.tEvil == 0)
					{
						text3 = string.Concat(new object[]
						{
							Main.worldName,
							" è santo al ",
							WorldGen.tGood,
							"%."
						});
					}
					else
					{
						text3 = string.Concat(new object[]
						{
							Main.worldName,
							" è santo al ",
							WorldGen.tGood,
							"% e distrutto al ",
							WorldGen.tEvil,
							"%."
						});
					}
				}
				if (WorldGen.tGood > WorldGen.tEvil)
				{
					text3 += " Continua così!";
				}
				else
				{
					if (WorldGen.tEvil > WorldGen.tGood && WorldGen.tEvil > 20)
					{
						text3 += " Le cose vanno male.";
					}
					else
					{
						text3 += " Dovresti impegnarti di più.";
					}
				}
				return text3;
			}
			if (Lang.lang == 4)
			{
				string text4;
				if (WorldGen.tGood == 0)
				{
					text4 = string.Concat(new object[]
					{
						Main.worldName,
						" est corrompu à ",
						WorldGen.tEvil,
						"%."
					});
				}
				else
				{
					if (WorldGen.tEvil == 0)
					{
						text4 = string.Concat(new object[]
						{
							Main.worldName,
							" est purifié à ",
							WorldGen.tGood,
							"%."
						});
					}
					else
					{
						text4 = string.Concat(new object[]
						{
							Main.worldName,
							" est purifié à ",
							WorldGen.tGood,
							"% et corrompu à ",
							WorldGen.tEvil,
							"%."
						});
					}
				}
				if (WorldGen.tGood > WorldGen.tEvil)
				{
					text4 += " Continuez comme ça.";
				}
				else
				{
					if (WorldGen.tEvil > WorldGen.tGood && WorldGen.tEvil > 20)
					{
						text4 += " En effet, c'est pas la joie.";
					}
					else
					{
						text4 += " Essayez encore.";
					}
				}
				return text4;
			}
			if (Lang.lang == 5)
			{
				string text5;
				if (WorldGen.tGood == 0)
				{
					text5 = string.Concat(new object[]
					{
						Main.worldName,
						" ha sido corrompido por ",
						WorldGen.tEvil,
						"%."
					});
				}
				else
				{
					if (WorldGen.tEvil == 0)
					{
						text5 = string.Concat(new object[]
						{
							Main.worldName,
							" ha sido bendecido por ",
							WorldGen.tGood,
							"%."
						});
					}
					else
					{
						text5 = string.Concat(new object[]
						{
							Main.worldName,
							" ha sido bendecido por ",
							WorldGen.tGood,
							"% y corrompido por ",
							WorldGen.tEvil,
							"%."
						});
					}
				}
				if (WorldGen.tGood > WorldGen.tEvil)
				{
					text5 += " ¡Sigue haciéndolo bien!";
				}
				else
				{
					if (WorldGen.tEvil > WorldGen.tGood && WorldGen.tEvil > 20)
					{
						text5 += " Es bastante desalentador.";
					}
					else
					{
						text5 += " Deberías esforzarte más.";
					}
				}
				return text5;
			}
			return "";
		}
		public static string title()
		{
			int num = Main.rand.Next(16);
			if (Lang.lang <= 1)
			{
				num = Main.rand.Next(50);
				if (num == 0)
				{
					return "Terraria: Dig Peon, Dig!";
				}
				if (num == 1)
				{
					return "Terraria: Epic Dirt";
				}
				if (num == 2)
				{
					return "Terraria: Hey Guys!";
				}
				if (num == 3)
				{
					return "Terraria: Sand is Overpowered";
				}
				if (num == 4)
				{
					return "Terraria Part 3: The Return of the Guide";
				}
				if (num == 5)
				{
					return "Terraria: A Bunnies Tale";
				}
				if (num == 6)
				{
					return "Terraria: Dr. Bones and The Temple of Blood Moon";
				}
				if (num == 7)
				{
					return "Terraria: Slimeassic Park";
				}
				if (num == 8)
				{
					return "Terraria: The Grass is Greener on This Side";
				}
				if (num == 9)
				{
					return "Terraria: Small Blocks, Not for Children Under the Age of 5";
				}
				if (num == 10)
				{
					return "Terraria: Digger T' Blocks";
				}
				if (num == 11)
				{
					return "Terraria: There is No Cow Layer";
				}
				if (num == 12)
				{
					return "Terraria: Suspicous Looking Eyeballs";
				}
				if (num == 13)
				{
					return "Terraria: Purple Grass!";
				}
				if (num == 14)
				{
					return "Terraria: Noone Dug Behind!";
				}
				if (num == 15)
				{
					return "Terraria: The Water Fall Of Content!";
				}
				if (num == 16)
				{
					return "Terraria: Earthbound";
				}
				if (num == 17)
				{
					return "Terraria: Dig Dug Ain't Got Nuthin on Me";
				}
				if (num == 18)
				{
					return "Terraria: Ore's Well That Ends Well";
				}
				if (num == 19)
				{
					return "Terraria: Judgement Clay";
				}
				if (num == 20)
				{
					return "Terraria: Terrestrial Trouble";
				}
				if (num == 21)
				{
					return "Terraria: Obsessive-Compulsive Discovery Simulator";
				}
				if (num == 22)
				{
					return "Terraria: Red Dev Redemption";
				}
				if (num == 23)
				{
					return "Terraria: Rise of the Slimes";
				}
				if (num == 24)
				{
					return "Terraria: Now with more things to kill you!";
				}
				if (num == 25)
				{
					return "Terraria: Rumors of the Guides' death were greatly exaggerated";
				}
				if (num == 26)
				{
					return "Terraria: I Pity the Tools...";
				}
				if (num == 27)
				{
					return "Terraria: A spelunker says 'What'?";
				}
				if (num == 28)
				{
					return "Terraria: So then I said 'Something about a PC update....'";
				}
				if (num == 29)
				{
					return "Terraria: May the blocks be with you";
				}
				if (num == 30)
				{
					return "Terraria: Better than life";
				}
				if (num == 31)
				{
					return "Terraria: Terraria: Terraria:";
				}
				if (num == 32)
				{
					return "Terraria: Now in 1D";
				}
				if (num == 33)
				{
					return "Terraria: Coming soon to a computer near you";
				}
				if (num == 34)
				{
					return "Terraria: Dividing by zero";
				}
				if (num == 35)
				{
					return "Terraria: Now with SOUND";
				}
				if (num == 36)
				{
					return "Terraria: Press alt-f4";
				}
				if (num == 37)
				{
					return "Terraria: I Pity the Tools";
				}
				if (num == 38)
				{
					return "Terraria: You sand bro?";
				}
				if (num == 39)
				{
					return "Terraria: A good day to dig hard";
				}
				if (num == 40)
				{
					return "Terraria: Can You Re-Dig-It?";
				}
				if (num == 41)
				{
					return "Terraria: I don't know that-- aaaaa!";
				}
				if (num == 42)
				{
					return "Terraria: What's that purple spiked thing?";
				}
				if (num == 43)
				{
					return "Terraria: I wanna be the guide";
				}
				if (num == 44)
				{
					return "Terraria: Cthulhu is mad... and is missing an eye!";
				}
				if (num == 45)
				{
					return "Terraria: NOT THE BEES!!!";
				}
				if (num == 46)
				{
					return "Terraria: Legend of Maxx";
				}
				if (num == 47)
				{
					return "Terraria: Cult of Cenx";
				}
				if (num == 48)
				{
					return "Terraria 2: Electric Boogaloo";
				}
				return "Terraria: Shut Up and Dig Gaiden!";
			}
			else
			{
				if (Lang.lang == 2)
				{
					if (num == 0)
					{
						return "Terraria: Nun grab schon, Bauer, grab!";
					}
					if (num == 1)
					{
						return "Terraria: Epischer Dreck";
					}
					if (num == 2)
					{
						return "Terraria: Huhu, Leute!";
					}
					if (num == 3)
					{
						return "Terraria: Sand is overpowered!";
					}
					if (num == 4)
					{
						return "Terraria Teil 3: Die Rueckkehr des Fremdenfuehrers";
					}
					if (num == 5)
					{
						return "Terraria: Geschichte eines verderbten Haeschens";
					}
					if (num == 6)
					{
						return "Terraria: Dr. Bones und der Tempel des Blutmondes";
					}
					if (num == 7)
					{
						return "Terraria: Schleimassic Park";
					}
					if (num == 8)
					{
						return "Terraria: Das Gras ist auf dieser Seite gruener";
					}
					if (num == 9)
					{
						return "Terraria: Kleine Bloecke, nicht fuer Kinder unter 5";
					}
					if (num == 10)
					{
						return "Terraria: Der Block des Ausgraebers";
					}
					if (num == 11)
					{
						return "Terraria: Hier gibt's auch kein Kuh-Level!";
					}
					if (num == 12)
					{
						return "Terraria: Verdaechtig ausschauende Augaepfel";
					}
					if (num == 13)
					{
						return "Terraria: Violettes Gras!";
					}
					if (num == 14)
					{
						return "Terraria: Houston, wir haben ein Problem gehabt!";
					}
					return "Terraria: Grab mit deiner Hand, nicht mit dem Mund!";
				}
				else
				{
					if (Lang.lang == 3)
					{
						if (num == 0)
						{
							return "Terraria: Scava contadino, scava!";
						}
						if (num == 1)
						{
							return "Terraria: Terra epica";
						}
						if (num == 2)
						{
							return "Terraria: Ehi, ragazzi!";
						}
						if (num == 3)
						{
							return "Terraria: La sabbia è strapotente";
						}
						if (num == 4)
						{
							return "Terraria: Il ritorno della guida";
						}
						if (num == 5)
						{
							return "Terraria: Coda di coniglio";
						}
						if (num == 6)
						{
							return "Terraria: Dottor Ossa e il tempio della luna di sangue";
						}
						if (num == 7)
						{
							return "Terraria: Slimeassic Park";
						}
						if (num == 8)
						{
							return "Terraria: L'erba è più verde da questo lato";
						}
						if (num == 9)
						{
							return "Terraria: Piccoli blocchi, non per bambini al di sotto di 5 anni";
						}
						if (num == 10)
						{
							return "Terraria:  Il blocco dello scavatore";
						}
						if (num == 11)
						{
							return "Terraria: No mucche, no party";
						}
						if (num == 12)
						{
							return "Terraria: Bulbi oculari diffidenti";
						}
						if (num == 13)
						{
							return "Terraria: Erba viola!";
						}
						if (num == 14)
						{
							return "Terraria: Houston, abbiamo un problema!";
						}
						return "Terraria: Zitto e scava, 'azzo!";
					}
					else
					{
						if (Lang.lang == 4)
						{
							if (num == 0)
							{
								return "Terraria : Creuse et fais pas cette mine !";
							}
							if (num == 1)
							{
								return "Terraria : Bain de boue";
							}
							if (num == 2)
							{
								return "Terraria : Salut la compagnie !";
							}
							if (num == 3)
							{
								return "Terraria : Le canon à sable, c'est vraiment grosbill";
							}
							if (num == 4)
							{
								return "Terraria, 3e partie : Le retour du guide";
							}
							if (num == 5)
							{
								return "Terraria : Des lapins pas si crétins";
							}
							if (num == 6)
							{
								return "Terraria : Dr Bones et le temple de la lune de sang";
							}
							if (num == 7)
							{
								return "Terraria: Slimeassic Park";
							}
							if (num == 8)
							{
								return "Terraria : L'herbe est plus verte dans le pré du voisin";
							}
							if (num == 9)
							{
								return "Terraria : Petits blocs interdits aux enfants de moins de 5 ans";
							}
							if (num == 10)
							{
								return "Terraria : Des mineurs gonflés à bloc ! ";
							}
							if (num == 11)
							{
								return "Terraria : Strates aux sphères";
							}
							if (num == 12)
							{
								return "Terraria : L'œil observateur suspicieux";
							}
							if (num == 13)
							{
								return "Terraria  : Silence, ça pousse !";
							}
							if (num == 14)
							{
								return "Terraria : Houston, nous avons un problème !";
							}
							return "Terraria : J'fais des trous, des p'tis trous...";
						}
						else
						{
							if (Lang.lang != 5)
							{
								return "";
							}
							if (num == 0)
							{
								return "Terraria: ¡Cava, peón, cava!";
							}
							if (num == 1)
							{
								return "Terraria: Terreno épico";
							}
							if (num == 2)
							{
								return "Terraria: ¡Hola, tíos!";
							}
							if (num == 3)
							{
								return "Terraria: El poder de la arena";
							}
							if (num == 4)
							{
								return "Terraria parte 3: El regreso del Guía";
							}
							if (num == 5)
							{
								return "Terraria: Un cuento de conejitos";
							}
							if (num == 6)
							{
								return "Terraria: El Dr. Látigo y el Templo de la Luna Sangrienta";
							}
							if (num == 7)
							{
								return "Terraria: Babosic Park";
							}
							if (num == 8)
							{
								return "Terraria: Mi césped es más verde que el del vecino";
							}
							if (num == 9)
							{
								return "Terraria: Bloques de construcción (no apto para menores de 5 años)";
							}
							if (num == 10)
							{
								return "Terraria: Buscador de bloques";
							}
							if (num == 11)
							{
								return "Terraria: Nada de niveles ocultos";
							}
							if (num == 12)
							{
								return "Terraria: Ojos de aspecto sospechoso";
							}
							if (num == 13)
							{
								return "Terraria: ¡Césped morado!";
							}
							if (num == 14)
							{
								return "Terraria: ¡No abandonamos ningún agujero!";
							}
							return "Terraria: ¡Cállate y cava un universo paralelo!";
						}
					}
				}
			}
		}
		public static void setLang(bool english = false)
		{
			Main.chTitle = true;
			if (Lang.lang <= 1 || english)
			{
				Lang.misc[0] = "A goblin army has been defeated!";
				Lang.misc[1] = "A goblin army is approaching from the west!";
				Lang.misc[2] = "A goblin army is approaching from the east!";
				Lang.misc[3] = "A goblin army has arrived!";
				Lang.misc[4] = "The Frost Legion has been defeated!";
				Lang.misc[5] = "The Frost Legion is approaching from the west!";
				Lang.misc[6] = "The Frost Legion is approaching from the east!";
				Lang.misc[7] = "The Frost Legion has arrived!";
				Lang.misc[8] = "The Blood Moon is rising...";
				Lang.misc[9] = "You feel an evil presence watching you...";
				Lang.misc[10] = "A horrible chill goes down your spine...";
				Lang.misc[11] = "Screams echo around you...";
				Lang.misc[12] = "Your world has been blessed with Cobalt!";
				Lang.misc[13] = "Your world has been blessed with Mythril!";
				Lang.misc[14] = "Your world has been blessed with Adamantite!";
				Lang.misc[15] = "The ancient spirits of light and dark have been released.";
				Lang.misc[16] = "has awoken!";
				Lang.misc[17] = "has been defeated!";
				Lang.misc[18] = "has arrived!";
				Lang.misc[19] = " was slain...";
				Lang.misc[20] = "A solar eclipse is happening!";
				Lang.misc[21] = "Your world has been blessed with Palladium!";
				Lang.misc[22] = "Your world has been blessed with Orichalcum!";
				Lang.misc[23] = "Your world has been blessed with Titanium!";
				Lang.misc[24] = "The pirates have been defeated!";
				Lang.misc[25] = "Pirates are approaching from the west!";
				Lang.misc[26] = "Pirates are approaching from the east!";
				Lang.misc[27] = "The pirates have arrived!";
				Lang.misc[28] = "You feel vibrations from deep below...";
				Lang.misc[29] = "This is going to be a terrible night...";
				Lang.misc[30] = "The air is getting colder around you...";
				Lang.menu[0] = "Start a new instance of Terraria to join!";
				Lang.menu[1] = "Running on port ";
				Lang.menu[2] = "Disconnect";
				Lang.menu[3] = "Server Requires Password:";
				Lang.menu[4] = "Accept";
				Lang.menu[5] = "Back";
				Lang.menu[6] = "Cancel";
				Lang.menu[7] = "Enter Server Password:";
				Lang.menu[8] = "Starting server...";
				Lang.menu[9] = "Load failed!";
				Lang.menu[10] = "Load Backup";
				Lang.menu[11] = "No backup found";
				Lang.menu[12] = "Single Player";
				Lang.menu[13] = "Multiplayer";
				Lang.menu[14] = "Settings";
				Lang.menu[15] = "Exit";
				Lang.menu[16] = "Create Character";
				Lang.menu[17] = "Delete";
				Lang.menu[18] = "Hair";
				Lang.menu[19] = "Eyes";
				Lang.menu[20] = "Skin";
				Lang.menu[21] = "Clothes";
				Lang.menu[22] = "Male";
				Lang.menu[23] = "Female";
				Lang.menu[24] = "Hardcore";
				Lang.menu[25] = "Mediumcore";
				Lang.menu[26] = "Softcore";
				Lang.menu[27] = "Random";
				Lang.menu[28] = "Create";
				Lang.menu[29] = "Hardcore characters die for good";
				Lang.menu[30] = "Mediumcore characters drop items on death";
				Lang.menu[31] = "Softcore characters drop money on death";
				Lang.menu[32] = "Select difficulty";
				Lang.menu[33] = "Shirt";
				Lang.menu[34] = "Undershirt";
				Lang.menu[35] = "Pants";
				Lang.menu[36] = "Shoes";
				Lang.menu[37] = "Hair";
				Lang.menu[38] = "Hair Color";
				Lang.menu[39] = "Eye Color";
				Lang.menu[40] = "Skin Color";
				Lang.menu[41] = "Shirt Color";
				Lang.menu[42] = "Undershirt Color";
				Lang.menu[43] = "Pants Color";
				Lang.menu[44] = "Shoe Color";
				Lang.menu[45] = "Enter Character Name:";
				Lang.menu[46] = "Delete";
				Lang.menu[47] = "Create World";
				Lang.menu[48] = "Enter World Name:";
				Lang.menu[49] = "Go Windowed";
				Lang.menu[50] = "Go Fullscreen";
				Lang.menu[51] = "Resolution";
				Lang.menu[52] = "Parallax";
				Lang.menu[53] = "Frame Skip Off (Not Recommended)";
				Lang.menu[54] = "Frame Skip On (Recommended)";
				Lang.menu[55] = "Lighting: Color";
				Lang.menu[56] = "Lighting: White";
				Lang.menu[57] = "Lighting: Retro";
				Lang.menu[58] = "Lighting: Trippy";
				Lang.menu[59] = "Quality: Auto";
				Lang.menu[60] = "Quality: High";
				Lang.menu[61] = "Quality: Medium";
				Lang.menu[62] = "Quality: Low";
				Lang.menu[63] = "Video";
				Lang.menu[64] = "Cursor Color";
				Lang.menu[65] = "Volume";
				Lang.menu[66] = "Controls";
				Lang.menu[67] = "Autosave On";
				Lang.menu[68] = "Autosave Off";
				Lang.menu[69] = "Autopause On";
				Lang.menu[70] = "Autopause Off";
				Lang.menu[71] = "Pickup Text On";
				Lang.menu[72] = "Pickup Text Off";
				Lang.menu[73] = "Fullscreen Resolution";
				Lang.menu[74] = "Up             ";
				Lang.menu[75] = "Down          ";
				Lang.menu[76] = "Left            ";
				Lang.menu[77] = "Right          ";
				Lang.menu[78] = "Jump          ";
				Lang.menu[79] = "Throw         ";
				Lang.menu[80] = "Inventory      ";
				Lang.menu[81] = "Quick Heal    ";
				Lang.menu[82] = "Quick Mana   ";
				Lang.menu[83] = "Quick Buff    ";
				Lang.menu[84] = "Grapple        ";
				Lang.menu[85] = "Auto Select    ";
				Lang.menu[86] = "Reset to Default";
				Lang.menu[87] = "Join";
				Lang.menu[88] = "Host & Play";
				Lang.menu[89] = "Enter Server IP Address:";
				Lang.menu[90] = "Enter Server Port:";
				Lang.menu[91] = "Choose world size:";
				Lang.menu[92] = "Small";
				Lang.menu[93] = "Medium";
				Lang.menu[94] = "Large";
				Lang.menu[95] = "Red:";
				Lang.menu[96] = "Green:";
				Lang.menu[97] = "Blue:";
				Lang.menu[98] = "Sound:";
				Lang.menu[99] = "Music:";
				Lang.menu[100] = "Background On";
				Lang.menu[101] = "Background Off";
				Lang.menu[102] = "Select language";
				Lang.menu[103] = "Language";
				Lang.menu[104] = "Yes";
				Lang.menu[105] = "No";
				Lang.menu[106] = "Toggle Map Style           ";
				Lang.menu[107] = "Toggle Fullscreen           ";
				Lang.menu[108] = "Zoom In                      ";
				Lang.menu[109] = "Zoom Out                    ";
				Lang.menu[110] = "Decrease Transparency     ";
				Lang.menu[111] = "Increase Transparency      ";
				Lang.menu[112] = "Map Enabled";
				Lang.menu[113] = "Map Disabled";
				Lang.gen[0] = "Generating world terrain:";
				Lang.gen[1] = "Adding sand...";
				Lang.gen[2] = "Generating hills...";
				Lang.gen[3] = "Puttin dirt behind dirt:";
				Lang.gen[4] = "Placing rocks in the dirt...";
				Lang.gen[5] = "Placing dirt in the rocks...";
				Lang.gen[6] = "Adding clay...";
				Lang.gen[7] = "Making random holes:";
				Lang.gen[8] = "Generating small caves:";
				Lang.gen[9] = "Generating large caves:";
				Lang.gen[10] = "Generating surface caves...";
				Lang.gen[11] = "Generating jungle:";
				Lang.gen[12] = "Generating floating islands...";
				Lang.gen[13] = "Adding mushroom patches...";
				Lang.gen[14] = "Placing mud in the dirt...";
				Lang.gen[15] = "Adding silt...";
				Lang.gen[16] = "Adding shinies...";
				Lang.gen[17] = "Adding webs...";
				Lang.gen[18] = "Creating underworld:";
				Lang.gen[19] = "Adding water bodies:";
				Lang.gen[20] = "Making the world evil:";
				Lang.gen[21] = "Generating mountain caves...";
				Lang.gen[22] = "Creating beaches...";
				Lang.gen[23] = "Adding gems...";
				Lang.gen[24] = "Gravitating sand:";
				Lang.gen[25] = "Cleaning up dirt backgrounds:";
				Lang.gen[26] = "Placing altars:";
				Lang.gen[27] = "Settling liquids:";
				Lang.gen[28] = "Placing life crystals:";
				Lang.gen[29] = "Placing statues:";
				Lang.gen[30] = "Hiding treasure:";
				Lang.gen[31] = "Hiding more treasure:";
				Lang.gen[32] = "Hiding jungle treasure:";
				Lang.gen[33] = "Hiding water treasure:";
				Lang.gen[34] = "Placing traps:";
				Lang.gen[35] = "Placing breakables:";
				Lang.gen[36] = "Placing hellforges:";
				Lang.gen[37] = "Spreading grass...";
				Lang.gen[38] = "Growing cacti...";
				Lang.gen[39] = "Planting sunflowers...";
				Lang.gen[40] = "Planting trees...";
				Lang.gen[41] = "Planting herbs...";
				Lang.gen[42] = "Planting weeds...";
				Lang.gen[43] = "Growing vines...";
				Lang.gen[44] = "Planting flowers...";
				Lang.gen[45] = "Planting mushrooms...";
				Lang.gen[46] = "Freeing unused resources:";
				Lang.gen[47] = "Resetting game objects:";
				Lang.gen[48] = "Setting hard mode...";
				Lang.gen[49] = "Saving world data:";
				Lang.gen[50] = "Backing up world file...";
				Lang.gen[51] = "Loading world data:";
				Lang.gen[52] = "Checking tile alignment:";
				Lang.gen[53] = "Load failed!";
				Lang.gen[54] = "No backup found.";
				Lang.gen[55] = "Finding tile frames:";
				Lang.gen[56] = "Adding snow...";
				Lang.gen[57] = "World";
				Lang.gen[58] = "Creating dungeon:";
				Lang.gen[59] = "A meteorite has landed!";
				Lang.gen[60] = "Smoothing the world:";
				Lang.gen[61] = "Mossification:";
				Lang.gen[62] = "Gemification:";
				Lang.gen[63] = "Making cave walls:";
				Lang.gen[64] = "Growing spider caves:";
				Lang.gen[65] = "Clearing map data:";
				Lang.gen[66] = "Saving map data:";
				Lang.gen[67] = "Loading map data:";
				Lang.gen[68] = "Drawing map:";
				Lang.gen[69] = "Creating waterfalls:";
				Lang.gen[70] = "Creating jungle ruins...";
				Lang.gen[71] = "Creating hornet nests...";
				Lang.gen[72] = "Making the world bloody:";
				Lang.inter[0] = "Life:";
				Lang.inter[1] = "Breath";
				Lang.inter[2] = "Mana";
				Lang.inter[3] = "Trash Can";
				Lang.inter[4] = "Inventory";
				Lang.inter[5] = "Hotbar unlocked";
				Lang.inter[6] = "Hotbar locked";
				Lang.inter[7] = "Housing";
				Lang.inter[8] = "Housing Query";
				Lang.inter[9] = "Accessories";
				Lang.inter[10] = "Defense";
				Lang.inter[11] = "Social";
				Lang.inter[12] = "Helmet";
				Lang.inter[13] = "Shirt";
				Lang.inter[14] = "Pants";
				Lang.inter[15] = "platinum";
				Lang.inter[16] = "gold";
				Lang.inter[17] = "silver";
				Lang.inter[18] = "copper";
				Lang.inter[19] = "Reforge";
				Lang.inter[20] = "Place an item here to reforge";
				Lang.inter[21] = "Showing recipes that use";
				Lang.inter[22] = "Required objects:";
				Lang.inter[23] = "None";
				Lang.inter[24] = "Place a material here";
				Lang.inter[25] = "Crafting";
				Lang.inter[26] = "Coins";
				Lang.inter[27] = "Ammo";
				Lang.inter[28] = "Shop";
				Lang.inter[29] = "Loot All";
				Lang.inter[30] = "Deposit All";
				Lang.inter[31] = "Quick Stack";
				Lang.inter[32] = "Piggy Bank";
				Lang.inter[33] = "Safe";
				Lang.inter[34] = "Time:";
				Lang.inter[35] = "Save & Exit";
				Lang.inter[36] = "Disconnect";
				Lang.inter[37] = "Items";
				Lang.inter[38] = "You were slain...";
				Lang.inter[39] = "This housing is suitable.";
				Lang.inter[40] = "This is not valid housing.";
				Lang.inter[41] = "This housing is already occupied.";
				Lang.inter[42] = "This housing is corrupted.";
				Lang.inter[43] = "Connection timed out";
				Lang.inter[44] = "Receiving tile data";
				Lang.inter[45] = "Equip";
				Lang.inter[46] = "Cost";
				Lang.inter[47] = "Save";
				Lang.inter[48] = "Edit";
				Lang.inter[49] = "Status";
				Lang.inter[50] = "Curse";
				Lang.inter[51] = "Help";
				Lang.inter[52] = "Close";
				Lang.inter[53] = "Water";
				Lang.inter[54] = "Heal";
				Lang.inter[55] = "This housing does not meet the requirements for a";
				Lang.inter[56] = "Lava";
				Lang.inter[57] = "Dye";
				Lang.inter[58] = "Honey";
				Lang.tip[0] = "Equipped in social slot";
				Lang.tip[1] = "No stats will be gained";
				Lang.tip[2] = " melee damage";
				Lang.tip[3] = " ranged damage";
				Lang.tip[4] = " magic damage";
				Lang.tip[5] = "% critical strike chance";
				Lang.tip[6] = "Insanely fast speed";
				Lang.tip[7] = "Very fast speed";
				Lang.tip[8] = "Fast speed";
				Lang.tip[9] = "Average speed";
				Lang.tip[10] = "Slow speed";
				Lang.tip[11] = "Very slow speed";
				Lang.tip[12] = "Extremely slow speed";
				Lang.tip[13] = "Snail speed";
				Lang.tip[14] = "No knockback";
				Lang.tip[15] = "Extremely weak knockback";
				Lang.tip[16] = "Very weak knockback";
				Lang.tip[17] = "Weak knockback";
				Lang.tip[18] = "Average knockback";
				Lang.tip[19] = "Strong knockback";
				Lang.tip[20] = "Very strong knockback";
				Lang.tip[21] = "Extremely strong knockback";
				Lang.tip[22] = "Insane knockback";
				Lang.tip[23] = "Equipable";
				Lang.tip[24] = "Vanity Item";
				Lang.tip[25] = " defense";
				Lang.tip[26] = "% pickaxe power";
				Lang.tip[27] = "% axe power";
				Lang.tip[28] = "% hammer power";
				Lang.tip[29] = "Restores";
				Lang.tip[30] = "life";
				Lang.tip[31] = "mana";
				Lang.tip[32] = "Uses";
				Lang.tip[33] = "Can be placed";
				Lang.tip[34] = "Ammo";
				Lang.tip[35] = "Consumable";
				Lang.tip[36] = "Material";
				Lang.tip[37] = " minute duration";
				Lang.tip[38] = " second duration";
				Lang.tip[39] = "% damage";
				Lang.tip[40] = "% speed";
				Lang.tip[41] = "% critical strike chance";
				Lang.tip[42] = "% mana cost";
				Lang.tip[43] = "% size";
				Lang.tip[44] = "% velocity";
				Lang.tip[45] = "% knockback";
				Lang.tip[46] = "% movement speed";
				Lang.tip[47] = "% melee speed";
				Lang.tip[48] = "Set bonus:";
				Lang.tip[49] = "Sell price:";
				Lang.tip[50] = "Buy price:";
				Lang.tip[51] = "No value";
				Lang.tip[52] = "Consumes ";
				Lang.tip[53] = " summon damage";
				Lang.tip[54] = " range";
				Lang.tip[55] = " damage";
				Lang.mp[0] = "Recieve:";
				Lang.mp[1] = "Incorrect password.";
				Lang.mp[2] = "Invalid operation at this state.";
				Lang.mp[3] = "You are banned from this server.";
				Lang.mp[4] = "You are not using the same version as this server.";
				Lang.mp[5] = "is already on this server.";
				Lang.mp[6] = "/playing";
				Lang.mp[7] = "Current players:";
				Lang.mp[8] = "/roll";
				Lang.mp[9] = "rolls a";
				Lang.mp[10] = "You are not in a party!";
				Lang.mp[11] = "has enabled PvP!";
				Lang.mp[12] = "has disabled PvP!";
				Lang.mp[13] = "is no longer on a party.";
				Lang.mp[14] = "has joined the red party.";
				Lang.mp[15] = "has joined the green party.";
				Lang.mp[16] = "has joined the blue party.";
				Lang.mp[17] = "has joined the yellow party.";
				Lang.mp[18] = "Welcome to";
				Lang.mp[19] = "has joined.";
				Lang.mp[20] = "has left.";
				Lang.mp[21] = "/players";
				Lang.the = "the ";
				Lang.dt[0] = "couldn't find the antidote";
				Lang.dt[1] = "couldn't put the fire out";
				Lang.dt[2] = "couldn't breathe";
				Main.buffName[1] = "Obsidian Skin";
				Main.buffTip[1] = "Immune to lava";
				Main.buffName[2] = "Regeneration";
				Main.buffTip[2] = "Provides life regeneration";
				Main.buffName[3] = "Swiftness";
				Main.buffTip[3] = "25% increased movement speed";
				Main.buffName[4] = "Gills";
				Main.buffTip[4] = "Breathe water instead of air";
				Main.buffName[5] = "Ironskin";
				Main.buffTip[5] = "Increase defense by 8";
				Main.buffName[6] = "Mana Regeneration";
				Main.buffTip[6] = "Increased mana regeneration";
				Main.buffName[7] = "Magic Power";
				Main.buffTip[7] = "20% increased magic damage";
				Main.buffName[8] = "Featherfall";
				Main.buffTip[8] = "Press UP or DOWN to control speed of descent";
				Main.buffName[9] = "Spelunker";
				Main.buffTip[9] = "Shows the location of treasure and ore";
				Main.buffName[10] = "Invisibility";
				Main.buffTip[10] = "Grants invisibility";
				Main.buffName[11] = "Shine";
				Main.buffTip[11] = "Emitting light";
				Main.buffName[12] = "Night Owl";
				Main.buffTip[12] = "Increased night vision";
				Main.buffName[13] = "Battle";
				Main.buffTip[13] = "Increased enemy spawn rate";
				Main.buffName[14] = "Thorns";
				Main.buffTip[14] = "Attackers also take damage";
				Main.buffName[15] = "Water Walking";
				Main.buffTip[15] = "Press DOWN to enter water";
				Main.buffName[16] = "Archery";
				Main.buffTip[16] = "20% increased arrow damage and speed";
				Main.buffName[17] = "Hunter";
				Main.buffTip[17] = "Shows the location of enemies";
				Main.buffName[18] = "Gravitation";
				Main.buffTip[18] = "Press UP to reverse gravity";
				Main.buffName[19] = "Shadow Orb";
				Main.buffTip[19] = "A magical orb that provides light";
				Main.buffName[20] = "Poisoned";
				Main.buffTip[20] = "Slowly losing life";
				Main.buffName[21] = "Potion Sickness";
				Main.buffTip[21] = "Cannot consume anymore healing items";
				Main.buffName[22] = "Darkness";
				Main.buffTip[22] = "Decreased light vision";
				Main.buffName[23] = "Cursed";
				Main.buffTip[23] = "Cannot use any items";
				Main.buffName[24] = "On Fire!";
				Main.buffTip[24] = "Slowly losing life";
				Main.buffName[25] = "Tipsy";
				Main.buffTip[25] = "Increased melee abilities, lowered defense";
				Main.buffName[26] = "Well Fed";
				Main.buffTip[26] = "Minor improvements to all stats";
				Main.buffName[27] = "Fairy";
				Main.buffTip[27] = "A fairy is following you";
				Main.buffName[28] = "Werewolf";
				Main.buffTip[28] = "Physical abilities are increased";
				Main.buffName[29] = "Clairvoyance";
				Main.buffTip[29] = "Magic powers are increased";
				Main.buffName[30] = "Bleeding";
				Main.buffTip[30] = "Cannot regenerate life";
				Main.buffName[31] = "Confused";
				Main.buffTip[31] = "Movement is reversed";
				Main.buffName[32] = "Slow";
				Main.buffTip[32] = "Movement speed is reduced";
				Main.buffName[33] = "Weak";
				Main.buffTip[33] = "Physical abilities are decreased";
				Main.buffName[34] = "Merfolk";
				Main.buffTip[34] = "Can breathe and move easily underwater";
				Main.buffName[35] = "Silenced";
				Main.buffTip[35] = "Cannot use items that require mana";
				Main.buffName[36] = "Broken Armor";
				Main.buffTip[36] = "Defense is cut in half";
				Main.buffName[37] = "Horrified";
				Main.buffTip[37] = "You have seen something nasty, there is no escape.";
				Main.buffName[38] = "The Tongue";
				Main.buffTip[38] = "You are being sucked into the mouth";
				Main.buffName[39] = "Cursed Inferno";
				Main.buffTip[39] = "Losing life";
				Main.buffName[40] = "Pet Bunny";
				Main.buffTip[40] = "I think it wants your carrot";
				Main.buffName[41] = "Baby Penguin";
				Main.buffTip[41] = "I think it wants your fish";
				Main.buffName[42] = "Pet Turtle";
				Main.buffTip[42] = "Happy turtle time!";
				Main.buffName[43] = "Paladin's Shield";
				Main.buffTip[43] = "25% of damage taken will be redirected to another player";
				Main.buffName[44] = "Frostburn";
				Main.buffTip[44] = "It's either really hot or really cold. Either way it REALLY hurts";
				Main.buffName[45] = "Baby Eater";
				Main.buffTip[45] = "A baby Eater of Souls is following you";
				Main.buffName[46] = "Chilled";
				Main.buffTip[46] = "Your movement speed has been reduced";
				Main.buffName[47] = "Frozen";
				Main.buffTip[47] = "You can't move!";
				Main.buffName[48] = "Honey";
				Main.buffTip[48] = "Life regeneration is increased";
				Main.buffName[49] = "Pygmies";
				Main.buffTip[49] = "The pygmies will fight for you";
				Main.buffName[50] = "Baby Skeletron Head";
				Main.buffTip[50] = "Don't even ask...";
				Main.buffName[51] = "Baby Hornet";
				Main.buffTip[51] = "It thinks you are its mother";
				Main.buffName[52] = "Tiki Spirit";
				Main.buffTip[52] = "A friendly spirit is following you";
				Main.buffName[53] = "Pet Lizard";
				Main.buffTip[53] = "Chillin' like a reptilian";
				Main.buffName[54] = "Pet Parrot";
				Main.buffTip[54] = "Polly want's the cracker";
				Main.buffName[55] = "Baby Truffle";
				Main.buffTip[55] = "Isn't this just soooo cute?";
				Main.buffName[56] = "Pet Sapling";
				Main.buffTip[56] = "A little sapling is following you";
				Main.buffName[57] = "Wisp";
				Main.buffTip[57] = "A wisp is following you";
				Main.buffName[58] = "Rapid Healing";
				Main.buffTip[58] = "Life regeneration is greatly increased";
				Main.buffName[59] = "Shadow Dodge";
				Main.buffTip[59] = "You will dodge the next attack";
				Main.buffName[60] = "Leaf Crystal";
				Main.buffTip[60] = "Shoots crystal leaves at nearby enemies";
				Main.buffName[61] = "Baby Dinosaur";
				Main.buffTip[61] = "A baby dinosaur is following you";
				Main.buffName[62] = "Ice Barrier";
				Main.buffTip[62] = "Defense is increased by 30";
				Main.buffName[63] = "Panic!";
				Main.buffTip[63] = "Movement speed is increased";
				Main.buffName[64] = "Baby Slime";
				Main.buffTip[64] = "The baby slime will fight for you";
				Main.buffName[65] = "Eyeball Spring";
				Main.buffTip[65] = "An eyeball spring is following you";
				Main.buffName[66] = "Baby Snowman";
				Main.buffTip[66] = "A baby snowman is following you";
				Main.buffName[67] = "Burning";
				Main.buffTip[67] = "Losing life and slowed movement";
				Main.buffName[68] = "Suffocation";
				Main.buffTip[68] = "Losing life";
				Main.buffName[69] = "Ichor";
				Main.buffTip[69] = "Reduced defense";
				Main.buffName[70] = "Venom";
				Main.buffTip[70] = "Losing life";
				Main.buffName[72] = "Midas";
				Main.buffTip[72] = "Drop more money on death";
				Main.buffName[80] = "Blackout";
				Main.buffTip[80] = "Light vision severely reduced";
				Main.buffName[71] = "Weapon Imbue: Venom";
				Main.buffTip[71] = "Melee attacks inflict venom on your targets";
				Main.buffName[73] = "Weapon Imbue: Cursed Flames";
				Main.buffTip[73] = "Melee attacks inflict enemies with cursed flames";
				Main.buffName[74] = "Weapon Imbue: Fire";
				Main.buffTip[74] = "Melee attacks set enemies on fire";
				Main.buffName[75] = "Weapon Imbue: Gold";
				Main.buffTip[75] = "Melee attacks make enemies drop more gold";
				Main.buffName[76] = "Weapon Imbue: Ichor";
				Main.buffTip[76] = "Melee attacks decrease enemies defense";
				Main.buffName[77] = "Weapon Imbue: Nanites";
				Main.buffTip[77] = "Melee attacks confuse enemies";
				Main.buffName[78] = "Weapon Imbue: Confetti";
				Main.buffTip[78] = "Melee attacks cause confetti to appear";
				Main.buffName[79] = "Weapon Imbue: Poison";
				Main.buffTip[79] = "Melee attacks poison enemies";
				Main.tileName[4] = "Torch";
				Main.tileName[5] = "Tree";
				Main.tileName[6] = "Iron";
				Main.tileName[7] = "Copper";
				Main.tileName[8] = "Gold";
				Main.tileName[9] = "Silver";
				Main.tileName[10] = "Door";
				Main.tileName[11] = "Door";
				Main.tileName[12] = "Heart Crystal";
				Main.tileName[13] = "Bottle";
				Main.tileName[14] = "Table";
				Main.tileName[15] = "Chair";
				Main.tileName[16] = "Anvil";
				Main.tileName[17] = "Furnace";
				Main.tileName[18] = "Work Bench";
				Main.tileName[21] = "Chest";
				Main.tileName[22] = "Demonite";
				Main.tileName[26] = "Demon Altar";
				Main.tileName[27] = "Sunflower";
				Main.tileName[28] = "Pot";
				Main.tileName[29] = "Piggy Bank";
				Main.tileName[31] = "Shadow Orb";
				Main.tileName[32] = "Thorns";
				Main.tileName[33] = "Candle";
				Main.tileName[34] = "Copper Chandelier";
				Main.tileName[35] = "Silver Chandelier";
				Main.tileName[36] = "Gold Chandelier";
				Main.tileName[42] = "Lantern";
				Main.tileName[48] = "Spike";
				Main.tileName[49] = "Water Candle";
				Main.tileName[50] = "Book";
				Main.tileName[51] = "Web";
				Main.tileName[55] = "Sign";
				Main.tileName[63] = "Sapphire";
				Main.tileName[64] = "Ruby";
				Main.tileName[65] = "Emerald";
				Main.tileName[66] = "Topaz";
				Main.tileName[67] = "Amethyst";
				Main.tileName[68] = "Diamond";
				Main.tileName[69] = "Thorn";
				Main.tileName[72] = "Giant Mushroom";
				Main.tileName[77] = "Hellforge";
				Main.tileName[78] = "Clay Pot";
				Main.tileName[79] = "Bed";
				Main.tileName[80] = "Cactus";
				Main.tileName[81] = "Coral";
				Main.tileName[85] = "Tombstone";
				Main.tileName[86] = "Loom";
				Main.tileName[87] = "Piano";
				Main.tileName[88] = "Dresser";
				Main.tileName[89] = "Bench";
				Main.tileName[90] = "Bathtub";
				Main.tileName[91] = "Banner";
				Main.tileName[92] = "Lamp Post";
				Main.tileName[93] = "Tiki Torch";
				Main.tileName[94] = "Keg";
				Main.tileName[95] = "Chinese Lantern";
				Main.tileName[96] = "Cooking Pot";
				Main.tileName[97] = "Safe";
				Main.tileName[98] = "Skull Lantern";
				Main.tileName[100] = "Candelabra";
				Main.tileName[101] = "Bookcase";
				Main.tileName[102] = "Throne";
				Main.tileName[103] = "Bowl";
				Main.tileName[104] = "Grandfather Clock";
				Main.tileName[105] = "Statue";
				Main.tileName[106] = "Sawmill";
				Main.tileName[107] = "Cobalt";
				Main.tileName[108] = "Mythril";
				Main.tileName[111] = "Adamantite";
				Main.tileName[114] = "Tinkerer's Workshop";
				Main.tileName[125] = "Crystal Ball";
				Main.tileName[128] = "Mannequin";
				Main.tileName[129] = "Crystal Shard";
				Main.tileName[132] = "Lever";
				Main.tileName[133] = "Adamantite or Titanium Forge";
				Main.tileName[134] = "Mythril or Orichalcum Anvil";
				Main.tileName[136] = "Switch";
				Main.tileName[137] = "Trap";
				Main.tileName[138] = "Boulder";
				Main.tileName[139] = "Music Box";
				Main.tileName[142] = "Inlet Pump";
				Main.tileName[143] = "Outlet Pump";
				Main.tileName[144] = "Timer";
				Main.tileName[149] = "Christmas Light";
				Main.tileName[166] = "Tin";
				Main.tileName[167] = "Lead";
				Main.tileName[168] = "Tungsten";
				Main.tileName[169] = "Platinum";
				Main.tileName[170] = "Tin Chandelier";
				Main.tileName[171] = "Tungsten Chandelier";
				Main.tileName[172] = "Platinum Chandelier";
				Main.tileName[173] = "Candelabra";
				Main.tileName[174] = "Platinum Candle";
				Main.tileName[191] = "Living Wood";
				Main.tileName[207] = "Crimtane";
				Main.tileName[207] = "Water Fountain";
				Main.tileName[209] = "Cannon";
				Main.tileName[211] = "Chlorophyte";
				Main.tileName[212] = "Turret";
				Main.tileName[213] = "Rope";
				Main.tileName[214] = "Chain";
				Main.tileName[215] = "Campfire";
				Main.tileName[216] = "Rocket";
				Main.tileName[217] = "Blend-O-Matic";
				Main.tileName[218] = "Meat Grinder";
				Main.tileName[219] = "Silt Extractinator";
				Main.tileName[220] = "Solidifier";
				Main.tileName[221] = "Palladium";
				Main.tileName[222] = "Orichalcum";
				Main.tileName[223] = "Titanium";
				Main.tileName[228] = "Dye Vat";
				Main.tileName[231] = "Larva";
				Main.tileName[232] = "Wooden Spike";
				Main.tileName[235] = "Teleporter";
				Main.tileName[236] = "Life Fruit";
				Main.tileName[237] = "Lihzahrd Altar";
				Main.tileName[238] = "Plantera's Bulb";
				Main.tileName[239] = "Metal Bar";
				Main.tileName[240] = "Picture";
				Main.tileName[241] = "Picture";
				Main.tileName[242] = "Picture";
				Main.tileName[243] = "Imbuing Station";
				Main.tileName[244] = "Bubble Machine";
				Main.tileName[245] = "Picture";
				Main.tileName[246] = "Picture";
				Main.tileName[247] = "Autohammer";
			}
			else
			{
				if (Lang.lang == 2)
				{
					Lang.misc[0] = "Die Goblin-Armee wurde besiegt!";
					Lang.misc[1] = "Eine Goblin-Armee naehert sich von Westen!";
					Lang.misc[2] = "Eine Goblin-Armee naehert sich von Osten!";
					Lang.misc[3] = "Ein Goblin-Armee ist da!";
					Lang.misc[4] = "Der Frost Legion wurde besiegt!";
					Lang.misc[5] = "Der Frost ist Legion aus dem Westen näher!";
					Lang.misc[6] = "Der Frost ist Legion aus dem Osten näher!";
					Lang.misc[7] = "Der Frost Legion ist da!";
					Lang.misc[8] = "Der Blutmond steigt auf ...";
					Lang.misc[9] = "Du fuehlst dich von einer boesen Kraft beobachtet ...";
					Lang.misc[10] = "Eine Eiseskaelte steigt in dir hoch ...";
					Lang.misc[11] = "Du hoerst das Echo von Schreien um dich herum ...";
					Lang.misc[12] = "Deine Welt wurde mit Kobalt gesegnet!";
					Lang.misc[13] = "Deine Welt wurde mit Mithril gesegnet!";
					Lang.misc[14] = "Deine Welt wurde mit Adamantit gesegnet!";
					Lang.misc[15] = "Die uralten Geister des Lichts und der Finsternis wurden frei gelassen.";
					Lang.misc[16] = "ist aufgewacht!";
					Lang.misc[17] = "wurde besiegt!";
					Lang.misc[18] = "ist eingetroffen!";
					Lang.misc[19] = " wurde durch...";
					Lang.misc[20] = "Eine Sonnenfinsternis ist passiert!";
					Lang.misc[21] = "Ihre Welt ist mit Palladium gesegnet worden!";
					Lang.misc[22] = "Ihre Welt hat mit Orichalcum gesegnet worden!";
					Lang.misc[23] = "Ihre Welt hat sich mit Titanium gesegnet worden!";
					Lang.misc[24] = "Die Piraten wurden besiegt!";
					Lang.misc[25] = "Piraten sind aus dem Westen näher!";
					Lang.misc[26] = "Piraten sind aus dem Osten näher!";
					Lang.misc[27] = "Die Piraten sind angekommen!";
					Lang.misc[28] = "Sie fühlen sich Schwingungen von tief unter ...";
					Lang.misc[29] = "Das wird eine schreckliche Nacht sein ...";
					Lang.misc[30] = "Die Luft wird kälter um dich herum ...";
					Lang.menu[0] = "Beginne eine neue Sitzung auf Terraria!";
					Lang.menu[1] = "Laeuft auf Port ";
					Lang.menu[2] = "Trennen";
					Lang.menu[3] = "Server benoetigt Passwort:";
					Lang.menu[4] = "Akzeptieren";
					Lang.menu[5] = "Zurueck";
					Lang.menu[6] = "Abbrechen";
					Lang.menu[7] = "Server-Passwort eingeben:";
					Lang.menu[8] = "Server startet...";
					Lang.menu[9] = "Laden fehlgeschlagen!";
					Lang.menu[10] = "Backup laden";
					Lang.menu[11] = "Kein Backup gefunden";
					Lang.menu[12] = "Einzelspieler";
					Lang.menu[13] = "Mehrspieler";
					Lang.menu[14] = "Einstellungen";
					Lang.menu[15] = "Beenden";
					Lang.menu[16] = "Charakter erstellen";
					Lang.menu[17] = "Loeschen";
					Lang.menu[18] = "Haar";
					Lang.menu[19] = "Augen";
					Lang.menu[20] = "Haut";
					Lang.menu[21] = "Kleidung";
					Lang.menu[22] = "Maennlich";
					Lang.menu[23] = "Weiblich";
					Lang.menu[24] = "Hardcore";
					Lang.menu[25] = "Mediumcore";
					Lang.menu[26] = "Softcore";
					Lang.menu[27] = "Zufaellig";
					Lang.menu[28] = "Erstellen";
					Lang.menu[29] = "Hardcore-Charaktere sterben fuers Gute";
					Lang.menu[30] = "Mediumcore-Charaktere lassen im Tod Items fallen";
					Lang.menu[31] = "Softcore-Charaktere lassen im Tod Geld fallen";
					Lang.menu[32] = "Schwierigkeitsgrad waehlen";
					Lang.menu[33] = "Hemd";
					Lang.menu[34] = "Unterhemd";
					Lang.menu[35] = "Hose";
					Lang.menu[36] = "Schuhe";
					Lang.menu[37] = "Haar";
					Lang.menu[38] = "Haarfarbe";
					Lang.menu[39] = "Augenfarbe";
					Lang.menu[40] = "Hautfarbe";
					Lang.menu[41] = "Hemdfarbe";
					Lang.menu[42] = "Unterhemdfarbe";
					Lang.menu[43] = "Hosenfarbe";
					Lang.menu[44] = "Schuhfarbe";
					Lang.menu[45] = "Charaktername eingeben:";
					Lang.menu[46] = "Loeschen";
					Lang.menu[47] = "Welt erschaffen";
					Lang.menu[48] = "Weltnamen eingeben:";
					Lang.menu[49] = "Zum Fenstermodus";
					Lang.menu[50] = "Zum Vollbildschirm";
					Lang.menu[51] = "Aufloesung";
					Lang.menu[52] = "Parallaxe";
					Lang.menu[53] = "Frameskip aus (nicht empfohlen)";
					Lang.menu[54] = "Frameskip an (empfohlen)";
					Lang.menu[55] = "Beleuchtung: Farbe";
					Lang.menu[56] = "Beleuchtung: Weiss";
					Lang.menu[57] = "Beleuchtung: Retro";
					Lang.menu[58] = "Beleuchtung: Flippig";
					Lang.menu[59] = "Qualitaet: Auto";
					Lang.menu[60] = "Qualitaet: Hoch";
					Lang.menu[61] = "Qualitaet: Mittel";
					Lang.menu[62] = "Qualitaet: Niedrig";
					Lang.menu[63] = "Video";
					Lang.menu[64] = "Zeigerfarbe";
					Lang.menu[65] = "Lautstaerke";
					Lang.menu[66] = "Steuerung";
					Lang.menu[67] = "Automat. sichern an";
					Lang.menu[68] = "Automat. sichern aus";
					Lang.menu[69] = "Automat. Pause an";
					Lang.menu[70] = "Automat. Pause aus";
					Lang.menu[71] = "Pickup-Text an";
					Lang.menu[72] = "Pickup-Text aus";
					Lang.menu[73] = "Vollbildschirm-Aufloesung";
					Lang.menu[74] = "Hoch                 ";
					Lang.menu[75] = "Hinunter             ";
					Lang.menu[76] = "Links                 ";
					Lang.menu[77] = "Rechts                ";
					Lang.menu[78] = "Springen             ";
					Lang.menu[79] = "Werfen               ";
					Lang.menu[80] = "Inventar              ";
					Lang.menu[81] = "Schnellheilung       ";
					Lang.menu[82] = "Schnelles Mana     ";
					Lang.menu[83] = "Schneller Buff       ";
					Lang.menu[84] = "Entern                ";
					Lang.menu[85] = "Automat. Auswahl    ";
					Lang.menu[86] = "Auf Standard zuruecksetzen";
					Lang.menu[87] = "Mitmachen";
					Lang.menu[88] = "Hosten & Spielen";
					Lang.menu[89] = "Server-IP-Adresse eingeben:";
					Lang.menu[90] = "Server-Port eingeben:";
					Lang.menu[91] = "Weltgroesse waehlen:";
					Lang.menu[92] = "Klein";
					Lang.menu[93] = "Mittel";
					Lang.menu[94] = "Gross";
					Lang.menu[95] = "Rot:";
					Lang.menu[96] = "Gruen:";
					Lang.menu[97] = "Blau:";
					Lang.menu[98] = "Sound:";
					Lang.menu[99] = "Musik:";
					Lang.menu[100] = "Hintergrund On";
					Lang.menu[101] = "Hintergrund Off";
					Lang.menu[102] = "Wählen Sie die Sprache";
					Lang.menu[103] = "Sprache";
					Lang.menu[104] = "Ja";
					Lang.menu[105] = "Nicht";
					Lang.menu[106] = "Toggle Map-Stil";
					Lang.menu[107] = "umschalten Vollbild";
					Lang.menu[108] = "vergrößern";
					Lang.menu[109] = "Verkleinern";
					Lang.menu[110] = "Verringern Transparenz";
					Lang.menu[111] = "Erhöhung der Transparenz";
					Lang.menu[112] = "Karte Aktiviert";
					Lang.menu[113] = "Karte für Behinderte";
					Lang.gen[0] = "Generieren des Weltgelaendes:";
					Lang.gen[1] = "Sand wird hinzugefuegt  ...";
					Lang.gen[2] = "Huegel werden generiert ...";
					Lang.gen[3] = "Dreck wird hinter Dreck geschoben:";
					Lang.gen[4] = "Felsen werden in den Dreck gesetzt ...";
					Lang.gen[5] = "Dreck wird in Felsen platziert ...";
					Lang.gen[6] = "Lehm wird hinzugefuegt ...";
					Lang.gen[7] = "Loecher werden zufaellig geschaffen:";
					Lang.gen[8] = "Generieren kleiner Hoehlen:";
					Lang.gen[9] = "Generieren grosser Hoehlen:";
					Lang.gen[10] = "Hoehlenoberflaechen werden generiert...";
					Lang.gen[11] = "Generieren des Dschungels:";
					Lang.gen[12] = "Schwimmende Inseln werden generiert ...";
					Lang.gen[13] = "Pilzflecken werden generiert ...";
					Lang.gen[14] = "Schlamm wird in Dreck gefuegt ...";
					Lang.gen[15] = "Schlick wird hinzugefuegt ...";
					Lang.gen[16] = "Glitzer wird hinzugefuegt ...";
					Lang.gen[17] = "Spinnweben werden hinzugefuegt ...";
					Lang.gen[18] = "Erstellen der Unterwelt:";
					Lang.gen[19] = "Gewaesser wird hinzugefuegt:";
					Lang.gen[20] = "Macht die Welt boese:";
					Lang.gen[21] = "Berghoehlen werden generiert ...";
					Lang.gen[22] = "Straende werden erstellt ...";
					Lang.gen[23] = "Edelsteine werden hinzugefuegt ...";
					Lang.gen[24] = "Gravitieren von Sand:";
					Lang.gen[25] = "Reinigung von Dreckhintergrund:";
					Lang.gen[26] = "Platzieren von Altaren:";
					Lang.gen[27] = "Gewaesser verteilen:";
					Lang.gen[28] = "Lebenskristalle platzieren:";
					Lang.gen[29] = "Platzieren von Statuen:";
					Lang.gen[30] = "Verstecken von Schaetzen:";
					Lang.gen[31] = "Verstecken von mehr Schaetzen:";
					Lang.gen[32] = "Verstecken von Dschungelschaetzen:";
					Lang.gen[33] = "Verstecken von Wasserschaetzen:";
					Lang.gen[34] = "Platzieren von Fallen:";
					Lang.gen[35] = "Platzieren von Zerbrechlichem:";
					Lang.gen[36] = "Platzieren von Hoellenschmieden:";
					Lang.gen[37] = "Gras wird verteilt ...";
					Lang.gen[38] = "Kakteen wachsen ...";
					Lang.gen[39] = "Sonnenblumen werden gepflanzt ...";
					Lang.gen[40] = "Baeume werden gepflanzt ...";
					Lang.gen[41] = "Kraeuter werden gepflanzt ...";
					Lang.gen[42] = "Unkraut wird gepflanzt ...";
					Lang.gen[43] = "Wein wird angebaut ...";
					Lang.gen[44] = "Blumen werden gepflanzt ...";
					Lang.gen[45] = "Pilze werden gesaet ...";
					Lang.gen[46] = "Ungenutzte Ressourcen werden freigesetzt:";
					Lang.gen[47] = "Spielobjekte werden zurueckgesetzt:";
					Lang.gen[48] = "Schwerer Modus wird eingestellt ...";
					Lang.gen[49] = "Weltdaten werden gesichert:";
					Lang.gen[50] = "Backup von Weltdatei wird erstellt ...";
					Lang.gen[51] = "Weltdaten werden geladen:";
					Lang.gen[52] = "Ueberpruefen der Feld-Ausrichtung:";
					Lang.gen[53] = "Laden fehlgeschlagen!";
					Lang.gen[54] = "Kein Backup gefunden.";
					Lang.gen[55] = "Suchen von Feld-Frames:";
					Lang.gen[56] = "Hinzufügen Schnee ...";
					Lang.gen[57] = "Welt";
					Lang.gen[58] = "Erstellen Verlies:";
					Lang.gen[59] = "Ein Meteorit ist gelandet!";
					Lang.gen[60] = "Glättung der Welt:";
					Lang.gen[61] = "Mossification:";
					Lang.gen[62] = "Gemification:";
					Lang.gen[63] = "Machen Höhlewänden:";
					Lang.gen[64] = "Wachsende Spinne Höhlen:";
					Lang.gen[65] = "Clearing Kartendaten:";
					Lang.gen[66] = "Speichern von Kartendaten:";
					Lang.gen[67] = "Die Karte wird geladen Daten:";
					Lang.gen[68] = "Zeichnen Karte:";
					Lang.gen[69] = "Erstellen Wasserfälle:";
					Lang.gen[70] = "Erstellen Dschungelruinen...";
					Lang.gen[71] = "Erstellen Hornisse Nester...";
					Lang.gen[72] = "Machen Sie die Welt blutige:";
					Lang.inter[0] = "Leben:";
					Lang.inter[1] = "Atem";
					Lang.inter[2] = "Mana";
					Lang.inter[3] = "Muelleimer";
					Lang.inter[4] = "Inventar";
					Lang.inter[5] = "Hotbar entriegelt";
					Lang.inter[6] = "Hotbar gesperrt";
					Lang.inter[7] = "Behausung";
					Lang.inter[8] = "Behausungsanfrage";
					Lang.inter[9] = "Zusaetze";
					Lang.inter[10] = "Abwehr";
					Lang.inter[11] = "Sozial";
					Lang.inter[12] = "Helm";
					Lang.inter[13] = "Hemd";
					Lang.inter[14] = "Hose";
					Lang.inter[15] = "platin";
					Lang.inter[16] = "gold";
					Lang.inter[17] = "silber";
					Lang.inter[18] = "kupfer";
					Lang.inter[19] = "Nachschmieden";
					Lang.inter[20] = "Zum Nachschmieden Item hier platzieren";
					Lang.inter[21] = "Anzeige von Rezepten mit Verwendung von";
					Lang.inter[22] = "Erforderliche Objekte:";
					Lang.inter[23] = "Keins";
					Lang.inter[24] = "Bitte Material hier platzieren, um Rezepte zu zeigen";
					Lang.inter[25] = "Herstellen";
					Lang.inter[26] = "Muenzen";
					Lang.inter[27] = "Munition";
					Lang.inter[28] = "Geschaeft";
					Lang.inter[29] = "Alle ausraeumen";
					Lang.inter[30] = "Alle ablegen";
					Lang.inter[31] = "Schnellstapeln";
					Lang.inter[32] = "Sparschwein";
					Lang.inter[33] = "Tresor";
					Lang.inter[34] = "Zeit:";
					Lang.inter[35] = "Speichern & Beenden";
					Lang.inter[36] = "Trennen";
					Lang.inter[37] = "Artikel";
					Lang.inter[38] = "Du wurdest getoetet ...";
					Lang.inter[39] = "Diese Behausung ist geeignet.";
					Lang.inter[40] = "Das ist keine zulaessiges Behausung";
					Lang.inter[41] = "Diese Behausung ist bereits belegt.";
					Lang.inter[42] = "Diese Behausung ist beschaedigt.";
					Lang.inter[43] = "Zeitueberschreitung bei Verbindung";
					Lang.inter[44] = "Felddaten werden empfangen";
					Lang.inter[45] = "Ausrüsten";
					Lang.inter[46] = "Kosten";
					Lang.inter[47] = "Sparen";
					Lang.inter[48] = "Bearbeiten";
					Lang.inter[49] = "Status";
					Lang.inter[50] = "Fluch";
					Lang.inter[51] = "Hilfe";
					Lang.inter[52] = "Schliessen";
					Lang.inter[53] = "Wasser";
					Lang.inter[54] = "Heilen";
					Lang.inter[55] = "Dieses Gehäuse erfüllt nicht die Anforderungen für eine";
					Lang.inter[56] = "Lava";
					Lang.inter[57] = "Färben";
					Lang.inter[58] = "Liebling";
					Lang.tip[0] = "Ausgestattet in sozialen Schlitz";
					Lang.tip[1] = "Keine Werte werden gewonnen";
					Lang.tip[2] = " Nahkampfschaden";
					Lang.tip[3] = " Fernkampfschaden";
					Lang.tip[4] = " Magischer Schaden";
					Lang.tip[5] = "% kritische Trefferchance";
					Lang.tip[6] = "Wahnsinnig schnell";
					Lang.tip[7] = "Sehr schnell";
					Lang.tip[8] = "Schnell";
					Lang.tip[9] = "Durchschnittlich ";
					Lang.tip[10] = "Langsam";
					Lang.tip[11] = "Sehr langsam";
					Lang.tip[12] = "Extrem langsam";
					Lang.tip[13] = "Schneckentempo";
					Lang.tip[14] = "Kein Rueckstoss";
					Lang.tip[15] = "Extrem schwacher Rueckstoss";
					Lang.tip[16] = "Sehr schwacher Rueckstoss";
					Lang.tip[17] = "Schwacher Rueckstoss";
					Lang.tip[18] = "Mittlerer Rueckstoss";
					Lang.tip[19] = "Starker Rueckstoss";
					Lang.tip[20] = "Sehr starker Rueckstoss";
					Lang.tip[21] = "Extrem starker Rueckstoss";
					Lang.tip[22] = "Wahnsinniger Rueckstoss";
					Lang.tip[23] = "Ausruestbar";
					Lang.tip[24] = "Mode-Items";
					Lang.tip[25] = " Abwehr";
					Lang.tip[26] = "% Spitzhackenkraft";
					Lang.tip[27] = "% Axtmachtkraft";
					Lang.tip[28] = "% Hammerkraft";
					Lang.tip[29] = "Stellt";
					Lang.tip[30] = "Leben wieder her";
					Lang.tip[31] = "Mana wieder her";
					Lang.tip[32] = "Verwendet";
					Lang.tip[33] = "Kann platziert werden";
					Lang.tip[34] = "Munition";
					Lang.tip[35] = "Verbrauchbar";
					Lang.tip[36] = "Material";
					Lang.tip[37] = " Minuten Dauer";
					Lang.tip[38] = " Sekunden Dauer";
					Lang.tip[39] = "% Schaden";
					Lang.tip[40] = "% Tempo";
					Lang.tip[41] = "% kritische Trefferchance";
					Lang.tip[42] = "% Manakosten";
					Lang.tip[43] = "% Groesse";
					Lang.tip[44] = "% Projektiltempo";
					Lang.tip[45] = "% Rueckstoss";
					Lang.tip[46] = "% Bewegungstempo";
					Lang.tip[47] = "% Nahkampftempo";
					Lang.tip[48] = "Bonus-Set:";
					Lang.tip[49] = "Verkaufspreis:";
					Lang.tip[50] = "Kaufpreis:";
					Lang.tip[51] = "Kein Wert";
					Lang.tip[52] = "verbraucht ";
					Lang.tip[53] = " beschwören Schaden";
					Lang.tip[54] = " Bereich";
					Lang.tip[55] = " Schäden";
					Lang.mp[1] = "Falsches Passwort.";
					Lang.mp[2] = "Ungueltige Operation in diesem Zustand.";
					Lang.mp[3] = "Auf diesem Server bist du gesperrt.";
					Lang.mp[4] = "Du verwendest nicht die gleiche Version wie der Server.";
					Lang.mp[5] = "ist bereits auf diesem Server.";
					Lang.mp[5] = "is already on this server.";
					Lang.mp[6] = "/spielen";
					Lang.mp[7] = "Aktuelle Spieler:";
					Lang.mp[8] = "/wuerfeln";
					Lang.mp[9] = "wuerfelt eine";
					Lang.mp[10] = "Du bist in keiner Gruppe!";
					Lang.mp[11] = "hat PvP aktiviert!";
					Lang.mp[12] = "hat PvP deaktiviert!";
					Lang.mp[13] = "ist in keiner Gruppe mehr.";
					Lang.mp[14] = "ist der roten Gruppe beigetreten.";
					Lang.mp[15] = "ist der gruenen Gruppe beigetreten.";
					Lang.mp[16] = "ist der blauen Gruppe beigetreten.";
					Lang.mp[17] = "ist der gelben Gruppe beigetreten.";
					Lang.mp[18] = "Willkommen in";
					Lang.mp[19] = "beigetreten.";
					Lang.mp[20] = "beenden.";
					Lang.the = "der ";
					Lang.dt[0] = "konnte das Antidot nicht finden";
					Lang.dt[1] = "konnte das Feuer nicht loeschen";
					Main.buffName[1] = "Obsidianhaut";
					Main.buffTip[1] = "Immun gegen Lava";
					Main.buffName[2] = "Wiederbelebung";
					Main.buffTip[2] = "Belebt wieder";
					Main.buffName[3] = "Wendigkeit";
					Main.buffTip[3] = "Erhoeht Bewegungstempo um 25%";
					Main.buffName[4] = "Kiemen";
					Main.buffTip[4] = "Wasser statt Luft atmen";
					Main.buffName[5] = "Eisenhaut";
					Main.buffTip[5] = "Erhoeht die Abwehr um 8";
					Main.buffName[6] = "Mana-Wiederherstellung";
					Main.buffTip[6] = "Erhoehte Mana-Wiederherstellung";
					Main.buffName[7] = "Magiekraft";
					Main.buffTip[7] = "Erhoeht magischen Schaden um 20%";
					Main.buffName[8] = "Federsturz";
					Main.buffTip[8] = "Zur Kontrolle der Sinkgeschwindigkeit UP oder DOWN druecken ";
					Main.buffName[9] = "Hoehlenforscher";
					Main.buffTip[9] = "Zeigt den Fundort von Schatz und Erz";
					Main.buffName[10] = "Unsichtbarkeit";
					Main.buffTip[10] = "Macht unsichtbar";
					Main.buffName[11] = "Glanz";
					Main.buffTip[11] = "Strahlt Licht aus";
					Main.buffName[12] = "Nachteule";
					Main.buffTip[12] = "Erhoehte Nachtsicht";
					Main.buffName[13] = "Kampf";
					Main.buffTip[13] = "Erhoehte Feind-Spawnrate";
					Main.buffName[14] = "Dornen";
					Main.buffTip[14] = "Auch die Angreifer erleiden Schaden";
					Main.buffName[15] = "Wasserlaufen";
					Main.buffTip[15] = "DOWN druecken, um aufs Wasser zu gehen";
					Main.buffName[16] = "Bogenschiessen";
					Main.buffTip[16] = "Um 20% erhoehter Pfeilschaden und -tempo";
					Main.buffName[17] = "Jaeger";
					Main.buffTip[17] = "Zeigt die Position von Feinden";
					Main.buffName[18] = "Gravitation";
					Main.buffTip[18] = "Zum Umkehren der Schwerkraft UP oder DOWN druecken";
					Main.buffName[19] = "Lichtkugel";
					Main.buffTip[19] = "Eine magische Kugel, die Licht verstroemt";
					Main.buffName[20] = "Vergiftet";
					Main.buffTip[20] = "Langsam entweicht das Leben";
					Main.buffName[21] = "Krankheitstrank";
					Main.buffTip[21] = "Kann keine Heil-Items mehr verbrauchen";
					Main.buffName[22] = "Dunkelheit";
					Main.buffTip[22] = "Schlechtere Sicht durch weniger Licht";
					Main.buffName[23] = "Verflucht";
					Main.buffTip[23] = "Kann keine Items verwenden";
					Main.buffName[24] = "Flammenmeer!";
					Main.buffTip[24] = "Langsam entweicht das Leben";
					Main.buffName[25] = "Beschwipst";
					Main.buffTip[25] = "Erhoehte Nahkampffaehigkeiten, verminderte Abwehr";
					Main.buffName[26] = "Kleine Staerkung";
					Main.buffTip[26] = "Geringe Anhebung aller Werte";
					Main.buffName[27] = "Fee";
					Main.buffTip[27] = "Eine Fee folgt dir";
					Main.buffName[28] = "Werwolf";
					Main.buffTip[28] = "Koerperliche Faehigkeiten sind gestiegen";
					Main.buffName[29] = "Hellsehen";
					Main.buffTip[29] = "Magiekraefte werden erhoeht";
					Main.buffName[30] = "Blutung";
					Main.buffTip[30] = "Kann nicht wiederbeleben";
					Main.buffName[31] = "Verwirrt";
					Main.buffTip[31] = "Bewegung wird umgekehrt";
					Main.buffName[32] = "Langsam";
					Main.buffTip[32] = "Bewegungen werden verlangsamt";
					Main.buffName[33] = "Schwach";
					Main.buffTip[33] = "Koerperliche Faehigkeiten sind gesunken";
					Main.buffName[34] = "Meermenschen";
					Main.buffTip[34] = "Kann atmen und  sich leicht unter Wasser bewegen";
					Main.buffName[35] = "Schweigen";
					Main.buffTip[35] = "Nicht verwenden können Gegenstände, die Mana benötigen";
					Main.buffName[36] = "Kaputte Ruestung";
					Main.buffTip[36] = "Die Abwehr ist halbiert worden";
					Main.buffName[37] = "Entsetzt";
					Main.buffTip[37] = "Du hast etwas Ekliges gesehen, es gibt kein Entrinnen.";
					Main.buffName[38] = "Die Zunge";
					Main.buffTip[38] = "Du wirst ins Maul eingesaugt";
					Main.buffName[39] = "Verfluchtes Inferno";
					Main.buffTip[39] = "Das Leben entweicht";
					Main.buffName[40] = "Haustierhäschen";
					Main.buffTip[40] = "Ich denke, sie will deine Karotte";
					Main.buffName[41] = "Baby-Pinguin";
					Main.buffTip[41] = "Ich denke, sie will Ihre Fische";
					Main.buffName[42] = "Haustier Schildkröte";
					Main.buffTip[42] = "Glückliche Schildkröte Zeit!";
					Main.buffName[43] = "Paladin Schild";
					Main.buffTip[43] = "25% der Schäden getroffen werden, um einen anderen Spieler umgeleitet werden";
					Main.buffName[44] = "Frost brennen";
					Main.buffTip[44] = "Es ist entweder sehr heiß oder sehr kalt. So oder so ist es wirklich weh tut";
					Main.buffName[45] = "Baby Esser";
					Main.buffTip[45] = "Ein Baby-Eater of Souls wird Ihnen folgen";
					Main.buffName[46] = "Gekühlt";
					Main.buffTip[46] = "Ihre Bewegungsgeschwindigkeit verringert wurde";
					Main.buffName[47] = "eingefroren";
					Main.buffTip[47] = "Sie können sich nicht bewegen!";
					Main.buffName[48] = "Liebling";
					Main.buffTip[48] = "Leben Regeneration erhöht";
					Main.buffName[49] = "Pygmäen";
					Main.buffTip[49] = "Die Pygmäen wird für euch streiten";
					Main.buffName[50] = "Baby-Skeletron Kopf";
					Main.buffTip[50] = "Noch nicht einmal fragen ...";
					Main.buffName[51] = "Baby-Hornet";
					Main.buffTip[51] = "Es denkt, du bist seine Mutter";
					Main.buffName[52] = "Tiki Geist";
					Main.buffTip[52] = "Ein freundlicher Geist verfolgt dich";
					Main.buffName[53] = "Haustier Eidechse";
					Main.buffTip[53] = "Chillin 'wie ein Reptil";
					Main.buffName[54] = "Papagei";
					Main.buffTip[54] = "Polly Mangel ist der Cracker";
					Main.buffName[55] = "Baby Trüffel";
					Main.buffTip[55] = "Ist das nicht gerade soooo süß?";
					Main.buffName[56] = "Bäumchen";
					Main.buffTip[56] = "Ein kleines Bäumchen Ihnen folgt";
					Main.buffName[57] = "Irrlicht";
					Main.buffTip[57] = "Ein Hauch Ihnen folgt";
					Main.buffName[58] = "Schnelle Heilung";
					Main.buffTip[58] = "Leben Regeneration stark erhöht";
					Main.buffName[59] = "Schatten Ausweichen";
					Main.buffTip[59] = "Sie werden den nächsten Angriff ausweichen";
					Main.buffName[60] = "Blatt Kristall";
					Main.buffTip[60] = "Shoots Kristall fährt um Feinde in der Nähe";
					Main.buffName[61] = "Baby-Dinosaurier";
					Main.buffTip[61] = "Ein Baby-Dinosaurier Ihnen folgt";
					Main.buffName[62] = "Eisbarriere";
					Main.buffTip[62] = "Verteidigung ist um 30 erhöht";
					Main.buffName[63] = "Panik!";
					Main.buffTip[63] = "Die Bewegungsgeschwindigkeit wird erhöht";
					Main.buffName[64] = "Baby Schleim";
					Main.buffTip[64] = "Das Baby Schleim wird für euch streiten";
					Main.buffName[65] = "Augapfel Frühling";
					Main.buffTip[65] = "Ein Augapfel Frühjahr Ihnen folgt";
					Main.buffName[66] = "Baby-Schneemann";
					Main.buffTip[66] = "Ein Baby-Schneemann Ihnen folgt";
					Main.buffName[67] = "Brennen";
					Main.buffTip[67] = "Losing Leben und verlangsamte Bewegung";
					Main.buffName[68] = "Erstickung";
					Main.buffTip[68] = "Losing Leben";
					Main.buffName[69] = "Ichor";
					Main.buffTip[69] = "Statt Verteidigung";
					Main.buffName[70] = "Gift 2";
					Main.buffTip[70] = "Losing Leben";
					Main.buffName[72] = "Midas";
					Main.buffTip[72] = "Lassen Sie mehr Geld auf den Tod";
					Main.buffName[80] = "Blackout";
					Main.buffTip[80] = "Licht Vision stark reduziert";
					Main.buffName[71] = "Waffe verleihen: Gift 2";
					Main.buffTip[71] = "Nahkampfangriffe verursachen Gift auf Ihre Ziele";
					Main.buffName[73] = "Waffe verleihen: verflucht Flammen";
					Main.buffTip[73] = "Nahkampfangriffe verursachen Feinde verflucht mit Flammen";
					Main.buffName[74] = "Waffe verleihen: Feuer";
					Main.buffTip[74] = "Nahkampfangriffe gesetzt Feinde";
					Main.buffName[75] = "Waffe verleihen: Gold";
					Main.buffTip[75] = "Nahkampfangriffe Feinde machen fallen mehr Gold";
					Main.buffName[76] = "Waffe verleihen: Ichor";
					Main.buffTip[76] = "Nahkampfangriffe verringern Feinde Verteidigung";
					Main.buffName[77] = "Waffe verleihen: Nanites";
					Main.buffTip[77] = "Nahkampfangriffe verwirren Feinde";
					Main.buffName[78] = "Waffe verleihen: Konfetti";
					Main.buffTip[78] = "Nahkampfangriffe verursachen Konfetti zu erscheinen";
					Main.buffName[79] = "Waffe verleihen: Gift";
					Main.buffTip[79] = "Nahkampfangriffe Gift Feinde";
					Main.tileName[13] = "Flasche";
					Main.tileName[14] = "Tabelle";
					Main.tileName[15] = "Stuhl";
					Main.tileName[16] = "Amboss";
					Main.tileName[17] = "Ofen";
					Main.tileName[18] = "Werkbank";
					Main.tileName[26] = "Dämon Altar";
					Main.tileName[77] = "Hoellenschmiede";
					Main.tileName[86] = "Webstuhl";
					Main.tileName[94] = "Gaerbottich";
					Main.tileName[96] = "Kochtopf";
					Main.tileName[101] = "Buecherregal";
					Main.tileName[106] = "Saegewerk";
					Main.tileName[114] = "Tueftler-Werkstatt";
					Main.tileName[133] = "Adamantitschmiede";
					Main.tileName[134] = "Mithrilamboss";
				}
				else
				{
					if (Lang.lang == 3)
					{
						Lang.misc[0] = "L'esercito di goblin è stato sconfitto! ";
						Lang.misc[1] = "Un esercito di goblin si sta avvicinando da ovest!";
						Lang.misc[2] = "Un esercito di goblin si sta avvicinando da est!";
						Lang.misc[3] = "Un esercito di goblin è arrivato!";
						Lang.misc[4] = "La Legione di Frost è stato sconfitto!";
						Lang.misc[5] = "La Legione gelo si sta avvicinando da ovest!";
						Lang.misc[6] = "La Legione gelo si sta avvicinando da est!";
						Lang.misc[7] = "La Legione gelo è arrivato!";
						Lang.misc[8] = "La luna di sangue sta sorgendo...";
						Lang.misc[9] = "Senti una presenza malvagia che ti sta guardando...";
						Lang.misc[10] = "Un freddo terribile ti attraversa la spina dorsale...";
						Lang.misc[11] = "Intorno a te echeggiano urla... ";
						Lang.misc[12] = "Il tuo mondo è stato benedetto con cobalto! ";
						Lang.misc[13] = "Il tuo mondo è stato benedetto con mitrilio! ";
						Lang.misc[14] = "Il tuo mondo è stato benedetto con adamantio!";
						Lang.misc[15] = "I vecchi spiriti di luce e tenebre sono stati liberati.  ";
						Lang.misc[16] = "si è svegliato!";
						Lang.misc[17] = "è stato sconfitto!";
						Lang.misc[18] = "è arrivato!";
						Lang.misc[19] = " è stato ucciso...";
						Lang.misc[20] = "Un eclissi solare sta accadendo!";
						Lang.misc[21] = "Il vostro mondo è stato benedetto con Palladium!";
						Lang.misc[22] = "Il vostro mondo è stato benedetto con oricalco!";
						Lang.misc[23] = "Your world has been blessed with titanium!";
						Lang.misc[24] = "I pirati sono stati sconfitti!";
						Lang.misc[25] = "I pirati si stanno avvicinando da ovest!";
						Lang.misc[26] = "I pirati si stanno avvicinando da est!";
						Lang.misc[27] = "I pirati sono arrivati!";
						Lang.misc[28] = "Ti senti vibrazioni profondità sotto ...";
						Lang.misc[29] = "Questa sarà una notte terribile ...";
						Lang.misc[30] = "L'aria è sempre più fredda intorno a te ...";
						Lang.menu[0] = "Inizia una nuova istanza di Terraria!";
						Lang.menu[1] = "In esecuzione sulla porta";
						Lang.menu[2] = "Disconnetti";
						Lang.menu[3] = "Il server richiede una password:";
						Lang.menu[4] = "Accetta";
						Lang.menu[5] = "Indietro";
						Lang.menu[6] = "Annulla";
						Lang.menu[7] = "Inserisci la password del server:";
						Lang.menu[8] = "Avvio del server...";
						Lang.menu[9] = "Caricamento non riuscito!";
						Lang.menu[10] = "Carica backup";
						Lang.menu[11] = "Backup non trovato";
						Lang.menu[12] = "Giocatore singolo";
						Lang.menu[13] = "Multigiocatore";
						Lang.menu[14] = "Impostazioni";
						Lang.menu[15] = "Esci";
						Lang.menu[16] = "Crea personaggio";
						Lang.menu[17] = "Elimina";
						Lang.menu[18] = "Capelli";
						Lang.menu[19] = "Occhi";
						Lang.menu[20] = "Pelle";
						Lang.menu[21] = "Abiti";
						Lang.menu[22] = "Maschio";
						Lang.menu[23] = "Femmina";
						Lang.menu[24] = "Harcore";
						Lang.menu[25] = "Mediumcore ";
						Lang.menu[26] = "Softcore ";
						Lang.menu[27] = "Casuale";
						Lang.menu[28] = "Crea";
						Lang.menu[29] = "I personaggi hardcore muoiono definitivamente";
						Lang.menu[30] = "I personaggi mediumcore perdono oggetti morendo";
						Lang.menu[31] = "I personaggi softcore perdono denaro morendo";
						Lang.menu[32] = "Livello di difficoltà";
						Lang.menu[33] = "Camicia";
						Lang.menu[34] = "Maglietta";
						Lang.menu[35] = "Pantaloni";
						Lang.menu[36] = "Scarpe";
						Lang.menu[37] = "Capelli";
						Lang.menu[38] = "Colore capelli";
						Lang.menu[39] = "Colore occhi";
						Lang.menu[40] = "Colore pelle";
						Lang.menu[41] = "Colore camicia";
						Lang.menu[42] = "Colore maglietta";
						Lang.menu[43] = "Colore pantaloni";
						Lang.menu[44] = "Colore scarpe";
						Lang.menu[45] = "Inserisci nome personaggio:";
						Lang.menu[46] = "Elimina";
						Lang.menu[47] = "Crea mondo";
						Lang.menu[48] = "Inserisci nome mondo:";
						Lang.menu[49] = "Finestra";
						Lang.menu[50] = "Schermo intero";
						Lang.menu[51] = "Risoluzione";
						Lang.menu[52] = "Parallasse";
						Lang.menu[53] = "Salta fotogrammi Off (sconsigliato)";
						Lang.menu[54] = "Salta fotogrammi On (consigliato)";
						Lang.menu[55] = "Illuminazione: a colori ";
						Lang.menu[56] = "Illuminazione: bianca";
						Lang.menu[57] = "Illuminazione: retro";
						Lang.menu[58] = "Illuminazione: speciale";
						Lang.menu[59] = "Qualità: automatica";
						Lang.menu[60] = "Qualità: alta";
						Lang.menu[61] = "Qualità: media";
						Lang.menu[62] = "Qualità: bassa";
						Lang.menu[63] = "Video";
						Lang.menu[64] = "Colore cursore";
						Lang.menu[65] = "Volume";
						Lang.menu[66] = "Comandi";
						Lang.menu[67] = "Salvataggio automatico On";
						Lang.menu[68] = "Salvataggio automatico Off";
						Lang.menu[69] = "Pausa automatica On";
						Lang.menu[70] = "Pausa automatica Off";
						Lang.menu[71] = "Testo di collegamento On";
						Lang.menu[72] = "Testo di collegamento Off";
						Lang.menu[73] = "Risoluzione a schermo intero";
						Lang.menu[74] = "Su                      ";
						Lang.menu[75] = "Giù                     ";
						Lang.menu[76] = "Sinistra                 ";
						Lang.menu[77] = "Destra                  ";
						Lang.menu[78] = "Salta                    ";
						Lang.menu[79] = "Lancia                   ";
						Lang.menu[80] = "Inventario               ";
						Lang.menu[81] = "Cura veloce             ";
						Lang.menu[82] = "Mana veloce            ";
						Lang.menu[83] = "Buff veloce             ";
						Lang.menu[84] = "Rampino                 ";
						Lang.menu[85] = "Selezione automatica   ";
						Lang.menu[86] = "Ripristina predefiniti";
						Lang.menu[87] = "Entra";
						Lang.menu[88] = "Ospita e gioca";
						Lang.menu[89] = "Inserisci indirizzo IP del server:";
						Lang.menu[90] = "Inserisci porta server:";
						Lang.menu[91] = "Scegli grandezza del mondo:";
						Lang.menu[92] = "Piccolo";
						Lang.menu[93] = "Medio";
						Lang.menu[94] = "Grande";
						Lang.menu[95] = "Rosso:";
						Lang.menu[96] = "Verde:";
						Lang.menu[97] = "Blu:";
						Lang.menu[98] = "Audio:";
						Lang.menu[99] = "Musica:";
						Lang.menu[100] = "Sfondo su";
						Lang.menu[101] = "Fondo off";
						Lang.menu[102] = "Selezionare la lingua";
						Lang.menu[103] = "Lingua";
						Lang.menu[104] = "Sì";
						Lang.menu[105] = "No";
						Lang.menu[106] = "mappa levetta stile";
						Lang.menu[107] = "Alterna a tutto schermo";
						Lang.menu[108] = "zoom in";
						Lang.menu[109] = "rimpicciolire";
						Lang.menu[110] = "diminuire Trasparenza";
						Lang.menu[111] = "aumentare la trasparenza";
						Lang.menu[112] = "mappa attivato";
						Lang.menu[113] = "mappa Disabilitato";
						Lang.gen[0] = "Crea terreno del mondo:";
						Lang.gen[1] = "Aggiunta sabbia...";
						Lang.gen[2] = "Creazione colline...";
						Lang.gen[3] = "Aggiungi terra dietro la terra:";
						Lang.gen[4] = "Aggiunta rocce nella terra...";
						Lang.gen[5] = "Aggiunta terra nelle rocce...";
						Lang.gen[6] = "Aggiunta argilla...";
						Lang.gen[7] = "Crea fori casuali:";
						Lang.gen[8] = "Crea piccole grotte: ";
						Lang.gen[9] = "Crea grandi grotte:";
						Lang.gen[10] = "Creazione di grotte superficiali...";
						Lang.gen[11] = "Crea giungla:";
						Lang.gen[12] = "Creazione di isole galleggianti...";
						Lang.gen[13] = "Aggiunta campi di funghi...";
						Lang.gen[14] = "Aggiunta fango nella terra...";
						Lang.gen[15] = "Aggiunta fango...";
						Lang.gen[16] = "Aggiunta elementi luminosi...";
						Lang.gen[17] = "Aggiunta ragnatele...";
						Lang.gen[18] = "Crea sottomondo:";
						Lang.gen[19] = "Aggiungi creature acquatiche:";
						Lang.gen[20] = "Rendi il mondo malvagio:";
						Lang.gen[21] = "Creazione grotte montuose...";
						Lang.gen[22] = "Creazione spiagge...";
						Lang.gen[23] = "Aggiunta gemme...";
						Lang.gen[24] = "Ruota sabbia:";
						Lang.gen[25] = "Pulisci sfondi terra:";
						Lang.gen[26] = "Aggiungi altari:";
						Lang.gen[27] = "Versa liquidi:";
						Lang.gen[28] = "Aggiungi cristalli di vita:";
						Lang.gen[29] = "Aggiungi statue:";
						Lang.gen[30] = "Nascondi tesori:";
						Lang.gen[31] = "Nascondi più tesori:";
						Lang.gen[32] = "Nascondi tesori nella giungla:";
						Lang.gen[33] = "Nascondi tesori in acqua:";
						Lang.gen[34] = "Disponi trappole:";
						Lang.gen[35] = "Disponi gli oggetti fragili:";
						Lang.gen[36] = "Disponi creazioni degli inferi:";
						Lang.gen[37] = "Estensione erba...";
						Lang.gen[38] = "Crescita cactus...";
						Lang.gen[39] = "Pianta girasoli...";
						Lang.gen[40] = "Pianta alberi...";
						Lang.gen[41] = "Pianta erbe...";
						Lang.gen[42] = "Pianta erbacce...";
						Lang.gen[43] = "Crescita viti...";
						Lang.gen[44] = "Pianta fiori...";
						Lang.gen[45] = "Pianta funghi...";
						Lang.gen[46] = "Libera risorse inutilizzate:";
						Lang.gen[47] = "Resetta oggetti di gioco:";
						Lang.gen[48] = "Imposta modalità difficile...";
						Lang.gen[49] = "Salva dati del mondo:";
						Lang.gen[50] = "Backup file mondo...";
						Lang.gen[51] = "Carica dati del mondo:";
						Lang.gen[52] = "Controlla l'allineamento delle mattonelle:";
						Lang.gen[53] = "Caricamento non riuscito!";
						Lang.gen[54] = "Backup non trovato";
						Lang.gen[55] = "Trova cornici delle mattonelle:";
						Lang.gen[56] = "L'aggiunta di neve ...";
						Lang.gen[57] = "Mondo";
						Lang.gen[58] = "La creazione di dungeon:";
						Lang.gen[59] = "Un meteorite è atterrato!";
						Lang.gen[60] = "Smoothing il mondo:";
						Lang.gen[61] = "Mossification:";
						Lang.gen[62] = "Gemification:";
						Lang.gen[63] = "Fare pareti delle caverne:";
						Lang.gen[64] = "Crescere grotte ragno:";
						Lang.gen[65] = "Clearing mappa dati:";
						Lang.gen[66] = "Salvataggio dei dati della mappa:";
						Lang.gen[67] = "Caricamento dati della mappa:";
						Lang.gen[68] = "disegnare la mappa:";
						Lang.gen[69] = "creazione di cascate:";
						Lang.gen[70] = "Creazione di rovine della giungla...";
						Lang.gen[71] = "Creazione di nidi di calabrone...";
						Lang.gen[72] = "Rendere il mondo insanguinato:";
						Lang.inter[0] = "Vita:";
						Lang.inter[1] = "Respiro";
						Lang.inter[2] = "Mana ";
						Lang.inter[3] = "Bidone";
						Lang.inter[4] = "Inventario";
						Lang.inter[5] = "Hotbar sbloccato";
						Lang.inter[6] = "Hotbar bloccato";
						Lang.inter[7] = "Alloggio";
						Lang.inter[8] = "Richiesta alloggio";
						Lang.inter[9] = "Accessori";
						Lang.inter[10] = "Difesa";
						Lang.inter[11] = "Sociale";
						Lang.inter[12] = "Casco";
						Lang.inter[13] = "Camicia";
						Lang.inter[14] = "Pantaloni";
						Lang.inter[15] = "platino";
						Lang.inter[16] = "oro";
						Lang.inter[17] = "argento";
						Lang.inter[18] = "rame";
						Lang.inter[19] = "Riforgiare";
						Lang.inter[20] = "Posizionare un oggetto qui per riforgiare";
						Lang.inter[21] = "Mostra ricetta da usare";
						Lang.inter[22] = "Oggetti richiesti:";
						Lang.inter[23] = "Nessuno";
						Lang.inter[24] = "Posizionare un materiale qui per mostrare ricette";
						Lang.inter[25] = "Artigianato";
						Lang.inter[26] = "Monete";
						Lang.inter[27] = "Munizioni";
						Lang.inter[28] = "Negozio";
						Lang.inter[29] = "Saccheggia tutto";
						Lang.inter[30] = "Deposita tutto";
						Lang.inter[31] = "Accumulo veloce";
						Lang.inter[32] = "Salvadanaio";
						Lang.inter[33] = "Caveau";
						Lang.inter[34] = "Tempo:";
						Lang.inter[35] = "Salva ed esci";
						Lang.inter[36] = "Disconnetti";
						Lang.inter[37] = "Oggetti";
						Lang.inter[38] = "Sei morto...";
						Lang.inter[39] = "Questo alloggio è adatto.";
						Lang.inter[40] = "Questo alloggio non è valido.";
						Lang.inter[41] = "Questo alloggio è già occupato.";
						Lang.inter[42] = "Questo alloggio è distrutto.";
						Lang.inter[43] = "Connessione scaduta";
						Lang.inter[44] = "Ricezione dati mattonella";
						Lang.inter[45] = "Equipaggiare";
						Lang.inter[46] = "Costo";
						Lang.inter[47] = "Salvare";
						Lang.inter[48] = "Edit";
						Lang.inter[49] = "Stato";
						Lang.inter[50] = "Maledizione";
						Lang.inter[51] = "Aiutare";
						Lang.inter[52] = "Fermer";
						Lang.inter[53] = "Acqua";
						Lang.inter[54] = "Guarire";
						Lang.inter[55] = "Questa custodia non soddisfa i requisiti per un";
						Lang.inter[56] = "lavica";
						Lang.inter[57] = "tingere";
						Lang.inter[58] = "dolcezza";
						Lang.tip[0] = "Equipaggiato in slot sociale";
						Lang.tip[1] = "Nessun parametro incrementato";
						Lang.tip[2] = " Danno nel corpo a corpo";
						Lang.tip[3] = " Danno a distanza";
						Lang.tip[4] = " Danno magico";
						Lang.tip[5] = "% Possibilità colpo critico";
						Lang.tip[6] = "Velocità matta";
						Lang.tip[7] = "Extra velocità";
						Lang.tip[8] = "Alta velocità";
						Lang.tip[9] = "Media velocità";
						Lang.tip[10] = "Bassa velocità";
						Lang.tip[11] = "Velocità molto bassa";
						Lang.tip[12] = "Velocità extra bassa";
						Lang.tip[13] = "Velocità lumaca";
						Lang.tip[14] = "Nessuno spintone";
						Lang.tip[15] = "Spintone extra debole";
						Lang.tip[16] = "Spintone molto debole";
						Lang.tip[17] = "Spintone debole";
						Lang.tip[18] = "Spintone medio";
						Lang.tip[19] = "Spintone forte";
						Lang.tip[20] = "Spintone molto forte";
						Lang.tip[21] = "Spintone extra forte";
						Lang.tip[22] = "Spintone matto";
						Lang.tip[23] = "Equipaggiabili";
						Lang.tip[24] = "Oggetti estetici";
						Lang.tip[25] = " Difesa";
						Lang.tip[26] = "% Potenza piccone";
						Lang.tip[27] = "% Potenza ascia";
						Lang.tip[28] = "% Potenza martello";
						Lang.tip[29] = "Risana";
						Lang.tip[30] = "vita";
						Lang.tip[31] = "mana";
						Lang.tip[32] = "Utilizza";
						Lang.tip[33] = "Può essere posizionato";
						Lang.tip[34] = "Munizioni";
						Lang.tip[35] = "Consumabile";
						Lang.tip[36] = "Materiale";
						Lang.tip[37] = " Durata minuto";
						Lang.tip[38] = " Durata secondo";
						Lang.tip[39] = "% Danno";
						Lang.tip[40] = "% Velocità";
						Lang.tip[41] = "% Possibilità colpo critico";
						Lang.tip[42] = "% Costo mana";
						Lang.tip[43] = "% Dimensione";
						Lang.tip[44] = "% Velocità del proiettile";
						Lang.tip[45] = "% Spintone";
						Lang.tip[46] = "% Velocità movimento";
						Lang.tip[47] = "% Velocità corpo a corpo";
						Lang.tip[48] = "Imposta bonus:";
						Lang.tip[49] = "Prezzo di vendita:";
						Lang.tip[50] = "Prezzo di acquisto:";
						Lang.tip[51] = "Nessun valore";
						Lang.tip[52] = "consuma ";
						Lang.tip[53] = " convocare i danni";
						Lang.tip[54] = " gamma";
						Lang.tip[55] = " danni";
						Lang.mp[0] = "Ricevere:";
						Lang.mp[1] = "Password errata.";
						Lang.mp[2] = "Operazione non valida in questo stato.";
						Lang.mp[3] = "Sei stato bandito da questo server.";
						Lang.mp[4] = "Non stai utilizzando la stessa versione del server.";
						Lang.mp[5] = "è già su questo server.";
						Lang.mp[6] = "/in gioco";
						Lang.mp[7] = "Giocatori correnti:";
						Lang.mp[8] = "/lancia";
						Lang.mp[9] = "lancia";
						Lang.mp[10] = "Non fai parte di un gruppo!";
						Lang.mp[11] = "ha attivato il PvP!";
						Lang.mp[12] = "ha disattivato il PvP!";
						Lang.mp[13] = "non è più in un gruppo.";
						Lang.mp[14] = "si è unito al gruppo rosso.";
						Lang.mp[15] = "si è unito al gruppo verde.";
						Lang.mp[16] = "si è unito al gruppo blu.";
						Lang.mp[17] = "si è unito al gruppo giallo.";
						Lang.mp[18] = "Benevenuto a";
						Lang.mp[19] = "ha aderito.";
						Lang.mp[20] = "ha smesso di.";
						Lang.the = "la ";
						Lang.dt[0] = "non ha trovato l'antidoto";
						Lang.dt[1] = "non ha spento il fuoco";
						Main.buffName[1] = "Pelle ossidiana";
						Main.buffTip[1] = "Immune alla lava";
						Main.buffName[2] = "Rigenerazione";
						Main.buffTip[2] = "Rigenera la vita";
						Main.buffName[3] = "Velocità";
						Main.buffTip[3] = "Velocità di movimento aumentata del 25%";
						Main.buffName[4] = "Branchie";
						Main.buffTip[4] = "Respira acqua invece di aria";
						Main.buffName[5] = "Pelle di ferro";
						Main.buffTip[5] = "Aumenta la difesa di 8";
						Main.buffName[6] = "Rigenerazione mana";
						Main.buffTip[6] = "Aumenta la rigenerazione del mana";
						Main.buffName[7] = "Potere magico";
						Main.buffTip[7] = "Danno magico aumentato del 20%";
						Main.buffName[8] = "Cascata di piume";
						Main.buffTip[8] = "Premi UP o DOWN per controllare la velocità di discesa";
						Main.buffName[9] = "Speleologo";
						Main.buffTip[9] = "Mostra l'ubicazione di tesori e minerale";
						Main.buffName[10] = "Invisibilità";
						Main.buffTip[10] = "Rende invisibili";
						Main.buffName[11] = "Brillantezza";
						Main.buffTip[11] = "Emette luce";
						Main.buffName[12] = "Civetta notturna";
						Main.buffTip[12] = "Visione notturna aumentata";
						Main.buffName[13] = "Battaglia";
						Main.buffTip[13] = "Ritmo generazione nemici aumentato";
						Main.buffName[14] = "Spine";
						Main.buffTip[14] = "Anche gli aggressori subiscono danni";
						Main.buffName[15] = "Camminata nell'acqua";
						Main.buffTip[15] = "Premi DOWN per entrare nell'acqua";
						Main.buffName[16] = "Arco";
						Main.buffTip[16] = "Danno e velocià freccia aumentati del 20%";
						Main.buffName[17] = "Cacciatore";
						Main.buffTip[17] = "Mostra la posizione dei nemici";
						Main.buffName[18] = "Gravità";
						Main.buffTip[18] = "Premi UP o DOWN per invertire la gravità";
						Main.buffName[19] = "Orbita di luce";
						Main.buffTip[19] = "Sfera magica che fornisce luce";
						Main.buffName[20] = "Avvelenato";
						Main.buffTip[20] = "Perdi lentamente la vita";
						Main.buffName[21] = "Malattia pozione";
						Main.buffTip[21] = "Non si possono più consumare oggetti curativi";
						Main.buffName[22] = "Oscurità";
						Main.buffTip[22] = "Diminuita visione della luce";
						Main.buffName[23] = "Maledetto";
						Main.buffTip[23] = "Non si possono più utilizzare oggetti";
						Main.buffName[24] = "A fuoco!";
						Main.buffTip[24] = "Perdi lentamente la vita";
						Main.buffName[25] = "Brillo";
						Main.buffTip[25] = "Abilità corpo a corpo aumentata, difesa abbassata";
						Main.buffName[26] = "Ben nutrito";
						Main.buffTip[26] = "Migliorie minori a tutti i parametri";
						Main.buffName[27] = "Fata";
						Main.buffTip[27] = "Una fata ti sta seguendo";
						Main.buffName[28] = "Lupo mannaro";
						Main.buffTip[28] = "Abilità fisiche aumentate";
						Main.buffName[29] = "Chiaroveggenza";
						Main.buffTip[29] = "Poteri magici aumentati";
						Main.buffName[30] = "Emorragia";
						Main.buffTip[30] = "Impossibile rigenerare vita";
						Main.buffName[31] = "Confuso";
						Main.buffTip[31] = "Movimento invertito";
						Main.buffName[32] = "Lento";
						Main.buffTip[32] = "Ridotta velocità movimento";
						Main.buffName[33] = "Debole";
						Main.buffTip[33] = "Abilità fisiche diminuite";
						Main.buffName[34] = "Tritone";
						Main.buffTip[34] = "Può respirare e muoversi facilmente sott'acqua";
						Main.buffName[35] = "Tacere";
						Main.buffTip[35] = "Non possono utilizzare gli elementi che richiedono mana";
						Main.buffName[36] = "Armatura rotta";
						Main.buffTip[36] = "La difesa è dimezzata";
						Main.buffName[37] = "Inorridito";
						Main.buffTip[37] = "Hai visto qualcosa di orribile, non c'è via di scampo.";
						Main.buffName[38] = "La Lingua";
						Main.buffTip[38] = "Sei stato succhiato nella bocca";
						Main.buffName[39] = "Inferno maledetto";
						Main.buffTip[39] = "Perdi la vita";
						Main.buffName[40] = "Animale coniglio";
						Main.buffTip[40] = "Penso che vuole la tua carota";
						Main.buffName[41] = "baby pinguino";
						Main.buffTip[41] = "Penso che vuole il vostro pesce";
						Main.buffName[42] = "tartaruga";
						Main.buffTip[42] = "Tempo tartaruga felice!";
						Main.buffName[43] = "Scudo Paladino";
						Main.buffTip[43] = "Il 25% dei danni subiti sarà reindirizzato ad un altro giocatore";
						Main.buffName[44] = "gelo ustione";
						Main.buffTip[44] = "E 'sia davvero caldo o molto freddo. In entrambi i casi fa davvero male";
						Main.buffName[45] = "bambino Eater";
						Main.buffTip[45] = "Un bambino Eater of Souls ti sta seguendo";
						Main.buffName[46] = "refrigerate";
						Main.buffTip[46] = "La velocità di movimento è stato ridotto";
						Main.buffName[47] = "congelato";
						Main.buffTip[47] = "Non è possibile spostare!";
						Main.buffName[48] = "dolcezza";
						Main.buffTip[48] = "La vita di rigenerazione viene aumentata";
						Main.buffName[49] = "pigmei";
						Main.buffTip[49] = "I pigmei combatteranno per voi";
						Main.buffName[50] = "Bambino Skeletron Capo";
						Main.buffTip[50] = "Non hanno nemmeno chiedere ...";
						Main.buffName[51] = "bambino Hornet";
						Main.buffTip[51] = "Si pensa che tu sia sua madre";
						Main.buffName[52] = "Tiki Spirito";
						Main.buffTip[52] = "Uno spirito amichevole ti sta seguendo";
						Main.buffName[53] = "lucertola";
						Main.buffTip[53] = "Chillin 'come un rettile";
						Main.buffName[54] = "Pet Parrot";
						Main.buffTip[54] = "Polly want è il cracker";
						Main.buffName[55] = "tartufo bambino";
						Main.buffTip[55] = "Non è questo solo soooo cute?";
						Main.buffName[56] = "Pet Alberello";
						Main.buffTip[56] = "Un piccolo alberello ti sta seguendo";
						Main.buffName[57] = "Wisp";
						Main.buffTip[57] = "Un filo ti sta seguendo";
						Main.buffName[58] = "rapida guarigione";
						Main.buffTip[58] = "Vita rigenerazione è notevolmente aumentato";
						Main.buffName[59] = "ombra Dodge";
						Main.buffTip[59] = "Potrai schivare il prossimo attacco";
						Main.buffName[60] = "foglia di cristallo";
						Main.buffTip[60] = "Lascia cristallo spara a nemici nelle vicinanze";
						Main.buffName[61] = "cucciolo di dinosauro";
						Main.buffTip[61] = "Un dinosauro bambino ti sta seguendo";
						Main.buffName[62] = "Barriera di Ghiaccio";
						Main.buffTip[62] = "La difesa è aumentata del 30";
						Main.buffName[63] = "panico!";
						Main.buffTip[63] = "Velocità di movimento è aumentata";
						Main.buffName[64] = "bambino Slime";
						Main.buffTip[64] = "Il bambino melma combatterà per voi";
						Main.buffName[65] = "Eyeball Primavera";
						Main.buffTip[65] = "Una molla bulbo oculare ti sta seguendo";
						Main.buffName[66] = "bambino Snowman";
						Main.buffTip[66] = "Un pupazzo di neve bambino ti sta seguendo";
						Main.buffName[67] = "Masterizzazione";
						Main.buffTip[67] = "Perdere la vita e rallentato il movimento";
						Main.buffName[68] = "soffocamento";
						Main.buffTip[68] = "perdere la vita";
						Main.buffName[69] = "Ichor";
						Main.buffTip[69] = "difesa ridotto";
						Main.buffName[70] = "Venom";
						Main.buffTip[70] = "perdere la vita";
						Main.buffName[72] = "Midas";
						Main.buffTip[72] = "Goccia più soldi sulla morte";
						Main.buffName[80] = "Blackout";
						Main.buffTip[80] = "Vision Light notevolmente ridotta";
						Main.buffName[71] = "Arma Imbue: veleno";
						Main.buffTip[71] = "Attacchi in mischia infliggono veleno sui tuoi obiettivi";
						Main.buffName[73] = "Arma Imbue: Fiamme Cursed";
						Main.buffTip[73] = "Attacchi in mischia infliggono nemici con fiamme maledette";
						Main.buffName[74] = "Arma Imbue: Fuoco";
						Main.buffTip[74] = "Attacchi corpo a corpo impostati nemici in fiamme";
						Main.buffName[75] = "Arma Imbue: Gold";
						Main.buffTip[75] = "Attacchi corpo a corpo i nemici fanno cadere più oro";
						Main.buffName[76] = "Arma Imbue: Ichor";
						Main.buffTip[76] = "Attacchi corpo a corpo diminuiscono nemici difesa";
						Main.buffName[77] = "Arma Imbue: Nanites";
						Main.buffTip[77] = "Attacchi corpo a corpo confondono i nemici";
						Main.buffName[78] = "Arma Imbue: Confetti";
						Main.buffTip[78] = "Attacchi corpo a corpo causano a comparire coriandoli";
						Main.buffName[79] = "Arma Imbue: Poison";
						Main.buffTip[79] = "Mischia attacca nemici veleno";
						Main.tileName[13] = "Bottiglia";
						Main.tileName[14] = "Tavolo";
						Main.tileName[15] = "Sedia";
						Main.tileName[16] = "Incudine";
						Main.tileName[17] = "Forno";
						Main.tileName[18] = "Banco di lavoro";
						Main.tileName[26] = "Demone altare";
						Main.tileName[77] = "Creazione degli inferi";
						Main.tileName[86] = "Telaio";
						Main.tileName[94] = "Barilotto";
						Main.tileName[96] = "Pentola";
						Main.tileName[101] = "Scaffale";
						Main.tileName[106] = "Segheria";
						Main.tileName[114] = "Laboratorio dell'inventore";
						Main.tileName[133] = "Fornace di adamantio";
						Main.tileName[134] = "Incudine di mitrilio";
					}
					else
					{
						if (Lang.lang == 4)
						{
							Lang.misc[0] = "L'armée des gobelins a été vaincue.";
							Lang.misc[1] = "Une armée de gobelins approche par l'ouest.";
							Lang.misc[2] = "Une armée de gobelins approche par l'est.";
							Lang.misc[3] = "Une armée gobelin est arrivé!";
							Lang.misc[4] = "La Légion Frost a été vaincu!";
							Lang.misc[5] = "La Légion Frost est venant de l'ouest!";
							Lang.misc[6] = "La Légion Frost est l'approche de l'Est!";
							Lang.misc[7] = "La Légion gel est arrivé!";
							Lang.misc[8] = "La lune de sang se lève...";
							Lang.misc[9] = "Vous sentez une présence maléfique vous observer.";
							Lang.misc[10] = "Un frisson vous parcourt le dos...";
							Lang.misc[11] = "Des cris retentissent autour de vous...";
							Lang.misc[12] = "Votre monde a la chance de profiter de ressources de cobalt.";
							Lang.misc[13] = "Votre monde a la chance de profiter de ressources de mythril.";
							Lang.misc[14] = "Votre monde a la chance de profiter de ressources d'adamantine.";
							Lang.misc[15] = "Les anciens esprits de l'ombre et de la lumière ont été relâchés.";
							Lang.misc[16] = "est réveillé.";
							Lang.misc[17] = "a été vaincue.";
							Lang.misc[18] = "est arrivée.";
							Lang.misc[19] = " s'est fait éviscérer...";
							Lang.misc[20] = "Une éclipse solaire se produit!";
							Lang.misc[21] = "Votre monde a été béni avec Palladium!";
							Lang.misc[22] = "Votre monde a été béni avec orichalque!";
							Lang.misc[23] = "Votre monde a été béni avec Titanium!";
							Lang.misc[24] = "Les pirates ont été vaincus!";
							Lang.misc[25] = "Les pirates venant de l'ouest!";
							Lang.misc[26] = "Pirates se rapprochent de l'Est!";
							Lang.misc[27] = "Les pirates sont arrivés!";
							Lang.misc[28] = "Vous vous sentez des vibrations du plus profond ci-dessous ...";
							Lang.misc[29] = "Cela va être une nuit terrible ...";
							Lang.misc[30] = "L'air se refroidit autour de vous ...";
							Lang.menu[0] = "Démarrez une nouvelle instance de Terraria pour rejoindre une partie.";
							Lang.menu[1] = "Fonctionne sur le port ";
							Lang.menu[2] = "Déconnexion";
							Lang.menu[3] = "Le serveur requiert un mot de passe :";
							Lang.menu[4] = "Accepter";
							Lang.menu[5] = "Retour";
							Lang.menu[6] = "Annuler";
							Lang.menu[7] = "Entrer le mot de passe :";
							Lang.menu[8] = "Lancement du serveur...";
							Lang.menu[9] = "Le chargement a échoué.";
							Lang.menu[10] = "Charger une sauvegarde";
							Lang.menu[11] = "Aucune sauvegarde trouvée";
							Lang.menu[12] = "Un joueur";
							Lang.menu[13] = "Multijoueur";
							Lang.menu[14] = "Réglages";
							Lang.menu[15] = "Quitter";
							Lang.menu[16] = "Créer un personnage";
							Lang.menu[17] = "Supprimer";
							Lang.menu[18] = "Cheveux";
							Lang.menu[19] = "Yeux";
							Lang.menu[20] = "Peau";
							Lang.menu[21] = "Vêtements";
							Lang.menu[22] = "Homme";
							Lang.menu[23] = "Femme";
							Lang.menu[24] = "Difficile";
							Lang.menu[25] = "Normal";
							Lang.menu[26] = "Facile";
							Lang.menu[27] = "Aléatoire";
							Lang.menu[28] = "Créer";
							Lang.menu[29] = "En cas de mort dans le mode Difficile, le personnage est tout simplement supprimé";
							Lang.menu[30] = "En cas de mort dans le mode Normal, les personnages laissent échapper des objets en mourant";
							Lang.menu[31] = "Les personnages en mode facile laissent échapper de l'argent en mourant.";
							Lang.menu[32] = "Choisir la difficulté";
							Lang.menu[33] = "Chemise";
							Lang.menu[34] = "Maillot de corps";
							Lang.menu[35] = "Pantalon";
							Lang.menu[36] = "Chaussures";
							Lang.menu[37] = "Cheveux";
							Lang.menu[38] = "Couleur des cheveux";
							Lang.menu[39] = "Couleur des yeux";
							Lang.menu[40] = "Couleur de peau";
							Lang.menu[41] = "Couleur de chemise";
							Lang.menu[42] = "Couleur de maillot de corps";
							Lang.menu[43] = "Couleur de pantalon";
							Lang.menu[44] = "Couelur des chaussures";
							Lang.menu[45] = "Saisir le nom du personnage :";
							Lang.menu[46] = "Supprimer";
							Lang.menu[47] = "Créer un monde";
							Lang.menu[48] = "Saisir un nom de monde :";
							Lang.menu[49] = "Mode fenêtré";
							Lang.menu[50] = "Mode Plein écran";
							Lang.menu[51] = "Résolution";
							Lang.menu[52] = "Parallax";
							Lang.menu[53] = "Frame Skip activé (non recommandé)";
							Lang.menu[54] = "Frame Skip désactivé (recommandé)";
							Lang.menu[55] = "Lumière : couleur";
							Lang.menu[56] = "Lumière : blanche";
							Lang.menu[57] = "Lumière : rétro";
							Lang.menu[58] = "Lumière : psyché";
							Lang.menu[59] = "Qualité : auto";
							Lang.menu[60] = "Qualité : haute";
							Lang.menu[61] = "Qualité : moyenne";
							Lang.menu[62] = "Qualité : basse";
							Lang.menu[63] = "Vidéo";
							Lang.menu[64] = "Curseur chromatique";
							Lang.menu[65] = "Volume";
							Lang.menu[66] = "Contrôles";
							Lang.menu[67] = "Sauvegarde auto activée";
							Lang.menu[68] = "Sauvegarde auto désactivée";
							Lang.menu[69] = "Pause auto activée";
							Lang.menu[70] = "Pause auto désactivée";
							Lang.menu[71] = "Affichage du texte activé";
							Lang.menu[72] = "Affichage du texte désactivé";
							Lang.menu[73] = "Résolution Plein écran";
							Lang.menu[74] = "Haut              ";
							Lang.menu[75] = "Bas               ";
							Lang.menu[76] = "Gauche           ";
							Lang.menu[77] = "Droite             ";
							Lang.menu[78] = "Sauter            ";
							Lang.menu[79] = "Lancer            ";
							Lang.menu[80] = "Inventaire        ";
							Lang.menu[81] = "Soin rapide      ";
							Lang.menu[82] = "Mana rapide     ";
							Lang.menu[83] = "Buff rapide      ";
							Lang.menu[84] = "Agripper          ";
							Lang.menu[85] = "Sélection auto    ";
							Lang.menu[86] = "Réglages par défaut";
							Lang.menu[87] = "Rejoindre";
							Lang.menu[88] = "Héberger et jouer";
							Lang.menu[89] = "Entrer l'adresse IP du serveur :";
							Lang.menu[90] = "Entrer le port du serveur :";
							Lang.menu[91] = "Choisir la taille du monde :";
							Lang.menu[92] = "Petit";
							Lang.menu[93] = "Moyen";
							Lang.menu[94] = "Grand";
							Lang.menu[95] = "Rouge :";
							Lang.menu[96] = "Vert :";
							Lang.menu[97] = "Bleu :";
							Lang.menu[98] = "Son :";
							Lang.menu[99] = "Musique :";
							Lang.menu[100] = "De fond sur";
							Lang.menu[101] = "De fond au large";
							Lang.menu[102] = "Sélectionnez la langue";
							Lang.menu[103] = "Langue";
							Lang.menu[104] = "Oui";
							Lang.menu[105] = "Pas";
							Lang.menu[106] = "Basculer Carte de style";
							Lang.menu[107] = "basculer Plein écran";
							Lang.menu[108] = "Zoom";
							Lang.menu[109] = "Zoom arrière";
							Lang.menu[110] = "Diminution de la transparence";
							Lang.menu[111] = "augmenter la transparence";
							Lang.menu[112] = "carte Activé";
							Lang.menu[113] = "carte handicapés";
							Lang.gen[0] = "Création du terrain :";
							Lang.gen[1] = "Ajout de sable...";
							Lang.gen[2] = "Création des collines...";
							Lang.gen[3] = "Placement de la boue derrière la boue :";
							Lang.gen[4] = "Placement des rochers dans la boue...";
							Lang.gen[5] = "Placement de boue dans les rochers...";
							Lang.gen[6] = "Ajout d'argile...";
							Lang.gen[7] = "Création de trous aléatoires :";
							Lang.gen[8] = "Création de petites cavernes :";
							Lang.gen[9] = "Création de grandes cavernes :";
							Lang.gen[10] = "Création des cavernes en surface...";
							Lang.gen[11] = "Création de jungle :";
							Lang.gen[12] = "Création d'îles flottantes...";
							Lang.gen[13] = "Ajout des patchs de champignon...";
							Lang.gen[14] = "Placement de la terre dans la boue...";
							Lang.gen[15] = "Ajout de limon...";
							Lang.gen[16] = "Ajout des brillances...";
							Lang.gen[17] = "Ajout de toiles d'araignées...";
							Lang.gen[18] = "Création du monde inférieur :";
							Lang.gen[19] = "Ajout d'étendues d'eau :";
							Lang.gen[20] = "Corruption du monde :";
							Lang.gen[21] = "Création de cavernes montagneuses...";
							Lang.gen[22] = "Création de plages...";
							Lang.gen[23] = "Ajout de gemmes...";
							Lang.gen[24] = "Gravitation du sable :";
							Lang.gen[25] = "Nettoyage d'arrière-plans de boue :";
							Lang.gen[26] = "Placement d'autels :";
							Lang.gen[27] = "Clarification de l'eau :";
							Lang.gen[28] = "Placement de cristaux de vie :";
							Lang.gen[29] = "Placement de statues :";
							Lang.gen[30] = "Dissimulation de trésor :";
							Lang.gen[31] = "Dissimulation de trésor supplémentaire :";
							Lang.gen[32] = "Dissimulation de trésor de jungle :";
							Lang.gen[33] = "Dissimulation de trésor dans l'eau :";
							Lang.gen[34] = "Placement de pièges :";
							Lang.gen[35] = "Placement d'objets cassables :";
							Lang.gen[36] = "Placement de forges infernales :";
							Lang.gen[37] = "Placement de l'herbe :";
							Lang.gen[38] = "Faire pousser des cactus...";
							Lang.gen[39] = "Plantation de tournesols...";
							Lang.gen[40] = "Plantation d'arbres...";
							Lang.gen[41] = "Plantation d'herbe...";
							Lang.gen[42] = "Plantation de mauvaises herbes...";
							Lang.gen[43] = "Faire pousser des vignes...";
							Lang.gen[44] = "Plantation de fleurs...";
							Lang.gen[45] = "Plantation de champignons...";
							Lang.gen[46] = "Libération des ressources inutilisées :";
							Lang.gen[47] = "Réinitialisation des objets du jeu :";
							Lang.gen[48] = "Réglage du mode difficile...";
							Lang.gen[49] = "Sauvegarde des données du monde :";
							Lang.gen[50] = "Sauvegarde du fichier du monde...";
							Lang.gen[51] = "Chargement des données du monde :";
							Lang.gen[52] = "Vérification de l'alignement de blocs :";
							Lang.gen[53] = "Le chargement a échoué.";
							Lang.gen[54] = "Aucune sauvegarde trouvée.";
							Lang.gen[55] = "Trouver les images de blocs :";
							Lang.gen[56] = "Ajout de la neige ...";
							Lang.gen[57] = "Mondiale";
							Lang.gen[58] = "Créer donjon:";
							Lang.gen[59] = "Une météorite a atterri!";
							Lang.gen[60] = "Lissage du monde:";
							Lang.gen[61] = "Mossification:";
							Lang.gen[62] = "Gemification:";
							Lang.gen[63] = "Faire parois de la grotte:";
							Lang.gen[64] = "Growing grottes d'araignée:";
							Lang.gen[65] = "Clearing données cartographiques:";
							Lang.gen[66] = "Sauvegarde des données de la carte:";
							Lang.gen[67] = "Chargement des données cartographiques:";
							Lang.gen[68] = "dessin carte:";
							Lang.gen[69] = "créer des cascades:";
							Lang.gen[70] = "Création ruines dans la jungle...";
							Lang.gen[71] = "Création de nids de frelons...";
							Lang.gen[72] = "Faire la sanglante monde:";
							Lang.inter[0] = "Vie :";
							Lang.inter[1] = "Souffle ";
							Lang.inter[2] = "Mana :";
							Lang.inter[3] = "Poubelle";
							Lang.inter[4] = "Inventaire";
							Lang.inter[5] = "Barre d'inventaire déverrouillée";
							Lang.inter[6] = "Barre d'inventaire verrouillée";
							Lang.inter[7] = "Logement";
							Lang.inter[8] = "Demande de logement";
							Lang.inter[9] = "Accessoires";
							Lang.inter[10] = "Défense";
							Lang.inter[11] = "Social";
							Lang.inter[12] = "Casque";
							Lang.inter[13] = "Chemise";
							Lang.inter[14] = "Pantalon";
							Lang.inter[15] = "Platine";
							Lang.inter[16] = "Or";
							Lang.inter[17] = "Argent";
							Lang.inter[18] = "Cuivre";
							Lang.inter[19] = "Reforger";
							Lang.inter[20] = "Placer un objet ici pour le reforger";
							Lang.inter[21] = "Affichage des techniques utilisant";
							Lang.inter[22] = "Objets requis :";
							Lang.inter[23] = "Aucun";
							Lang.inter[24] = "Placer un matériau ici pour afficher les techniques";
							Lang.inter[25] = "Artisanat";
							Lang.inter[26] = "Pièces";
							Lang.inter[27] = "Munitions";
							Lang.inter[28] = "Magasin";
							Lang.inter[29] = "Tout récupérer";
							Lang.inter[30] = "Tout déposer";
							Lang.inter[31] = "Pile rapide";
							Lang.inter[32] = "Tirelire";
							Lang.inter[33] = "Coffre-fort";
							Lang.inter[34] = "Temps :";
							Lang.inter[35] = "Sauvegarder et quitter";
							Lang.inter[36] = "Déconnexion";
							Lang.inter[37] = "Objets";
							Lang.inter[38] = "Vous vous êtes fait exterminer...";
							Lang.inter[39] = "Ce logement convient.";
							Lang.inter[40] = "Ce logement ne convient pas.";
							Lang.inter[41] = "Ce logement est déjà occupé.";
							Lang.inter[42] = "Ce logement est corrompu.";
							Lang.inter[43] = "La connexion a été interrompue";
							Lang.inter[44] = "Réception de données de blocs";
							Lang.inter[45] = "équiper";
							Lang.inter[46] = "Coût";
							Lang.inter[47] = "Enregistrer";
							Lang.inter[48] = "Modifier";
							Lang.inter[49] = "État";
							Lang.inter[50] = "Malédiction";
							Lang.inter[51] = "Aide";
							Lang.inter[52] = "Proches";
							Lang.inter[53] = "De l'eau";
							Lang.inter[54] = "Guérir";
							Lang.inter[55] = "Ce logement ne répond pas aux exigences d'un";
							Lang.inter[56] = "Lave";
							Lang.inter[57] = "teindre";
							Lang.inter[58] = "chérie";
							Lang.tip[0] = "Équipé dans l'emplacement social";
							Lang.tip[1] = "Ne procure pas de stats";
							Lang.tip[2] = " de dégâts de mêlée";
							Lang.tip[3] = " de dégâts à distance";
							Lang.tip[4] = " de dégâts de magie";
							Lang.tip[5] = "% de chance de coup critique";
							Lang.tip[6] = "Vitesse insensée";
							Lang.tip[7] = "Vitesse très rapide";
							Lang.tip[8] = "Vitesse rapide";
							Lang.tip[9] = "Vitesse moyenne";
							Lang.tip[10] = "Vitesse lente";
							Lang.tip[11] = "Vitesse très lente";
							Lang.tip[12] = "Vitesse extrêmement lente";
							Lang.tip[13] = "Vitesse d'escargot";
							Lang.tip[14] = "Pas de recul";
							Lang.tip[15] = "Recul extrêmement faible";
							Lang.tip[16] = "Recul très faible";
							Lang.tip[17] = "Recul faible";
							Lang.tip[18] = "Recul moyen";
							Lang.tip[19] = "Fort recul";
							Lang.tip[20] = "Très fort recul";
							Lang.tip[21] = "Recul extrêmement fort";
							Lang.tip[22] = "Recul ahurissant";
							Lang.tip[23] = "Équipable";
							Lang.tip[24] = "Objets sociaux";
							Lang.tip[25] = " de défense";
							Lang.tip[26] = "% de puissance de pioche";
							Lang.tip[27] = "% de puissance de hache";
							Lang.tip[28] = "% de puissance de marteau";
							Lang.tip[29] = "Redonne";
							Lang.tip[30] = "de vie";
							Lang.tip[31] = "de mana";
							Lang.tip[32] = "Consomme";
							Lang.tip[33] = "Peut être placé";
							Lang.tip[34] = "Munitions";
							Lang.tip[35] = "Consommable";
							Lang.tip[36] = "Matériau";
							Lang.tip[37] = " Durée minute";
							Lang.tip[38] = " Durée seconde";
							Lang.tip[39] = "% de dégâts";
							Lang.tip[40] = "% de vélocité";
							Lang.tip[41] = "% de chance de coup critique";
							Lang.tip[42] = "% de coût de mana";
							Lang.tip[43] = "% de la taille";
							Lang.tip[44] = "% de vitesse de projectile";
							Lang.tip[45] = "% de recul";
							Lang.tip[46] = "% de vitesse de déplacement";
							Lang.tip[47] = "% de vitesse de mêlée";
							Lang.tip[48] = "Bonus de collection :";
							Lang.tip[49] = "Prix de vente :";
							Lang.tip[50] = "Prix d'achat :";
							Lang.tip[51] = "Aucune valeur";
							Lang.tip[52] = "consomme ";
							Lang.tip[53] = " convoquer des dommages";
							Lang.tip[54] = " gamme";
							Lang.tip[55] = " dommage";
							Lang.mp[0] = "Recevoir :";
							Lang.mp[1] = "Mot de passe incorrect.";
							Lang.mp[2] = "Opération non valable en l'état.";
							Lang.mp[3] = "Vous vous êtes fait bannir de ce serveur.";
							Lang.mp[4] = "Vous n'utilisez pas la même version que ce serveur.";
							Lang.mp[5] = "est déjà sur ce serveur.";
							Lang.mp[6] = "/en train de jouer";
							Lang.mp[7] = "Joueurs actuels :";
							Lang.mp[8] = "/jet";
							Lang.mp[9] = "lance un";
							Lang.mp[10] = "Vous n'êtes pas dans une équipe.";
							Lang.mp[11] = "a activé le PvP.";
							Lang.mp[12] = "a désactivé le PvP.";
							Lang.mp[13] = "n'est plus dans une équipe.";
							Lang.mp[14] = "a rejoint l'équipe rouge.";
							Lang.mp[15] = "a rejoint l'équipe verte.";
							Lang.mp[16] = "a rejoint l'équipe bleue.";
							Lang.mp[17] = "a rejoint l'équipe jaune.";
							Lang.mp[18] = "Bienvenue dans";
							Lang.mp[19] = "a rejoint.";
							Lang.mp[20] = "a quitté.";
							Lang.the = "le ";
							Lang.dt[0] = "n'a pas trouvé l'antidote";
							Lang.dt[1] = "n'a pas réussi à éteindre l'incendie";
							Main.buffName[1] = "Peau d'obsidienne";
							Main.buffTip[1] = "Immunise contre la lave";
							Main.buffName[2] = "Régénération";
							Main.buffTip[2] = "Régénère la vie";
							Main.buffName[3] = "Rapidité";
							Main.buffTip[3] = "Augmente la vitesse de déplacement de 25 %";
							Main.buffName[4] = "Branchies";
							Main.buffTip[4] = "Permet de respirer sous l'eau comme dans l'air";
							Main.buffName[5] = "Peau de fer";
							Main.buffTip[5] = "Augmente la défense de 8";
							Main.buffName[6] = "Régénération de mana";
							Main.buffTip[6] = "Augmente la régénération de mana";
							Main.buffName[7] = "Pouvoir magique";
							Main.buffTip[7] = "Augmente les dégâts de magie de 20 %";
							Main.buffName[8] = "Poids plume";
							Main.buffTip[8] = "Appuyer sur Bas ou Haut pour contrôler la vitesse de descente";
							Main.buffName[9] = "Spéléologue";
							Main.buffTip[9] = "Indique l'emplacement des trésors et du minerai";
							Main.buffName[10] = "Invisibilité";
							Main.buffTip[10] = "Procure l'invisibilité";
							Main.buffName[11] = "Brillance";
							Main.buffTip[11] = "Emet une aura de lumière";
							Main.buffName[12] = "Vision nocturne";
							Main.buffTip[12] = "Améliore la vision de nuit";
							Main.buffName[13] = "Bataille";
							Main.buffTip[13] = "Augmente la vitesse d'apparition des ennemis";
							Main.buffName[14] = "Épines";
							Main.buffTip[14] = "Les attaquants subissent aussi des dégâts";
							Main.buffName[15] = "Marche sur l'eau";
							Main.buffTip[15] = "Appuyer sur Bas pour entrer dans l'eau";
							Main.buffName[16] = "Tir à l'arc";
							Main.buffTip[16] = "La vitesse et les dégâts des flèches augmentent de 20 %";
							Main.buffName[17] = "Chasseur";
							Main.buffTip[17] = "Indique l'emplacement des ennemis";
							Main.buffName[18] = "Gravitation";
							Main.buffTip[18] = "Appuyer sur Haut ou Bas pour inverser la gravité";
							Main.buffName[19] = "Orbe de lumière";
							Main.buffTip[19] = "Un orbe magique qui émet de la lumière";
							Main.buffName[20] = "Empoisonnement";
							Main.buffTip[20] = "Perte lente de vie";
							Main.buffName[21] = "Nausée des potions";
							Main.buffTip[21] = "Ne peut plus consommer de potions de soin";
							Main.buffName[22] = "Obscurité";
							Main.buffTip[22] = "Diminue la vision de nuit";
							Main.buffName[23] = "Malédiction";
							Main.buffTip[23] = "Ne peut utiliser aucun objet";
							Main.buffName[24] = "En feu !";
							Main.buffTip[24] = "Perte lente de vie";
							Main.buffName[25] = "Ivresse";
							Main.buffTip[25] = "Augmente les aptitudes de mêlée, diminue la défense";
							Main.buffName[26] = "Bien nourri";
							Main.buffTip[26] = "Amélioration mineure de toutes les stats.";
							Main.buffName[27] = "Fée";
							Main.buffTip[27] = "Une fée vous suit";
							Main.buffName[28] = "Loup-garou";
							Main.buffTip[28] = "Les aptitudes physiques sont augmentées";
							Main.buffName[29] = "Clairvoyance";
							Main.buffTip[29] = "Les pouvoirs magiques sont augmentés";
							Main.buffName[30] = "Saignement";
							Main.buffTip[30] = "Ne peut régénérer la vie";
							Main.buffName[31] = "Confusion";
							Main.buffTip[31] = "Les mouvements sont inversés";
							Main.buffName[32] = "Ralentissement";
							Main.buffTip[32] = "La vitesse de déplacement est réduite";
							Main.buffName[33] = "Faiblesse";
							Main.buffTip[33] = "Les aptitudes physiques sont diminuées";
							Main.buffName[34] = "Peuple des mers";
							Main.buffTip[34] = "Peut respirer et se déplacer sous l'eau facilement";
							Main.buffName[35] = "Silencieux";
							Main.buffTip[35] = "Ne peut pas utiliser des éléments qui nécessitent de mana";
							Main.buffName[36] = "Armure brisée";
							Main.buffTip[36] = "La défense est réduite de moitié";
							Main.buffName[37] = "Peur panique";
							Main.buffTip[37] = "Vous avez vu quelque chose de terrible et vous ne pouvez vous échapper.";
							Main.buffName[38] = "La langue";
							Main.buffTip[38] = "Vous vous êtes fait aspirer dans la bouche";
							Main.buffName[39] = "Brasier maudit";
							Main.buffTip[39] = "Perte de vie";
							Main.buffName[40] = "Animal lapin";
							Main.buffTip[40] = "Je pense qu'il veut votre carotte";
							Main.buffName[41] = "bébé pingouin";
							Main.buffTip[41] = "Je pense qu'il veut votre poisson";
							Main.buffName[42] = "Animaux tortue";
							Main.buffTip[42] = "Temps de tortue heureuse!";
							Main.buffName[43] = "Bouclier de Paladin";
							Main.buffTip[43] = "25% des dégâts subis sera redirigé vers un autre joueur";
							Main.buffName[44] = "gel brûlure";
							Main.buffTip[44] = "C'est soit très chaud ou très froid. De toute façon ça fait vraiment mal";
							Main.buffName[45] = "Bébé Eater";
							Main.buffTip[45] = "Un bébé Eater of Souls vous suit";
							Main.buffName[46] = "réfrigéré";
							Main.buffTip[46] = "Votre vitesse de déplacement a été réduite";
							Main.buffName[47] = "congelé";
							Main.buffTip[47] = "Vous ne pouvez pas déplacer!";
							Main.buffName[48] = "chérie";
							Main.buffTip[48] = "Régénération de vie est augmentée";
							Main.buffName[49] = "Pygmées";
							Main.buffTip[49] = "Les pygmées se battront pour vous";
							Main.buffName[50] = "Bébé Skeletron Head";
							Main.buffTip[50] = "Ne demandent même pas ...";
							Main.buffName[51] = "Bébé Hornet";
							Main.buffTip[51] = "Il pense que vous êtes sa mère";
							Main.buffName[52] = "tiki esprit";
							Main.buffTip[52] = "Un esprit convivial vous suit";
							Main.buffName[53] = "lézard de compagnie";
							Main.buffTip[53] = "Chillin 'comme un reptile";
							Main.buffName[54] = "perroquet";
							Main.buffTip[54] = "Polly veulent du pirate";
							Main.buffName[55] = "Bébé Truffe";
							Main.buffTip[55] = "N'est-ce pas juste si mignon?";
							Main.buffName[56] = "Pet Arbrisseau";
							Main.buffTip[56] = "Un petit arbre vous suit";
							Main.buffName[57] = "Wisp";
							Main.buffTip[57] = "Un brin vous suit";
							Main.buffName[58] = "guérison rapide";
							Main.buffTip[58] = "Régénération de vie est considérablement augmentée";
							Main.buffName[59] = "Dodge Shadow";
							Main.buffTip[59] = "Vous pourrez esquiver la prochaine attaque";
							Main.buffName[60] = "cristal Feuille";
							Main.buffTip[60] = "Cristal Lance laisse les ennemis proches";
							Main.buffName[61] = "bébé dinosaure";
							Main.buffTip[61] = "Un dinosaure de bébé vous suit";
							Main.buffName[62] = "Barrière de glace";
							Main.buffTip[62] = "La défense est augmentée de 30";
							Main.buffName[63] = "Panic!";
							Main.buffTip[63] = "La vitesse de déplacement est augmentée";
							Main.buffName[64] = "Bébé Slime";
							Main.buffTip[64] = "Le bébé bave combattra pour vous";
							Main.buffName[65] = "Printemps de globe oculaire";
							Main.buffTip[65] = "Un ressort d'œil vous suit";
							Main.buffName[66] = "Bébé de bonhomme de neige";
							Main.buffTip[66] = "Un bonhomme de neige de bébé vous suit";
							Main.buffName[67] = "brûler";
							Main.buffTip[67] = "Perdre la vie et ralenti le mouvement";
							Main.buffName[68] = "étouffement";
							Main.buffTip[68] = "perdre la vie";
							Main.buffName[69] = "Ichor";
							Main.buffTip[69] = "défense réduite";
							Main.buffName[70] = "Venom";
							Main.buffTip[70] = "perdre la vie";
							Main.buffName[72] = "Midas";
							Main.buffTip[72] = "Déposer plus d'argent sur la mort";
							Main.buffName[80] = "Blackout";
							Main.buffTip[80] = "Vision lumière fortement réduite";
							Main.buffName[71] = "Weapon Imbue: Venom";
							Main.buffTip[71] = "Les attaques de mêlée infligent venin sur vos cibles";
							Main.buffName[73] = "Arme Imbue: Venom";
							Main.buffTip[73] = "Les attaques de mêlée infligent des ennemis avec des flammes maudits";
							Main.buffName[74] = "Arme Imbue: Fire";
							Main.buffTip[74] = "Les attaques de mêlée des ennemis mis le feu";
							Main.buffName[75] = "Arme Imbue: Gold";
							Main.buffTip[75] = "Les attaques de mêlée rendent ennemis laissent tomber plus d'or";
							Main.buffName[76] = "Arme Imbue: Ichor";
							Main.buffTip[76] = "Les attaques de mêlée réduire la défense des ennemis";
							Main.buffName[77] = "Arme Imbue: Nanites";
							Main.buffTip[77] = "Les attaques de mêlée confondent ennemis";
							Main.buffName[78] = "Arme Imbue: Confetti";
							Main.buffTip[78] = "Les attaques de mêlée causent des confettis à comparaître";
							Main.buffName[79] = "Arme Imbue: Poison";
							Main.buffTip[79] = "Attaques de mêlée des ennemis de poison";
							Main.tileName[13] = "Bouteille";
							Main.tileName[14] = "Table";
							Main.tileName[15] = "Président";
							Main.tileName[16] = "Enclume";
							Main.tileName[17] = "Four";
							Main.tileName[18] = "Établi";
							Main.tileName[26] = "Autel démon";
							Main.tileName[77] = "Forge infernale";
							Main.tileName[86] = "Métier à tisser";
							Main.tileName[94] = "Tonnelet";
							Main.tileName[96] = "Marmite";
							Main.tileName[101] = "Bibliothèque";
							Main.tileName[106] = "Scierie";
							Main.tileName[114] = "Atelier du bricoleur";
							Main.tileName[133] = "Forge en adamantine";
							Main.tileName[134] = "Enclume en mythril";
						}
						else
						{
							if (Lang.lang == 5)
							{
								Lang.misc[0] = "¡El ejército de duendes ha sido derrotado!";
								Lang.misc[1] = "¡Un ejército de duendes se aproxima por el oeste!";
								Lang.misc[2] = "¡Un ejército de duendes se aproxima por el este!";
								Lang.misc[3] = "Un ejército goblin ha llegado!";
								Lang.misc[4] = "La Legión Frost ha sido derrotado!";
								Lang.misc[5] = "La Legión de Frost se aproxima desde el oeste!";
								Lang.misc[6] = "La Legión de Frost se acercaba desde el este!";
								Lang.misc[7] = "La Legión Frost ha llegado!";
								Lang.misc[8] = "La luna sangrienta está saliendo...";
								Lang.misc[9] = "Sientes que una presencia maligna te observa...";
								Lang.misc[10] = "Sientes un horrible escalofrío por la espalda...";
								Lang.misc[11] = "El eco de los alaridos suena por todas partes...";
								Lang.misc[12] = "¡Tu mundo ha sido bendecido con Cobalto!";
								Lang.misc[13] = "¡Tu mundo ha sido bendecido con Mithril!";
								Lang.misc[14] = "¡Tu mundo ha sido bendecido con Adamantita!";
								Lang.misc[15] = "Los ancestrales espíritus de la luz y la oscuridad han sido liberados.";
								Lang.misc[16] = "ha despertado!";
								Lang.misc[17] = "ha sido derrotado!";
								Lang.misc[18] = "de duendes!";
								Lang.misc[19] = " fue asesinado...";
								Lang.misc[20] = "Un eclipse solar ocurre!";
								Lang.misc[21] = "Su mundo ha sido bendecido con el Palladium!";
								Lang.misc[22] = "Su mundo ha sido bendecido con Orichalcum!";
								Lang.misc[23] = "Su mundo ha sido bendecido con Titanium!";
								Lang.misc[24] = "Los piratas han sido derrotados!";
								Lang.misc[25] = "Piratas se están acercando desde el oeste!";
								Lang.misc[26] = "Piratas se acercan desde el este!";
								Lang.misc[27] = "Los piratas han llegado!";
								Lang.misc[28] = "Sientes las vibraciones de las profundidades de ...";
								Lang.misc[29] = "Esto va a ser una noche terrible ...";
								Lang.misc[30] = "El aire es más frío a su alrededor ...";
								Lang.menu[0] = "¡Comienza y únete a un nuevo periodo de Terraria!";
								Lang.menu[1] = "Ejecutándose en el puerto ";
								Lang.menu[2] = "Desconectar";
								Lang.menu[3] = "Contraseña del servidor obligatoria:";
								Lang.menu[4] = "Aceptar";
								Lang.menu[5] = "Atrás";
								Lang.menu[6] = "Cancelar";
								Lang.menu[7] = "Escribir contraseña del servidor:";
								Lang.menu[8] = "Iniciando servidor...";
								Lang.menu[9] = "¡Error al cargar!";
								Lang.menu[10] = "Cargar copia de seguridad";
								Lang.menu[11] = "No hay copia de seguridad";
								Lang.menu[12] = "Un jugador";
								Lang.menu[13] = "Multijugador";
								Lang.menu[14] = "Ajustes";
								Lang.menu[15] = "Salir";
								Lang.menu[16] = "Crear personaje";
								Lang.menu[17] = "Eliminar";
								Lang.menu[18] = "Pelo";
								Lang.menu[19] = "Ojos";
								Lang.menu[20] = "Piel";
								Lang.menu[21] = "Ropa";
								Lang.menu[22] = "Hombre";
								Lang.menu[23] = "Mujer";
								Lang.menu[24] = "Fanático";
								Lang.menu[25] = "Normal";
								Lang.menu[26] = "Novato";
								Lang.menu[27] = "Aleatorio";
								Lang.menu[28] = "Crear";
								Lang.menu[29] = "Los personajes fanáticos mueren para siempre.";
								Lang.menu[30] = "Los personajes normales sueltan objetos al morir";
								Lang.menu[31] = "Los personajes novatos sueltan dinero al morir";
								Lang.menu[32] = "Seleccionar dificultad";
								Lang.menu[33] = "Camisa";
								Lang.menu[34] = "Camiseta";
								Lang.menu[35] = "Pantalones";
								Lang.menu[36] = "Zapatos";
								Lang.menu[37] = "Pelo";
								Lang.menu[38] = "Color de pelo";
								Lang.menu[39] = "Color de ojos";
								Lang.menu[40] = "Color de piel";
								Lang.menu[41] = "Color de la camisa";
								Lang.menu[42] = "Color de la camiseta";
								Lang.menu[43] = "Color de los pantalones";
								Lang.menu[44] = "Color de los zapatos";
								Lang.menu[45] = "Escribir nombre del personaje:";
								Lang.menu[46] = "Eliminar";
								Lang.menu[47] = "Crear mundo";
								Lang.menu[48] = "Escribir nombre del mundo:";
								Lang.menu[49] = "Ir a Pantalla con ventanas";
								Lang.menu[50] = "Ir a Pantalla completa";
								Lang.menu[51] = "Resolución";
								Lang.menu[52] = "Paralaje";
								Lang.menu[53] = "Saltar fotograma desactivado (no recomendado)";
								Lang.menu[54] = "Saltar fotograma activado (recomendado)";
								Lang.menu[55] = "Iluminación: Color";
								Lang.menu[56] = "Iluminación: Blanco";
								Lang.menu[57] = "Iluminación: Retro";
								Lang.menu[58] = "Iluminación: Psicodélica";
								Lang.menu[59] = "Calidad: Automático";
								Lang.menu[60] = "Calidad: Alta";
								Lang.menu[61] = "Calidad: Normal";
								Lang.menu[62] = "Calidad: Baja";
								Lang.menu[63] = "Vídeo";
								Lang.menu[64] = "Color del cursor";
								Lang.menu[65] = "Volumen";
								Lang.menu[66] = "Controles";
								Lang.menu[67] = "Autoguardado activado";
								Lang.menu[68] = "Autoguardado desactivado";
								Lang.menu[69] = "Pausa automática activada";
								Lang.menu[70] = "Pausa automática desactivada";
								Lang.menu[71] = "Sugerencias activadas";
								Lang.menu[72] = "Sugerencias desactivadas";
								Lang.menu[73] = "Resolución de pantalla completa";
								Lang.menu[74] = "Arriba                 ";
								Lang.menu[75] = "Abajo                  ";
								Lang.menu[76] = "Izquierda              ";
								Lang.menu[77] = "Derecha                ";
								Lang.menu[78] = "Saltar                  ";
								Lang.menu[79] = "Lanzar                 ";
								Lang.menu[80] = "Inventario              ";
								Lang.menu[81] = "Curación rápida       ";
								Lang.menu[82] = "Maná rápido           ";
								Lang.menu[83] = "Extra rápido           ";
								Lang.menu[84] = "Apresar                 ";
								Lang.menu[85] = "Selección automática  ";
								Lang.menu[86] = "Volver a predeterminados";
								Lang.menu[87] = "Unirse";
								Lang.menu[88] = "Crear y Jugar";
								Lang.menu[89] = "Escribir dirección IP del servidor:";
								Lang.menu[90] = "Escribir puerto del servidor:";
								Lang.menu[91] = "Elegir tamaño del mundo:";
								Lang.menu[92] = "Pequeño";
								Lang.menu[93] = "Mediano";
								Lang.menu[94] = "Grande";
								Lang.menu[95] = "Rojo:";
								Lang.menu[96] = "Verde:";
								Lang.menu[97] = "Azul:";
								Lang.menu[98] = "Sonido:";
								Lang.menu[99] = "Música:";
								Lang.menu[100] = "Fondo activado";
								Lang.menu[101] = "Fondo desactivado";
								Lang.menu[102] = "Seleccione el idioma";
								Lang.menu[103] = "Idioma";
								Lang.menu[104] = "Sí";
								Lang.menu[105] = "No";
								Lang.menu[106] = "Cambiar estilo del mapa";
								Lang.menu[107] = "Alternar pantalla completa";
								Lang.menu[108] = "Acercar";
								Lang.menu[109] = "Alejar";
								Lang.menu[110] = "Disminuir Transparencia";
								Lang.menu[111] = "Aumentar la Transparencia";
								Lang.menu[112] = "Mapa Activado";
								Lang.menu[113] = "Mapa Desactivado";
								Lang.gen[0] = "Generando terreno del mundo:";
								Lang.gen[1] = "Añadiendo arena...";
								Lang.gen[2] = "Generando colinas...";
								Lang.gen[3] = "Amontonando tierra:";
								Lang.gen[4] = "Añadiendo rocas a la tierra...";
								Lang.gen[5] = "Añadiendo tierra a las rocas...";
								Lang.gen[6] = "Añadiendo arcilla...";
								Lang.gen[7] = "Generando agujeros aleatorios:";
								Lang.gen[8] = "Generando cuevas pequeñas:";
								Lang.gen[9] = "Generando cuevas grandes:";
								Lang.gen[10] = "Generando superficie de cuevas...";
								Lang.gen[11] = "Generando selva:";
								Lang.gen[12] = "Generando islas flotantes...";
								Lang.gen[13] = "Añadiendo parcelas de champiñones...";
								Lang.gen[14] = "Añadiendo lodo a la tierra...";
								Lang.gen[15] = "Añadiendo cieno...";
								Lang.gen[16] = "Añadiendo brillos...";
								Lang.gen[17] = "Añadiendo telas de araña...";
								Lang.gen[18] = "Creando Inframundo:";
								Lang.gen[19] = "Añadiendo cursos de agua:";
								Lang.gen[20] = "Corrompiendo el mundo:";
								Lang.gen[21] = "Generando cuevas en montañas...";
								Lang.gen[22] = "Creando playas...";
								Lang.gen[23] = "Añadiendo gemas...";
								Lang.gen[24] = "Gravitando arena:";
								Lang.gen[25] = "Limpiando de tierra los entornos:";
								Lang.gen[26] = "Colocando altares:";
								Lang.gen[27] = "Distribuyendo líquidos:";
								Lang.gen[28] = "Colocando cristales de vida:";
								Lang.gen[29] = "Colocando estatuas:";
								Lang.gen[30] = "Ocultando tesoro:";
								Lang.gen[31] = "Ocultando otro tesoro:";
								Lang.gen[32] = "Ocultando tesoro en la selva:";
								Lang.gen[33] = "Ocultando tesoro en el agua:";
								Lang.gen[34] = "Colocando trampas:";
								Lang.gen[35] = "Colocando objetos quebradizos:";
								Lang.gen[36] = "Colocando forjas infernales:";
								Lang.gen[37] = "Plantando césped...";
								Lang.gen[38] = "Plantando cactus...";
								Lang.gen[39] = "Plantando girasoles...";
								Lang.gen[40] = "Plantando árboles...";
								Lang.gen[41] = "Plantando hierbas...";
								Lang.gen[42] = "Plantando hierbajos...";
								Lang.gen[43] = "Plantando enredaderas...";
								Lang.gen[44] = "Plantando flores...";
								Lang.gen[45] = "Cultivando champiñones...";
								Lang.gen[46] = "Liberando recursos sin usar:";
								Lang.gen[47] = "Reiniciando objetos del juego:";
								Lang.gen[48] = "Estableciendo modo difícil...";
								Lang.gen[49] = "Guardando datos del mundo:";
								Lang.gen[50] = "Copia de seguridad del archivo del mundo...";
								Lang.gen[51] = "Cargando datos del mundo:";
								Lang.gen[52] = "Comprobando alineación en cascada:";
								Lang.gen[53] = "¡Error al cargar!";
								Lang.gen[54] = "No hay copia de seguridad.";
								Lang.gen[55] = "Encontrando estructura en cascada:";
								Lang.gen[56] = "Adición de nieve ...";
								Lang.gen[57] = "Mundo";
								Lang.gen[58] = "La creación de mazmorra:";
								Lang.gen[59] = "Un meteorito ha caído!";
								Lang.gen[60] = "Suavizar el mundo:";
								Lang.gen[61] = "Mossification:";
								Lang.gen[62] = "Gemification:";
								Lang.gen[63] = "Haciendo paredes de la cueva:";
								Lang.gen[64] = "Crecimiento cuevas araña:";
								Lang.gen[65] = "Eliminación de los datos del mapa:";
								Lang.gen[66] = "Guardar los datos del mapa:";
								Lang.gen[67] = "Carga de datos de los mapas:";
								Lang.gen[68] = "Dibujo mapa:";
								Lang.gen[69] = "La creación de cascadas:";
								Lang.gen[70] = "Crear ruinas de la selva ...";
								Lang.gen[71] = "La creación de nidos de avispa ...";
								Lang.gen[72] = "Haciendo un mundo más sangrienta:";
								Lang.inter[0] = "Vida:";
								Lang.inter[1] = "Aire";
								Lang.inter[2] = "Maná";
								Lang.inter[3] = "Cubo de basura";
								Lang.inter[4] = "Inventario";
								Lang.inter[5] = "Barra de acceso rápido desbloqueada";
								Lang.inter[6] = "Barra de acceso rápido bloqueada";
								Lang.inter[7] = "Vivienda";
								Lang.inter[8] = "Búsqueda de vivienda";
								Lang.inter[9] = "Accesorios";
								Lang.inter[10] = "Defensa";
								Lang.inter[11] = "Social";
								Lang.inter[12] = "Casco";
								Lang.inter[13] = "Camisa";
								Lang.inter[14] = "Pantalones";
								Lang.inter[15] = "platino";
								Lang.inter[16] = "oro";
								Lang.inter[17] = "plata";
								Lang.inter[18] = "cobre";
								Lang.inter[19] = "Remodelar";
								Lang.inter[20] = "Colocar un objeto aquí para remodelarlo";
								Lang.inter[21] = "Mostrando recetas en uso";
								Lang.inter[22] = "Objetos necesarios:";
								Lang.inter[23] = "Ninguno";
								Lang.inter[24] = "Colocar un material aquí para ver las recetas";
								Lang.inter[25] = "Producción";
								Lang.inter[26] = "Monedas";
								Lang.inter[27] = "Munición";
								Lang.inter[28] = "Tienda";
								Lang.inter[29] = "Saquear todo";
								Lang.inter[30] = "Ahorrar todo";
								Lang.inter[31] = "Apilar rápido";
								Lang.inter[32] = "Hucha";
								Lang.inter[33] = "Caja fuerte";
								Lang.inter[34] = "Hora:";
								Lang.inter[35] = "Guarda y Salir";
								Lang.inter[36] = "Desconectar";
								Lang.inter[37] = "Objetos";
								Lang.inter[38] = "Te han asesinado...";
								Lang.inter[39] = "Esta vivienda es habitable.";
								Lang.inter[40] = "Esta vivienda no es habitable.";
								Lang.inter[41] = "Esta vivienda ya está ocupada.";
								Lang.inter[42] = "Esta vivienda está corrompida.";
								Lang.inter[43] = "Ha finalizado el tiempo de conexión";
								Lang.inter[44] = "Recibiendo datos en cascada";
								Lang.inter[45] = "Equipar";
								Lang.inter[46] = "Costo";
								Lang.inter[47] = "Ahorrar";
								Lang.inter[48] = "Editar";
								Lang.inter[49] = "Estado";
								Lang.inter[50] = "Maldición";
								Lang.inter[51] = "Ayuda";
								Lang.inter[52] = "Cerca";
								Lang.inter[53] = "De agua";
								Lang.inter[54] = "Sanar";
								Lang.inter[55] = "Esta vivienda no cumple con los requisitos para un";
								Lang.inter[56] = "Lava";
								Lang.inter[57] = "teñir";
								Lang.inter[58] = "miel";
								Lang.tip[0] = "Equipado en espacio social";
								Lang.tip[1] = "No se registrará ninguna estadística";
								Lang.tip[2] = " daño en el cuerpo a cuerpo";
								Lang.tip[3] = " daño a distancia";
								Lang.tip[4] = " daño por magia";
								Lang.tip[5] = "% probabilidad de ataque crítico";
								Lang.tip[6] = "Velocidad de vértigo";
								Lang.tip[7] = "A gran velocidad";
								Lang.tip[8] = "Deprisa";
								Lang.tip[9] = "Velocidad normal";
								Lang.tip[10] = "Despacio";
								Lang.tip[11] = "Muy despacio";
								Lang.tip[12] = "Exageradamente despacio";
								Lang.tip[13] = "Velocidad de tortuga";
								Lang.tip[14] = "Sin retroceso";
								Lang.tip[15] = "Retroceso sumamente débil";
								Lang.tip[16] = "Retroceso muy débil";
								Lang.tip[17] = "Retroceso débil";
								Lang.tip[18] = "Retroceso normal";
								Lang.tip[19] = "Retroceso fuerte";
								Lang.tip[20] = "Retroceso muy fuerte";
								Lang.tip[21] = "Retroceso tremendamente fuerte";
								Lang.tip[22] = "Retroceso descomunal";
								Lang.tip[23] = "Utilizable";
								Lang.tip[24] = "Objeto de apariencia";
								Lang.tip[25] = " defensa";
								Lang.tip[26] = "% potencia de pico";
								Lang.tip[27] = "% potencia de hacha";
								Lang.tip[28] = "% potencia de martillo";
								Lang.tip[29] = "Recupera";
								Lang.tip[30] = "vida";
								Lang.tip[31] = "maná";
								Lang.tip[32] = "Consume";
								Lang.tip[33] = "Se puede colocar";
								Lang.tip[34] = "Munición";
								Lang.tip[35] = "Consumible";
								Lang.tip[36] = "Material";
								Lang.tip[37] = " minuto/s de duración";
								Lang.tip[38] = " segundo/s de duración";
								Lang.tip[39] = "% daño";
								Lang.tip[40] = "% velocidad";
								Lang.tip[41] = "% probabilidad de ataque crítico";
								Lang.tip[42] = "% coste de maná";
								Lang.tip[43] = "% tamaño";
								Lang.tip[44] = "% velocidad de proyectil";
								Lang.tip[45] = "% retroceso";
								Lang.tip[46] = "% velocidad de movimiento";
								Lang.tip[47] = "% velocidad en el cuerpo a cuerpo";
								Lang.tip[48] = "Set completo:";
								Lang.tip[49] = "Precio de venta:";
								Lang.tip[50] = "Precio de compra:";
								Lang.tip[51] = "Sin valor";
								Lang.tip[52] = "consume ";
								Lang.tip[53] = " convocar a los daños";
								Lang.tip[54] = " alcance";
								Lang.tip[55] = " daño";
								Lang.mp[0] = "Recibe:";
								Lang.mp[1] = "Contraseña incorrecta.";
								Lang.mp[2] = "Operación no válida en este estado.";
								Lang.mp[3] = "Se te ha prohibido la entrada a este servidor.";
								Lang.mp[4] = "No tienes la misma versión que este servidor.";
								Lang.mp[5] = "ya está en este servidor.";
								Lang.mp[6] = "/jugando";
								Lang.mp[7] = "Jugadores ahora:";
								Lang.mp[8] = "/tira";
								Lang.mp[9] = "tira de";
								Lang.mp[10] = "¡No estás en ningún bando!";
								Lang.mp[11] = "ha activado 1c1!";
								Lang.mp[12] = "ha desactivado 1c1!";
								Lang.mp[13] = "ya no pertenece a ningún bando.";
								Lang.mp[14] = "se ha unido al bando rojo.";
								Lang.mp[15] = "se ha unido al bando verde.";
								Lang.mp[16] = "se ha unido al bando azul.";
								Lang.mp[17] = "se ha unido al bando amarillo.";
								Lang.mp[18] = "¡Bienvenido a";
								Lang.mp[19] = "se ha unido.";
								Lang.mp[20] = "ha dejado de.";
								Lang.the = "el ";
								Lang.dt[0] = "no logró encontrar el antídoto";
								Lang.dt[1] = "no pudo extinguir el fuego";
								Main.buffName[1] = "Piel obsidiana";
								Main.buffTip[1] = "Inmune a la lava";
								Main.buffName[2] = "Regeneración";
								Main.buffTip[2] = "Regenera la vida";
								Main.buffName[3] = "Rapidez";
								Main.buffTip[3] = "Aumenta en un 25% la velocidad de movimiento";
								Main.buffName[4] = "Agallas";
								Main.buffTip[4] = "Permite respirar agua en lugar de aire";
								Main.buffName[5] = "Piel de hierro";
								Main.buffTip[5] = "Aumenta la defensa en 8";
								Main.buffName[6] = "Regeneración de maná";
								Main.buffTip[6] = "Aumenta la regeneración de maná";
								Main.buffName[7] = "Poder mágico";
								Main.buffTip[7] = "Aumenta el daño mágico en un 20%";
								Main.buffName[8] = "Caída de pluma";
								Main.buffTip[8] = "Pulsa ARRIBA o ABAJO para controlar la velocidad de descenso";
								Main.buffName[9] = "Espeleólogo";
								Main.buffTip[9] = "Muestra la ubicación de tesoros y minerales";
								Main.buffName[10] = "Invisibilidad";
								Main.buffTip[10] = "Proporciona invisibilidad";
								Main.buffName[11] = "Brillo";
								Main.buffTip[11] = "Emite luz";
								Main.buffName[12] = "Noctámbulo";
								Main.buffTip[12] = "Aumenta la visión nocturna";
								Main.buffName[13] = "Batalla";
								Main.buffTip[13] = "Aumenta el porcentaje de regeneración del enemigo";
								Main.buffName[14] = "Espinas";
								Main.buffTip[14] = "Los atacantes también sufren daños";
								Main.buffName[15] = "Caminando sobre el agua";
								Main.buffTip[15] = "Pulsa ABAJO para sumergirte";
								Main.buffName[16] = "Tiro con arco";
								Main.buffTip[16] = "Aumenta en un 20% la velocidad y el daño de las flechas";
								Main.buffName[17] = "Cazador";
								Main.buffTip[17] = "Muestra la ubicación de los enemigos";
								Main.buffName[18] = "Gravedad";
								Main.buffTip[18] = "Pulsa ARRIBA o ABAJO para invertir la gravedad";
								Main.buffName[19] = "Orbe de Luz";
								Main.buffTip[19] = "Orbe mágico que proporciona luz";
								Main.buffName[20] = "Veneno";
								Main.buffTip[20] = "Pérdida de vida lentamente";
								Main.buffName[21] = "Poción de náuseas";
								Main.buffTip[21] = "Deja de consumir remedios curativos";
								Main.buffName[22] = "Oscuridad";
								Main.buffTip[22] = "Disminuye la claridad";
								Main.buffName[23] = "Maldición";
								Main.buffTip[23] = "No se puede usar ningún objeto";
								Main.buffName[24] = "Llamas";
								Main.buffTip[24] = "Pérdida de vida lentamente";
								Main.buffName[25] = "Beodo";
								Main.buffTip[25] = "Mejora el cuerpo a cuerpo pero ralentiza la defensa";
								Main.buffName[26] = "Bien alimentado";
								Main.buffTip[26] = "Pequeñas mejoras de todas las estadísticas";
								Main.buffName[27] = "Hada";
								Main.buffTip[27] = "Un hada te acompaña";
								Main.buffName[28] = "Hombre lobo";
								Main.buffTip[28] = "Aumenta la capacidad física";
								Main.buffName[29] = "Clarividencia";
								Main.buffTip[29] = "Aumenta los poderes mágicos";
								Main.buffName[30] = "Ensangrentado";
								Main.buffTip[30] = "No se puede recuperar vida";
								Main.buffName[31] = "Confundido";
								Main.buffTip[31] = "Se invierte el movimiento";
								Main.buffName[32] = "Lento";
								Main.buffTip[32] = "Disminuye la velocidad de movimiento";
								Main.buffName[33] = "Débil";
								Main.buffTip[33] = "Disminuye la capacidad física";
								Main.buffName[34] = "Tritón";
								Main.buffTip[34] = "Respira y se mueve bajo el agua con facilidad";
								Main.buffName[35] = "Silenciado";
								Main.buffTip[35] = "No puede utilizar los artículos que requieren maná";
								Main.buffName[36] = "Armadura rota";
								Main.buffTip[36] = "La defensa disminuye hasta la mitad";
								Main.buffName[37] = "Aterrado";
								Main.buffTip[37] = "Has visto algo horrible, no hay escapatoria";
								Main.buffName[38] = "La Lengua";
								Main.buffTip[38] = "Te succiona";
								Main.buffName[39] = "El Averno";
								Main.buffTip[39] = "Pérdida de la vida";
								Main.buffName[40] = "Mascota conejo";
								Main.buffTip[40] = "Creo que quiere su zanahoria";
								Main.buffName[41] = "pingüino del bebé";
								Main.buffTip[41] = "Creo que quiere que sus peces";
								Main.buffName[42] = "tortuga";
								Main.buffTip[42] = "Tiempo feliz tortuga!";
								Main.buffName[43] = "el escudo de paladin";
								Main.buffTip[43] = "25% de daño recibido será redirigido a otro jugador";
								Main.buffName[44] = "quemadura de Escarcha";
								Main.buffTip[44] = "Es o muy caliente o muy fría. De cualquier manera me duele mucho";
								Main.buffName[45] = "comedor de bebé";
								Main.buffTip[45] = "A Eater bebé de las almas te está siguiendo";
								Main.buffName[46] = "enfriado";
								Main.buffTip[46] = "Su velocidad de movimiento se ha reducido";
								Main.buffName[47] = "Congelado";
								Main.buffTip[47] = "No se puede mover!";
								Main.buffName[48] = "miel";
								Main.buffTip[48] = "La regeneración de la vida se incrementa";
								Main.buffName[49] = "pigmeos";
								Main.buffTip[49] = "Los pigmeos lucharán para usted";
								Main.buffName[50] = "Bebé Skeletron cabeza";
								Main.buffTip[50] = "Ni siquiera preguntar ...";
								Main.buffName[51] = "Bebé Hornet";
								Main.buffTip[51] = "Se cree que eres su madre";
								Main.buffName[52] = "tiki espíritu";
								Main.buffTip[52] = "Un espíritu amistoso que está siguiendo";
								Main.buffName[53] = "lagartija";
								Main.buffTip[53] = "Tiempo libre como un reptil";
								Main.buffName[54] = "loro";
								Main.buffTip[54] = "Polly quiere es el cracker";
								Main.buffName[55] = "Bebé Trufa";
								Main.buffTip[55] = "No es esto apenas soooo cute";
								Main.buffName[56] = "mascota retoño";
								Main.buffTip[56] = "Un arbolito que está siguiendo";
								Main.buffName[57] = "manojito";
								Main.buffTip[57] = "Un mechón te está siguiendo";
								Main.buffName[58] = "La curación rápida";
								Main.buffTip[58] = "La regeneración de la vida es mucho mayor";
								Main.buffName[59] = "Sombra de Dodge";
								Main.buffTip[59] = "Va a esquivar el próximo ataque";
								Main.buffName[60] = "cristal de la hoja";
								Main.buffTip[60] = "Cristal Shoots sale a los enemigos cercanos";
								Main.buffName[61] = "dinosaurio del bebé";
								Main.buffTip[61] = "Un dinosaurio bebé te está siguiendo";
								Main.buffName[62] = "Barrera de hielo";
								Main.buffTip[62] = "Defensa se ​​incrementa en un 30";
								Main.buffName[63] = "pánico";
								Main.buffTip[63] = "La velocidad de movimiento se incrementa";
								Main.buffName[64] = "bebé baba";
								Main.buffTip[64] = "La baba del bebé peleará por vosotros";
								Main.buffName[65] = "Eyeball primavera";
								Main.buffTip[65] = "Un muelle ojo te está siguiendo";
								Main.buffName[66] = "Muñeco de nieve del bebé";
								Main.buffTip[66] = "Un muñeco de nieve del bebé te está siguiendo";
								Main.buffName[67] = "ardor";
								Main.buffTip[67] = "La pérdida de la vida y la lentitud de movimientos";
								Main.buffName[68] = "asfixia";
								Main.buffTip[68] = "La pérdida de la vida";
								Main.buffName[69] = "hondura";
								Main.buffTip[69] = "defensa reducida";
								Main.buffName[70] = "veneno";
								Main.buffTip[70] = "La pérdida de la vida";
								Main.buffName[72] = "Midas";
								Main.buffTip[72] = "Soltar más dinero en la muerte";
								Main.buffName[80] = "apagón";
								Main.buffTip[80] = "La visión de luz muy reducida";
								Main.buffName[71] = "imbuir armas: veneno";
								Main.buffTip[71] = "Ataques cuerpo a cuerpo infligen veneno en sus objetivos";
								Main.buffName[73] = "imbuir armas: Llamas Maldito";
								Main.buffTip[73] = "Ataques cuerpo a cuerpo infligen los enemigos con llamas malditos";
								Main.buffName[74] = "imbuir armas: fuego";
								Main.buffTip[74] = "Ataques cuerpo a cuerpo establecen enemigos en llamas";
								Main.buffName[75] = "imbuir armas: oro";
								Main.buffTip[75] = "Ataques cuerpo a cuerpo hacen enemigos caen más oro";
								Main.buffName[76] = "imbuir armas: hondura";
								Main.buffTip[76] = "Ataques cuerpo a cuerpo disminuyen defensa enemigos";
								Main.buffName[77] = "imbuir armas: Nanites";
								Main.buffTip[77] = "Ataques cuerpo a cuerpo confunde enemigos";
								Main.buffName[78] = "imbuir armas: confeti";
								Main.buffTip[78] = "Ataques cuerpo a cuerpo infligen confetti que aparezca";
								Main.buffName[79] = "imbuir armas: tóxico";
								Main.buffTip[79] = "Cuerpo a cuerpo ataca a los enemigos de veneno";
								Main.tileName[13] = "Botella";
								Main.tileName[14] = "Mesa";
								Main.tileName[15] = "Silla";
								Main.tileName[16] = "Yunque";
								Main.tileName[17] = "Horno";
								Main.tileName[18] = "Banco de trabajo";
								Main.tileName[26] = "Demonio altar";
								Main.tileName[77] = "Forjas infernal";
								Main.tileName[86] = "Telar";
								Main.tileName[94] = "Barrica";
								Main.tileName[96] = "Perol";
								Main.tileName[101] = "Librería";
								Main.tileName[106] = "Serrería";
								Main.tileName[114] = "Taller del reparador";
								Main.tileName[133] = "Forja de adamantita";
								Main.tileName[134] = "Yunque de mithril";
							}
						}
					}
				}
			}
			for (int i = 0; i < Main.recipe.Length; i++)
			{
				if (Main.recipe[i].createItem.name != null && Main.recipe[i].createItem.name != "" && Main.recipe[i].createItem.netID != 0)
				{
					Main.recipe[i].createItem.name = Lang.itemName(Main.recipe[i].createItem.netID, false);
					Main.recipe[i].createItem.CheckTip();
					for (int j = 0; j < Main.recipe[j].requiredItem.Length; j++)
					{
						Main.recipe[i].requiredItem[j].name = Lang.itemName(Main.recipe[i].requiredItem[j].netID, false);
						Main.recipe[i].requiredItem[j].CheckTip();
					}
				}
			}
		}
		public static string deathMsg(int plr = -1, int npc = -1, int proj = -1, int other = -1)
		{
			if (Lang.lang <= 1)
			{
				string result = "";
				int num = Main.rand.Next(26);
				string text = "";
				if (num == 0)
				{
					text = " was slain";
				}
				else
				{
					if (num == 1)
					{
						text = " was eviscerated";
					}
					else
					{
						if (num == 2)
						{
							text = " was murdered";
						}
						else
						{
							if (num == 3)
							{
								text = "'s face was torn off";
							}
							else
							{
								if (num == 4)
								{
									text = "'s entrails were ripped out";
								}
								else
								{
									if (num == 5)
									{
										text = " was destroyed";
									}
									else
									{
										if (num == 6)
										{
											text = "'s skull was crushed";
										}
										else
										{
											if (num == 7)
											{
												text = " got massacred";
											}
											else
											{
												if (num == 8)
												{
													text = " got impaled";
												}
												else
												{
													if (num == 9)
													{
														text = " was torn in half";
													}
													else
													{
														if (num == 10)
														{
															text = " was decapitated";
														}
														else
														{
															if (num == 11)
															{
																text = " let their arms get torn off";
															}
															else
															{
																if (num == 12)
																{
																	text = " watched their innards become outards";
																}
																else
																{
																	if (num == 13)
																	{
																		text = " was brutally dissected";
																	}
																	else
																	{
																		if (num == 14)
																		{
																			text = "'s extremities were detached";
																		}
																		else
																		{
																			if (num == 15)
																			{
																				text = "'s body was mangled";
																			}
																			else
																			{
																				if (num == 16)
																				{
																					text = "'s vital organs were ruptured";
																				}
																				else
																				{
																					if (num == 17)
																					{
																						text = " was turned into a pile of flesh";
																					}
																					else
																					{
																						if (num == 18)
																						{
																							text = " was removed from " + Main.worldName;
																						}
																						else
																						{
																							if (num == 19)
																							{
																								text = " got snapped in half";
																							}
																							else
																							{
																								if (num == 20)
																								{
																									text = " was cut down the middle";
																								}
																								else
																								{
																									if (num == 21)
																									{
																										text = " was chopped up";
																									}
																									else
																									{
																										if (num == 22)
																										{
																											text = "'s plead for death was answered";
																										}
																										else
																										{
																											if (num == 23)
																											{
																												text = "'s meat was ripped off the bone";
																											}
																											else
																											{
																												if (num == 24)
																												{
																													text = "'s flailing about was finally stopped";
																												}
																												else
																												{
																													if (num == 25)
																													{
																														text = " had their head removed";
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				if (plr >= 0 && plr < 255)
				{
					if (proj >= 0 && Main.projectile[proj].name != "")
					{
						result = string.Concat(new string[]
						{
							text,
							" by ",
							Main.player[plr].name,
							"'s ",
							Main.projectile[proj].name,
							"."
						});
					}
					else
					{
						result = string.Concat(new string[]
						{
							text,
							" by ",
							Main.player[plr].name,
							"'s ",
							Main.player[plr].inventory[Main.player[plr].selectedItem].name,
							"."
						});
					}
				}
				else
				{
					if (npc >= 0 && Main.npc[npc].displayName != "")
					{
						result = text + " by " + Main.npc[npc].displayName + ".";
					}
					else
					{
						if (proj >= 0 && Main.projectile[proj].name != "")
						{
							result = text + " by " + Main.projectile[proj].name + ".";
						}
						else
						{
							if (other >= 0)
							{
								if (other == 0)
								{
									if (Main.rand.Next(2) == 0)
									{
										result = " fell to their death.";
									}
									else
									{
										result = " didn't bounce.";
									}
								}
								else
								{
									if (other == 1)
									{
										int num2 = Main.rand.Next(4);
										if (num2 == 0)
										{
											result = " forgot to breathe.";
										}
										else
										{
											if (num2 == 1)
											{
												result = " is sleeping with the fish.";
											}
											else
											{
												if (num2 == 2)
												{
													result = " drowned.";
												}
												else
												{
													if (num2 == 3)
													{
														result = " is shark food.";
													}
												}
											}
										}
									}
									else
									{
										if (other == 2)
										{
											int num3 = Main.rand.Next(4);
											if (num3 == 0)
											{
												result = " got melted.";
											}
											else
											{
												if (num3 == 1)
												{
													result = " was incinerated.";
												}
												else
												{
													if (num3 == 2)
													{
														result = " tried to swim in lava.";
													}
													else
													{
														if (num3 == 3)
														{
															result = " likes to play in magma.";
														}
													}
												}
											}
										}
										else
										{
											if (other == 3)
											{
												result = text + ".";
											}
										}
									}
								}
							}
						}
					}
				}
				return result;
			}
			if (Lang.lang == 2)
			{
				string result2 = "";
				int num4 = Main.rand.Next(15);
				string str;
				if (num4 == 0)
				{
					str = " wurde durch";
				}
				else
				{
					if (num4 == 1)
					{
						str = " wurde vernichtet";
					}
					else
					{
						if (num4 == 2)
						{
							str = " wurde ermordet";
						}
						else
						{
							if (num4 == 3)
							{
								str = " wurde zerstoert";
							}
							else
							{
								if (num4 == 4)
								{
									str = " wurde massakriert";
								}
								else
								{
									if (num4 == 5)
									{
										str = " wurde aufgespiesst";
									}
									else
									{
										if (num4 == 6)
										{
											str = " wurde in zwei Haelften gerissen";
										}
										else
										{
											if (num4 == 7)
											{
												str = " wurde gekoepft";
											}
											else
											{
												if (num4 == 8)
												{
													str = " liess sich die Arme wegreissen";
												}
												else
												{
													if (num4 == 9)
													{
														str = " sah die eigenen Innereien herausquellen";
													}
													else
													{
														if (num4 == 10)
														{
															str = " wurde brutal seziert";
														}
														else
														{
															if (num4 == 11)
															{
																str = " wurde in Hackfleisch verwandelt";
															}
															else
															{
																if (num4 == 12)
																{
																	str = " wurde laengs gefaltet";
																}
																else
																{
																	if (num4 == 13)
																	{
																		str = " wurde um die Haelfte gekuerzt";
																	}
																	else
																	{
																		str = " liess sich den Kopf wegreissen";
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				if ((plr >= 0 && plr < 255) || (npc >= 0 && Main.npc[npc].displayName != "") || (proj >= 0 && Main.projectile[proj].name != ""))
				{
					result2 = str + ".";
				}
				else
				{
					if (other >= 0)
					{
						if (other == 0)
						{
							if (Main.rand.Next(2) == 0)
							{
								result2 = " stuerzte in den Tod.";
							}
							else
							{
								result2 = " ist nicht gesprungen.";
							}
						}
						else
						{
							if (other == 1)
							{
								int num5 = Main.rand.Next(4);
								if (num5 == 0)
								{
									result2 = " hat vergessen zu atmen.";
								}
								else
								{
									if (num5 == 1)
									{
										result2 = " hat jetzt ein feuchtes Grab bei den Fischen.";
									}
									else
									{
										if (num5 == 2)
										{
											result2 = " ist ertrunken.";
										}
										else
										{
											if (num5 == 3)
											{
												result2 = " ist jetzt Fischfutter.";
											}
										}
									}
								}
							}
							else
							{
								if (other == 2)
								{
									int num6 = Main.rand.Next(4);
									if (num6 == 0)
									{
										result2 = " ist geschmolzen.";
									}
									else
									{
										if (num6 == 1)
										{
											result2 = " wurde eingeaeschert.";
										}
										else
										{
											if (num6 == 2)
											{
												result2 = " versuchte, in Lava zu baden.";
											}
											else
											{
												if (num6 == 3)
												{
													result2 = " spielt gern mit Magma.";
												}
											}
										}
									}
								}
								else
								{
									if (other == 3)
									{
										result2 = str + ".";
									}
								}
							}
						}
					}
				}
				return result2;
			}
			if (Lang.lang == 3)
			{
				string result3 = "";
				int num7 = Main.rand.Next(13);
				string str2;
				if (num7 == 0)
				{
					str2 = " è stato ucciso";
				}
				else
				{
					if (num7 == 1)
					{
						str2 = " è stato sventrato";
					}
					else
					{
						if (num7 == 2)
						{
							str2 = " è stato assassinato";
						}
						else
						{
							if (num7 == 3)
							{
								str2 = " è stato distrutto";
							}
							else
							{
								if (num7 == 4)
								{
									str2 = " è stato massacrato";
								}
								else
								{
									if (num7 == 5)
									{
										str2 = " è stato trafitto";
									}
									else
									{
										if (num7 == 6)
										{
											str2 = " è stato diviso in due";
										}
										else
										{
											if (num7 == 7)
											{
												str2 = " è stato decapitato";
											}
											else
											{
												if (num7 == 8)
												{
													str2 = " ha visto uscire le sue interiora ";
												}
												else
												{
													if (num7 == 9)
													{
														str2 = " è stato brutalmente sezionato";
													}
													else
													{
														if (num7 == 10)
														{
															str2 = " è diventato un mucchio di carne";
														}
														else
														{
															if (num7 == 11)
															{
																str2 = " è stato spezzato a metà";
															}
															else
															{
																str2 = " è stato tagliato a metà";
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				if ((plr >= 0 && plr < 255) || (npc >= 0 && Main.npc[npc].displayName != "") || (proj >= 0 && Main.projectile[proj].name != ""))
				{
					result3 = str2 + ".";
				}
				else
				{
					if (other >= 0)
					{
						if (other == 0)
						{
							if (Main.rand.Next(2) == 0)
							{
								result3 = " sente la sua morte.";
							}
							else
							{
								result3 = " non poteva rimbalzare.";
							}
						}
						else
						{
							if (other == 1)
							{
								int num8 = Main.rand.Next(4);
								if (num8 == 0)
								{
									result3 = " ha dimenticato di respirare.";
								}
								else
								{
									if (num8 == 1)
									{
										result3 = " sta dormendo con i pesci.";
									}
									else
									{
										if (num8 == 2)
										{
											result3 = " è affogato.";
										}
										else
										{
											if (num8 == 3)
											{
												result3 = " è un pasto dello squalo.";
											}
										}
									}
								}
							}
							else
							{
								if (other == 2)
								{
									int num9 = Main.rand.Next(4);
									if (num9 == 0)
									{
										result3 = " si è sciolto.";
									}
									else
									{
										if (num9 == 1)
										{
											result3 = " si è incenerito.";
										}
										else
										{
											if (num9 == 2)
											{
												result3 = " ha provato a nuotare nella lava.";
											}
											else
											{
												if (num9 == 3)
												{
													result3 = " piace giocare nel magma.";
												}
											}
										}
									}
								}
								else
								{
									if (other == 3)
									{
										result3 = str2 + ".";
									}
								}
							}
						}
					}
				}
				return result3;
			}
			if (Lang.lang == 4)
			{
				string result4 = "";
				int num10 = Main.rand.Next(14);
				string str3;
				if (num10 == 0)
				{
					str3 = " s'est fait éviscérer";
				}
				else
				{
					if (num10 == 1)
					{
						str3 = " s'est fait assassiner";
					}
					else
					{
						if (num10 == 2)
						{
							str3 = " s'est fait détruire";
						}
						else
						{
							if (num10 == 3)
							{
								str3 = " s'est fait massacrer";
							}
							else
							{
								if (num10 == 4)
								{
									str3 = " s'est fait empaler";
								}
								else
								{
									if (num10 == 5)
									{
										str3 = " s'est fait couper en deux";
									}
									else
									{
										if (num10 == 6)
										{
											str3 = " s'est fait arracher la tête";
										}
										else
										{
											if (num10 == 7)
											{
												str3 = " s'est fait déchiqueter les bras";
											}
											else
											{
												if (num10 == 8)
												{
													str3 = " a vu ses entrailles tomber à ses pieds";
												}
												else
												{
													if (num10 == 9)
													{
														str3 = " s'est fait brutalement découper";
													}
													else
													{
														if (num10 == 10)
														{
															str3 = " a fini en chair à pâtée";
														}
														else
														{
															if (num10 == 11)
															{
																str3 = " s'est fait couper en deux";
															}
															else
															{
																if (num10 == 12)
																{
																	str3 = " s'est fait couper en tranches";
																}
																else
																{
																	str3 = " a perdu la tête";
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				if ((plr >= 0 && plr < 255) || (npc >= 0 && Main.npc[npc].displayName != "") || (proj >= 0 && Main.projectile[proj].name != ""))
				{
					result4 = str3 + ".";
				}
				else
				{
					if (other >= 0)
					{
						if (other == 0)
						{
							if (Main.rand.Next(2) == 0)
							{
								result4 = " a cassé sa pipe.";
							}
							else
							{
								result4 = " ne bouge plus.";
							}
						}
						else
						{
							if (other == 1)
							{
								int num11 = Main.rand.Next(4);
								if (num11 == 0)
								{
									result4 = " a cessé de respirer.";
								}
								else
								{
									if (num11 == 1)
									{
										result4 = " mange les pissenlits par la racine.";
									}
									else
									{
										if (num11 == 2)
										{
											result4 = " a coulé à pic.";
										}
										else
										{
											if (num11 == 3)
											{
												result4 = " nourrit les requins.";
											}
										}
									}
								}
							}
							else
							{
								if (other == 2)
								{
									int num12 = Main.rand.Next(4);
									if (num12 == 0)
									{
										result4 = " a fondu.";
									}
									else
									{
										if (num12 == 1)
										{
											result4 = " s'est fait incinérer.";
										}
										else
										{
											if (num12 == 2)
											{
												result4 = " a tenté de nager dans la lave.";
											}
											else
											{
												if (num12 == 3)
												{
													result4 = " aime barboter dans le magma.";
												}
											}
										}
									}
								}
								else
								{
									if (other == 3)
									{
										result4 = str3 + ".";
									}
								}
							}
						}
					}
				}
				return result4;
			}
			if (Lang.lang == 5)
			{
				string result5 = "";
				string str4 = " fue asesinado";
				if ((plr >= 0 && plr < 255) || (npc >= 0 && Main.npc[npc].displayName != "") || (proj >= 0 && Main.projectile[proj].name != ""))
				{
					result5 = str4 + ".";
				}
				else
				{
					if (other >= 0)
					{
						if (other == 0)
						{
							if (Main.rand.Next(2) == 0)
							{
								result5 = " le ha llegado la hora.";
							}
							else
							{
								result5 = " no saltó a tiempo.";
							}
						}
						else
						{
							if (other == 1)
							{
								int num13 = Main.rand.Next(4);
								if (num13 == 0)
								{
									result5 = " se olvidó de respirar.";
								}
								else
								{
									if (num13 == 1)
									{
										result5 = " duerme con los peces.";
									}
									else
									{
										if (num13 == 2)
										{
											result5 = " se ha ahogado.";
										}
										else
										{
											if (num13 == 3)
											{
												result5 = " es pasto de los tiburones.";
											}
										}
									}
								}
							}
							else
							{
								if (other == 2)
								{
									int num14 = Main.rand.Next(4);
									if (num14 == 0)
									{
										result5 = " se ha calcinado.";
									}
									else
									{
										if (num14 == 1)
										{
											result5 = " se ha chamuscado.";
										}
										else
										{
											if (num14 == 2)
											{
												result5 = " ha intentado nadar en lava.";
											}
											else
											{
												if (num14 == 3)
												{
													result5 = " le gusta jugar con el magma.";
												}
											}
										}
									}
								}
								else
								{
									if (other == 3)
									{
										result5 = str4 + ".";
									}
								}
							}
						}
					}
				}
				return result5;
			}
			return "";
		}
	}
}

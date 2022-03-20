using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Charmeleon Species to store common natural stats of all Charmeleons
	#region CharmeleonSpecies
	public class CharmeleonSpecies : PokemonSpecies
	{
#nullable enable
		private static CharmeleonSpecies? _instance = null;
#nullable restore
        public static CharmeleonSpecies Instance => _instance ?? (_instance = new CharmeleonSpecies());

		#region CharmeleonSpecies Constructor
		public CharmeleonSpecies() : base(
			5,
			"Charmeleon",
			Fire.Instance,
			1.1,
			19.0,
			new PokemonStats(
				58, // HPs
				64, 58, // Attack & Defense
				80, 65, // Spacial Attack & Defense
				80 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Fire-Punch",
				"Thunder-Punch",
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Growl",
				"Ember",
				"Flamethrower",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dragon-Rage",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Natural-Gift",
				"Fling",
				"Dragon-Pulse",
				"Shadow-Claw",
				"Fire-Fang",
				"Captivate",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}
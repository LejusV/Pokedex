using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Charmander Species to store common natural stats of all Charmanders
	#region CharmanderSpecies
	public class CharmanderSpecies : PokemonSpecies
	{
#nullable enable
		private static CharmanderSpecies? _instance = null;
#nullable restore
        public static CharmanderSpecies Instance => _instance ?? (_instance = new CharmanderSpecies());

		#region CharmanderSpecies Constructor
		public CharmanderSpecies() : base(
			4,
			"Charmander",
			Fire.Instance,
			0.6,
			8.5,
			new PokemonStats(
				39, // HPs
				52, 43, // Attack & Defense
				60, 50, // Spacial Attack & Defense
				65 // Speed
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
				"Bite",
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
				"Belly-Drum",
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
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Beat-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Air-Cutter",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Natural-Gift",
				"Fling",
				"Flare-Blitz",
				"Dragon-Pulse",
				"Dragon-Rush",
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
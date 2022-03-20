using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Prinplup Species to store common natural stats of all Prinplups
	#region PrinplupSpecies
	public class PrinplupSpecies : PokemonSpecies
	{
#nullable enable
		private static PrinplupSpecies? _instance = null;
#nullable restore
        public static PrinplupSpecies Instance => _instance ?? (_instance = new PrinplupSpecies());

		#region PrinplupSpecies Constructor
		public PrinplupSpecies() : base(
			394,
			"Prinplup",
			Water.Instance,
			0.8,
			23.0,
			new PokemonStats(
				64, // HPs
				66, 68, // Attack & Defense
				81, 76, // Spacial Attack & Defense
				50 // Speed
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
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Peck",
				"Drill-Peck",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Whirlpool",
				"Hail",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Dive",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Shadow-Claw",
				"Defog",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Quash",
				"Water-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
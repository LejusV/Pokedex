using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Empoleon Species to store common natural stats of all Empoleons
	#region EmpoleonSpecies
	public class EmpoleonSpecies : PokemonSpecies
	{
#nullable enable
		private static EmpoleonSpecies? _instance = null;
#nullable restore
        public static EmpoleonSpecies Instance => _instance ?? (_instance = new EmpoleonSpecies());

		#region EmpoleonSpecies Constructor
		public EmpoleonSpecies() : base(
			395,
			"Empoleon",
			Water.Instance, Steel.Instance,
			1.7,
			84.5,
			new PokemonStats(
				84, // HPs
				86, 88, // Attack & Defense
				111, 101, // Spacial Attack & Defense
				60 // Speed
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
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Tackle",
				"Growl",
				"Roar",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Hyper-Beam",
				"Peck",
				"Drill-Peck",
				"Strength",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Waterfall",
				"Bubble",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
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
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Iron-Defense",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Flash-Cannon",
				"Rock-Climb",
				"Defog",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Aqua-Jet",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Quash",
				"Water-Pledge",
				"Bulldoze",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
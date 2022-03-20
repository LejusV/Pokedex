using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Piplup Species to store common natural stats of all Piplups
	#region PiplupSpecies
	public class PiplupSpecies : PokemonSpecies
	{
#nullable enable
		private static PiplupSpecies? _instance = null;
#nullable restore
        public static PiplupSpecies Instance => _instance ?? (_instance = new PiplupSpecies());

		#region PiplupSpecies Constructor
		public PiplupSpecies() : base(
			393,
			"Piplup",
			Water.Instance,
			0.4,
			5.2,
			new PokemonStats(
				53, // HPs
				51, 53, // Attack & Defense
				61, 56, // Spacial Attack & Defense
				40 // Speed
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
				"Pound",
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Growl",
				"Supersonic",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Peck",
				"Drill-Peck",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Feather-Dance",
				"Mud-Sport",
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
				"Aqua-Ring",
				"Defog",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Quash",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion
}
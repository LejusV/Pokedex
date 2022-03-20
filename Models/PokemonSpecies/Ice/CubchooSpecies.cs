using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Cubchoo Species to store common natural stats of all Cubchoos
	#region CubchooSpecies
	public class CubchooSpecies : PokemonSpecies
	{
#nullable enable
		private static CubchooSpecies? _instance = null;
#nullable restore
        public static CubchooSpecies Instance => _instance ?? (_instance = new CubchooSpecies());

		#region CubchooSpecies Constructor
		public CubchooSpecies() : base(
			613,
			"Cubchoo",
			Ice.Instance,
			0.5,
			8.5,
			new PokemonStats(
				55, // HPs
				70, 40, // Attack & Defense
				60, 40, // Spacial Attack & Defense
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
				"Ice-Punch",
				"Cut",
				"Thrash",
				"Growl",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Low-Kick",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Flail",
				"Powder-Snow",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Superpower",
				"Yawn",
				"Secret-Power",
				"Rock-Tomb",
				"Sheer-Cold",
				"Aerial-Ace",
				"Covet",
				"Water-Pulse",
				"Brine",
				"Assurance",
				"Fling",
				"Night-Slash",
				"Avalanche",
				"Shadow-Claw",
				"Grass-Knot",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Play-Rough",
				"Play-Nice",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Beautifly Species to store common natural stats of all Beautiflys
	#region BeautiflySpecies
	public class BeautiflySpecies : PokemonSpecies
	{
#nullable enable
		private static BeautiflySpecies? _instance = null;
#nullable restore
        public static BeautiflySpecies Instance => _instance ?? (_instance = new BeautiflySpecies());

		#region BeautiflySpecies Constructor
		public BeautiflySpecies() : base(
			267,
			"Beautifly",
			Bug.Instance, Flying.Instance,
			1.0,
			28.4,
			new PokemonStats(
				60, // HPs
				70, 50, // Attack & Defense
				100, 50, // Spacial Attack & Defense
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
				"Gust",
				"Whirlwind",
				"Double-Edge",
				"Hyper-Beam",
				"Absorb",
				"Mega-Drain",
				"Solar-Beam",
				"Stun-Spore",
				"String-Shot",
				"Toxic",
				"Psychic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Morning-Sun",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Shadow-Ball",
				"Facade",
				"Secret-Power",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Giga-Impact",
				"Defog",
				"Captivate",
				"Bug-Bite",
				"Ominous-Wind",
				"Venoshock",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Electroweb",
				"Confide",
				"Infestation"
			};
		}
		#endregion
	}
	#endregion
}
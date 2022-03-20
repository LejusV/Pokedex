using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Farfetchd Species to store common natural stats of all Farfetchds
	#region FarfetchdSpecies
	public class FarfetchdSpecies : PokemonSpecies
	{
#nullable enable
		private static FarfetchdSpecies? _instance = null;
#nullable restore
        public static FarfetchdSpecies Instance => _instance ?? (_instance = new FarfetchdSpecies());

		#region FarfetchdSpecies Constructor
		public FarfetchdSpecies() : base(
			83,
			"Farfetchd",
			Normal.Instance, Flying.Instance,
			0.8,
			15.0,
			new PokemonStats(
				52, // HPs
				90, 55, // Attack & Defense
				58, 62, // Spacial Attack & Defense
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
				"Razor-Wind",
				"Swords-Dance",
				"Cut",
				"Gust",
				"Whirlwind",
				"Fly",
				"Sand-Attack",
				"Headbutt",
				"Fury-Attack",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Peck",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Mirror-Move",
				"Swift",
				"Skull-Bash",
				"Sky-Attack",
				"Rest",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Foresight",
				"Detect",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Psych-Up",
				"Uproar",
				"Heat-Wave",
				"Facade",
				"Helping-Hand",
				"Revenge",
				"Knock-Off",
				"Secret-Power",
				"Feather-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Covet",
				"Leaf-Blade",
				"Roost",
				"Natural-Gift",
				"Feint",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Trump-Card",
				"Last-Resort",
				"Poison-Jab",
				"Night-Slash",
				"Air-Slash",
				"Brave-Bird",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Simple-Beam",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Final-Gambit",
				"Work-Up",
				"Confide",
				"First-Impression",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}
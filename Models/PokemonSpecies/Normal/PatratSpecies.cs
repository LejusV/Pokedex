using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Patrat Species to store common natural stats of all Patrats
	#region PatratSpecies
	public class PatratSpecies : PokemonSpecies
	{
#nullable enable
		private static PatratSpecies? _instance = null;
#nullable restore
        public static PatratSpecies Instance => _instance ?? (_instance = new PatratSpecies());

		#region PatratSpecies Constructor
		public PatratSpecies() : base(
			504,
			"Patrat",
			Normal.Instance,
			0.5,
			11.6,
			new PokemonStats(
				45, // HPs
				55, 39, // Attack & Defense
				35, 39, // Spacial Attack & Defense
				42 // Speed
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
				"Slam",
				"Sand-Attack",
				"Tackle",
				"Leer",
				"Bite",
				"Low-Kick",
				"Thunderbolt",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Bide",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Foresight",
				"Detect",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Facade",
				"Helping-Hand",
				"Revenge",
				"Endeavor",
				"Secret-Power",
				"Bullet-Seed",
				"Covet",
				"Shock-Wave",
				"Assurance",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Grass-Knot",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Tearful-Look"
			};
		}
		#endregion
	}
	#endregion
}
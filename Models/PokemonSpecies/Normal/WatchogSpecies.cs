using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Watchog Species to store common natural stats of all Watchogs
	#region WatchogSpecies
	public class WatchogSpecies : PokemonSpecies
	{
#nullable enable
		private static WatchogSpecies? _instance = null;
#nullable restore
        public static WatchogSpecies Instance => _instance ?? (_instance = new WatchogSpecies());

		#region WatchogSpecies Constructor
		public WatchogSpecies() : base(
			505,
			"Watchog",
			Normal.Instance,
			1.1,
			27.0,
			new PokemonStats(
				60, // HPs
				85, 69, // Attack & Defense
				60, 69, // Spacial Attack & Defense
				77 // Speed
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Slam",
				"Sand-Attack",
				"Tackle",
				"Leer",
				"Bite",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Hypnosis",
				"Double-Team",
				"Confuse-Ray",
				"Light-Screen",
				"Focus-Energy",
				"Bide",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Hyper-Fang",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Detect",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Signal-Beam",
				"Covet",
				"Shock-Wave",
				"Fling",
				"Last-Resort",
				"Aqua-Tail",
				"Seed-Bomb",
				"Focus-Blast",
				"Giga-Impact",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Gunk-Shot",
				"Grass-Knot",
				"After-You",
				"Round",
				"Retaliate",
				"Work-Up",
				"Rototiller",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}
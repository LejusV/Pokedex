using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Bellsprout Species to store common natural stats of all Bellsprouts
	#region BellsproutSpecies
	public class BellsproutSpecies : PokemonSpecies
	{
#nullable enable
		private static BellsproutSpecies? _instance = null;
#nullable restore
        public static BellsproutSpecies Instance => _instance ?? (_instance = new BellsproutSpecies());

		#region BellsproutSpecies Constructor
		public BellsproutSpecies() : base(
			69,
			"Bellsprout",
			Grass.Instance, Poison.Instance,
			0.7,
			4.0,
			new PokemonStats(
				50, // HPs
				75, 35, // Attack & Defense
				70, 30, // Spacial Attack & Defense
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
				"Swords-Dance",
				"Cut",
				"Bind",
				"Slam",
				"Vine-Whip",
				"Wrap",
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Mega-Drain",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Leech-Life",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Encore",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Knock-Off",
				"Secret-Power",
				"Weather-Ball",
				"Tickle",
				"Bullet-Seed",
				"Magical-Leaf",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Worry-Seed",
				"Sucker-Punch",
				"Poison-Jab",
				"Seed-Bomb",
				"Energy-Ball",
				"Power-Whip",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Acid-Spray",
				"Round",
				"Clear-Smog",
				"Belch",
				"Confide",
				"Infestation",
				"Strength-Sap"
			};
		}
		#endregion
	}
	#endregion
}
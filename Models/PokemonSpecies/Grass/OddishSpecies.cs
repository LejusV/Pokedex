using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Oddish Species to store common natural stats of all Oddishs
	#region OddishSpecies
	public class OddishSpecies : PokemonSpecies
	{
#nullable enable
		private static OddishSpecies? _instance = null;
#nullable restore
        public static OddishSpecies Instance => _instance ?? (_instance = new OddishSpecies());

		#region OddishSpecies Constructor
		public OddishSpecies() : base(
			43,
			"Oddish",
			Grass.Instance, Poison.Instance,
			0.5,
			5.4,
			new PokemonStats(
				45, // HPs
				50, 55, // Attack & Defense
				75, 65, // Spacial Attack & Defense
				30 // Speed
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
				"Take-Down",
				"Double-Edge",
				"Acid",
				"Absorb",
				"Mega-Drain",
				"Growth",
				"Razor-Leaf",
				"Solar-Beam",
				"Poison-Powder",
				"Stun-Spore",
				"Sleep-Powder",
				"Petal-Dance",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Flail",
				"Protect",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Sweet-Scent",
				"Synthesis",
				"Moonlight",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Secret-Power",
				"Teeter-Dance",
				"Tickle",
				"Bullet-Seed",
				"Natural-Gift",
				"Gastro-Acid",
				"Lucky-Chant",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"After-You",
				"Round",
				"Grassy-Terrain",
				"Moonblast",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Strength-Sap"
			};
		}
		#endregion
	}
	#endregion
}
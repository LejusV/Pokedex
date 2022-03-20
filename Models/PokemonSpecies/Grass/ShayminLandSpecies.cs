using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Shaymin-Land Species to store common natural stats of all Shaymin-Lands
	#region Shaymin-LandSpecies
	public class ShayminLandSpecies : PokemonSpecies
	{
#nullable enable
		private static ShayminLandSpecies? _instance = null;
#nullable restore
        public static ShayminLandSpecies Instance => _instance ?? (_instance = new ShayminLandSpecies());

		#region Shaymin-LandSpecies Constructor
		public ShayminLandSpecies() : base(
			492,
			"Shaymin-Land",
			Grass.Instance,
			0.2,
			2.1,
			new PokemonStats(
				100, // HPs
				100, 100, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				100 // Speed
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
				"Headbutt",
				"Hyper-Beam",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Defense-Curl",
				"Swift",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Nature-Power",
				"Endeavor",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Bullet-Seed",
				"Covet",
				"Magical-Leaf",
				"Healing-Wish",
				"Natural-Gift",
				"Lucky-Chant",
				"Last-Resort",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Grass-Knot",
				"Seed-Flare",
				"Round",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Petilil Species to store common natural stats of all Petilils
	#region PetililSpecies
	public class PetililSpecies : PokemonSpecies
	{
#nullable enable
		private static PetililSpecies? _instance = null;
#nullable restore
        public static PetililSpecies Instance => _instance ?? (_instance = new PetililSpecies());

		#region PetililSpecies Constructor
		public PetililSpecies() : base(
			548,
			"Petilil",
			Grass.Instance,
			0.5,
			6.6,
			new PokemonStats(
				45, // HPs
				35, 50, // Attack & Defense
				70, 50, // Spacial Attack & Defense
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
				"Cut",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Stun-Spore",
				"Sleep-Powder",
				"Toxic",
				"Double-Team",
				"Bide",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Encore",
				"Sweet-Scent",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Nature-Power",
				"Helping-Hand",
				"Ingrain",
				"Secret-Power",
				"Aromatherapy",
				"Grass-Whistle",
				"Covet",
				"Magical-Leaf",
				"Healing-Wish",
				"Natural-Gift",
				"Worry-Seed",
				"Seed-Bomb",
				"Energy-Ball",
				"Leaf-Storm",
				"Grass-Knot",
				"Entrainment",
				"After-You",
				"Round",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
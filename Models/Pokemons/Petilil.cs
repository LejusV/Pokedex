using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Petilil Species to store common natural stats of all Petilils
	#region SpeciesPetilil
	public class SpeciesPetilil : PokemonSpecies
	{
#nullable enable
		private static SpeciesPetilil? _instance = null;
#nullable restore
        public static SpeciesPetilil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPetilil();
                }
                return _instance;
            }
        }

		#region SpeciesPetilil Constructor
		public SpeciesPetilil() : base(
			"Petilil",
			0.5,
			6.6,
			45, // HPs
			35, 50, // Attack & Defense
			70, 50, // Special Attack & Defense
			30		
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

	//Petilil PokemonInstance Class
	#region Petilil
	public class PetililInstance : PokemonInstance
	{
		#region Petilil Constructors
		/// <summary>
		/// Petilil Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PetililInstance(string nickname, int level)
		: base(
				548,
				SpeciesPetilil.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Petilil Builder only waiting for a Level
		/// </summary>
		public PetililInstance(int level)
		: base(
				548,
				SpeciesPetilil.Instance, // PokemonInstance Species
				"Petilil", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Petilil Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Petilil() : base(
			548,
			SpeciesPetilil.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
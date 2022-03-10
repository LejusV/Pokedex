using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Wobbuffet Species to store common natural stats of all Wobbuffets
	#region SpeciesWobbuffet
	public class SpeciesWobbuffet : PokemonSpecies
	{
#nullable enable
		private static SpeciesWobbuffet? _instance = null;
#nullable restore
        public static SpeciesWobbuffet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWobbuffet();
                }
                return _instance;
            }
        }

		#region SpeciesWobbuffet Constructor
		public SpeciesWobbuffet() : base(
			"Wobbuffet",
			1.3,
			28.5,
			190, // HPs
			33, 58, // Attack & Defense
			33, 58, // Special Attack & Defense
			33		
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
				"Counter",
				"Destiny-Bond",
				"Safeguard",
				"Mirror-Coat"
			};
		}
		#endregion
	}
	#endregion

	//Wobbuffet PokemonInstance Class
	#region Wobbuffet
	public class WobbuffetInstance : PokemonInstance
	{
		#region Wobbuffet Constructors
		/// <summary>
		/// Wobbuffet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WobbuffetInstance(string nickname, int level)
		: base(
				202,
				SpeciesWobbuffet.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wobbuffet Builder only waiting for a Level
		/// </summary>
		public WobbuffetInstance(int level)
		: base(
				202,
				SpeciesWobbuffet.Instance, // PokemonInstance Species
				"Wobbuffet", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wobbuffet Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Wobbuffet() : base(
			202,
			SpeciesWobbuffet.Instance, // PokemonInstance Species
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
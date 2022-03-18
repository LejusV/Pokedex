using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Kakuna Species to store common natural stats of all Kakunas
	#region SpeciesKakuna
	public class SpeciesKakuna : PokemonSpecies
	{
#nullable enable
		private static SpeciesKakuna? _instance = null;
#nullable restore
        public static SpeciesKakuna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKakuna();
                }
                return _instance;
            }
        }

		#region SpeciesKakuna Constructor
		public SpeciesKakuna() : base(
			14,
			"Kakuna",
			0.6,
			10.0,
			45, // HPs
			25, 50, // Attack & Defense
			25, 25, // Special Attack & Defense
			35		
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
				"String-Shot",
				"Harden",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Kakuna PokemonInstance Class
	#region Kakuna
	public class KakunaInstance : PokemonInstance
	{
		#region Kakuna Constructors
		/// <summary>
		/// Kakuna Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KakunaInstance(string nickname, int level)
		: base(
				SpeciesKakuna.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kakuna Builder only waiting for a Level
		/// </summary>
		public KakunaInstance(int level)
		: base(
				SpeciesKakuna.Instance, // PokemonInstance Species
				"Kakuna", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kakuna Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KakunaInstance() : base(
			SpeciesKakuna.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
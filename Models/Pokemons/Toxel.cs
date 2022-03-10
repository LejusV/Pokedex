using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Toxel Species to store common natural stats of all Toxels
	#region SpeciesToxel
	public class SpeciesToxel : PokemonSpecies
	{
#nullable enable
		private static SpeciesToxel? _instance = null;
#nullable restore
        public static SpeciesToxel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesToxel();
                }
                return _instance;
            }
        }

		#region SpeciesToxel Constructor
		public SpeciesToxel() : base(
			"Toxel",
			0.4,
			11.0,
			40, // HPs
			38, 35, // Attack & Defense
			54, 35, // Special Attack & Defense
			40		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Toxel PokemonInstance Class
	#region Toxel
	public class ToxelInstance : PokemonInstance
	{
		#region Toxel Constructors
		/// <summary>
		/// Toxel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ToxelInstance(string nickname, int level)
		: base(
				848,
				SpeciesToxel.Instance, // Pokemon Species
				nickname, level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxel Builder only waiting for a Level
		/// </summary>
		public ToxelInstance(int level)
		: base(
				848,
				SpeciesToxel.Instance, // PokemonInstance Species
				"Toxel", level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxel Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Toxel() : base(
			848,
			SpeciesToxel.Instance, // PokemonInstance Species
			Electric.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
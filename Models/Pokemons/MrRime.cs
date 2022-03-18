using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mr-Rime Species to store common natural stats of all Mr-Rimes
	#region SpeciesMr-Rime
	public class SpeciesMrRime : PokemonSpecies
	{
#nullable enable
		private static SpeciesMrRime? _instance = null;
#nullable restore
        public static SpeciesMrRime Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMrRime();
                }
                return _instance;
            }
        }

		#region SpeciesMr-Rime Constructor
		public SpeciesMrRime() : base(
			866,
			"Mr-Rime",
			1.5,
			58.2,
			80, // HPs
			85, 75, // Attack & Defense
			110, 100, // Special Attack & Defense
			70		
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

	//Mr-Rime PokemonInstance Class
	#region Mr-Rime
	public class MrRimeInstance : PokemonInstance
	{
		#region Mr-Rime Constructors
		/// <summary>
		/// Mr-Rime Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MrRimeInstance(string nickname, int level)
		: base(
				SpeciesMrRime.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Rime Builder only waiting for a Level
		/// </summary>
		public MrRimeInstance(int level)
		: base(
				SpeciesMrRime.Instance, // PokemonInstance Species
				"Mr-Rime", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mr-Rime Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MrRimeInstance() : base(
			SpeciesMrRime.Instance, // PokemonInstance Species
			Ice.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
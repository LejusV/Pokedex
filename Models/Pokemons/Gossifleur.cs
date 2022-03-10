using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gossifleur Species to store common natural stats of all Gossifleurs
	#region SpeciesGossifleur
	public class SpeciesGossifleur : PokemonSpecies
	{
#nullable enable
		private static SpeciesGossifleur? _instance = null;
#nullable restore
        public static SpeciesGossifleur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGossifleur();
                }
                return _instance;
            }
        }

		#region SpeciesGossifleur Constructor
		public SpeciesGossifleur() : base(
			"Gossifleur",
			0.4,
			2.2,
			40, // HPs
			40, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			10		
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

	//Gossifleur PokemonInstance Class
	#region Gossifleur
	public class GossifleurInstance : PokemonInstance
	{
		#region Gossifleur Constructors
		/// <summary>
		/// Gossifleur Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GossifleurInstance(string nickname, int level)
		: base(
				829,
				SpeciesGossifleur.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gossifleur Builder only waiting for a Level
		/// </summary>
		public GossifleurInstance(int level)
		: base(
				829,
				SpeciesGossifleur.Instance, // PokemonInstance Species
				"Gossifleur", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gossifleur Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Gossifleur() : base(
			829,
			SpeciesGossifleur.Instance, // PokemonInstance Species
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
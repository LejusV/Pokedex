using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Eternatus Species to store common natural stats of all Eternatuss
	#region SpeciesEternatus
	public class SpeciesEternatus : PokemonSpecies
	{
#nullable enable
		private static SpeciesEternatus? _instance = null;
#nullable restore
        public static SpeciesEternatus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesEternatus();
                }
                return _instance;
            }
        }

		#region SpeciesEternatus Constructor
		public SpeciesEternatus() : base(
			"Eternatus",
			20.0,
			950.0,
			140, // HPs
			85, 95, // Attack & Defense
			145, 95, // Special Attack & Defense
			130		
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

	//Eternatus PokemonInstance Class
	#region Eternatus
	public class EternatusInstance : PokemonInstance
	{
		#region Eternatus Constructors
		/// <summary>
		/// Eternatus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public EternatusInstance(string nickname, int level)
		: base(
				890,
				SpeciesEternatus.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eternatus Builder only waiting for a Level
		/// </summary>
		public EternatusInstance(int level)
		: base(
				890,
				SpeciesEternatus.Instance, // PokemonInstance Species
				"Eternatus", level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eternatus Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Eternatus() : base(
			890,
			SpeciesEternatus.Instance, // PokemonInstance Species
			Poison.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lickilicky PokemonInstance Class
	#region Lickilicky
	public class Lickilicky : PokemonInstance
	{
		#region Lickilicky Constructors
		/// <summary>
		/// Lickilicky Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lickilicky(string nickname, int level)
		: base(
				LickilickySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickilicky Constructor only waiting for a Level
		/// </summary>
		public Lickilicky(int level)
		: this( "Lickilicky", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickilicky Constructor waiting for no params
		/// </summary>
		/*
		public Lickilicky() : this( "Lickilicky", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
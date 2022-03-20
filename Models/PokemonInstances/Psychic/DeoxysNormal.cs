using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Deoxys-Normal PokemonInstance Class
	#region Deoxys-Normal
	public class DeoxysNormal : PokemonInstance
	{
		#region Deoxys-Normal Constructors
		/// <summary>
		/// Deoxys-Normal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DeoxysNormal(string nickname, int level)
		: base(
				DeoxysNormalSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deoxys-Normal Constructor only waiting for a Level
		/// </summary>
		public DeoxysNormal(int level)
		: this( "Deoxys-Normal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deoxys-Normal Constructor waiting for no params
		/// </summary>
		/*
		public DeoxysNormal() : this( "Deoxys-Normal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
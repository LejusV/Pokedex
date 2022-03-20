using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Incineroar PokemonInstance Class
	#region Incineroar
	public class Incineroar : PokemonInstance
	{
		#region Incineroar Constructors
		/// <summary>
		/// Incineroar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Incineroar(string nickname, int level)
		: base(
				IncineroarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Incineroar Constructor only waiting for a Level
		/// </summary>
		public Incineroar(int level)
		: this( "Incineroar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Incineroar Constructor waiting for no params
		/// </summary>
		/*
		public Incineroar() : this( "Incineroar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
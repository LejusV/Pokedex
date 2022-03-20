using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Regidrago PokemonInstance Class
	#region Regidrago
	public class Regidrago : PokemonInstance
	{
		#region Regidrago Constructors
		/// <summary>
		/// Regidrago Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Regidrago(string nickname, int level)
		: base(
				RegidragoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regidrago Constructor only waiting for a Level
		/// </summary>
		public Regidrago(int level)
		: this( "Regidrago", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regidrago Constructor waiting for no params
		/// </summary>
		/*
		public Regidrago() : this( "Regidrago", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
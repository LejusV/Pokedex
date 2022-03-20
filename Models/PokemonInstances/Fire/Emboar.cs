using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Emboar PokemonInstance Class
	#region Emboar
	public class Emboar : PokemonInstance
	{
		#region Emboar Constructors
		/// <summary>
		/// Emboar Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Emboar(string nickname, int level)
		: base(
				EmboarSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emboar Constructor only waiting for a Level
		/// </summary>
		public Emboar(int level)
		: this( "Emboar", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Emboar Constructor waiting for no params
		/// </summary>
		/*
		public Emboar() : this( "Emboar", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
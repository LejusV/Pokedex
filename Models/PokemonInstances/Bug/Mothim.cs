using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mothim PokemonInstance Class
	#region Mothim
	public class Mothim : PokemonInstance
	{
		#region Mothim Constructors
		/// <summary>
		/// Mothim Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mothim(string nickname, int level)
		: base(
				MothimSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mothim Constructor only waiting for a Level
		/// </summary>
		public Mothim(int level)
		: this( "Mothim", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mothim Constructor waiting for no params
		/// </summary>
		/*
		public Mothim() : this( "Mothim", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
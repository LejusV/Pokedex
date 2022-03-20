using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Drifblim PokemonInstance Class
	#region Drifblim
	public class Drifblim : PokemonInstance
	{
		#region Drifblim Constructors
		/// <summary>
		/// Drifblim Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Drifblim(string nickname, int level)
		: base(
				DrifblimSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifblim Constructor only waiting for a Level
		/// </summary>
		public Drifblim(int level)
		: this( "Drifblim", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drifblim Constructor waiting for no params
		/// </summary>
		/*
		public Drifblim() : this( "Drifblim", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
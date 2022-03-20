using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Eternatus PokemonInstance Class
	#region Eternatus
	public class Eternatus : PokemonInstance
	{
		#region Eternatus Constructors
		/// <summary>
		/// Eternatus Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Eternatus(string nickname, int level)
		: base(
				EternatusSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eternatus Constructor only waiting for a Level
		/// </summary>
		public Eternatus(int level)
		: this( "Eternatus", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eternatus Constructor waiting for no params
		/// </summary>
		/*
		public Eternatus() : this( "Eternatus", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
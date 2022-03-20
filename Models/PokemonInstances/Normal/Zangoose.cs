using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Zangoose PokemonInstance Class
	#region Zangoose
	public class Zangoose : PokemonInstance
	{
		#region Zangoose Constructors
		/// <summary>
		/// Zangoose Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Zangoose(string nickname, int level)
		: base(
				ZangooseSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zangoose Constructor only waiting for a Level
		/// </summary>
		public Zangoose(int level)
		: this( "Zangoose", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zangoose Constructor waiting for no params
		/// </summary>
		/*
		public Zangoose() : this( "Zangoose", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
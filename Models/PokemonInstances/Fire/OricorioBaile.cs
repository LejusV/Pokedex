using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Oricorio-Baile PokemonInstance Class
	#region Oricorio-Baile
	public class OricorioBaile : PokemonInstance
	{
		#region Oricorio-Baile Constructors
		/// <summary>
		/// Oricorio-Baile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OricorioBaile(string nickname, int level)
		: base(
				OricorioBaileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oricorio-Baile Constructor only waiting for a Level
		/// </summary>
		public OricorioBaile(int level)
		: this( "Oricorio-Baile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oricorio-Baile Constructor waiting for no params
		/// </summary>
		/*
		public OricorioBaile() : this( "Oricorio-Baile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}
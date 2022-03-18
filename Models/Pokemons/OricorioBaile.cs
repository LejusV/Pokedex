using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Oricorio-Baile Species to store common natural stats of all Oricorio-Bailes
	#region SpeciesOricorio-Baile
	public class SpeciesOricorioBaile : PokemonSpecies
	{
#nullable enable
		private static SpeciesOricorioBaile? _instance = null;
#nullable restore
        public static SpeciesOricorioBaile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesOricorioBaile();
                }
                return _instance;
            }
        }

		#region SpeciesOricorio-Baile Constructor
		public SpeciesOricorioBaile() : base(
			741,
			"Oricorio-Baile",
			0.6,
			3.4,
			75, // HPs
			70, 70, // Attack & Defense
			98, 70, // Special Attack & Defense
			93		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Pound",
				"Double-Slap",
				"Swords-Dance",
				"Fly",
				"Growl",
				"Peck",
				"Toxic",
				"Agility",
				"Double-Team",
				"Mirror-Move",
				"Rest",
				"Substitute",
				"Protect",
				"Sandstorm",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Hidden-Power",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Feather-Dance",
				"Teeter-Dance",
				"Air-Cutter",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Embargo",
				"Air-Slash",
				"Captivate",
				"Round",
				"Quash",
				"Acrobatics",
				"Work-Up",
				"Hurricane",
				"Confide",
				"Revelation-Dance"
			};
		}
		#endregion
	}
	#endregion

	//Oricorio-Baile PokemonInstance Class
	#region Oricorio-Baile
	public class OricorioBaileInstance : PokemonInstance
	{
		#region Oricorio-Baile Constructors
		/// <summary>
		/// Oricorio-Baile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public OricorioBaileInstance(string nickname, int level)
		: base(
				SpeciesOricorioBaile.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oricorio-Baile Builder only waiting for a Level
		/// </summary>
		public OricorioBaileInstance(int level)
		: base(
				SpeciesOricorioBaile.Instance, // PokemonInstance Species
				"Oricorio-Baile", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Oricorio-Baile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public OricorioBaileInstance() : base(
			SpeciesOricorioBaile.Instance, // PokemonInstance Species
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
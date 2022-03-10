using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Keldeo-Ordinary Species to store common natural stats of all Keldeo-Ordinarys
	#region SpeciesKeldeo-Ordinary
	public class SpeciesKeldeoOrdinary : PokemonSpecies
	{
#nullable enable
		private static SpeciesKeldeoOrdinary? _instance = null;
#nullable restore
        public static SpeciesKeldeoOrdinary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesKeldeoOrdinary();
                }
                return _instance;
            }
        }

		#region SpeciesKeldeo-Ordinary Constructor
		public SpeciesKeldeoOrdinary() : base(
			"Keldeo-Ordinary",
			1.4,
			48.5,
			91, // HPs
			72, 90, // Attack & Defense
			129, 90, // Special Attack & Defense
			108		
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
				"Swords-Dance",
				"Cut",
				"Double-Kick",
				"Take-Down",
				"Leer",
				"Roar",
				"Hydro-Pump",
				"Surf",
				"Bubble-Beam",
				"Hyper-Beam",
				"Strength",
				"Toxic",
				"Double-Team",
				"Reflect",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"False-Swipe",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Endeavor",
				"Secret-Power",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Calm-Mind",
				"Water-Pulse",
				"Close-Combat",
				"Last-Resort",
				"Poison-Jab",
				"Aqua-Tail",
				"X-Scissor",
				"Focus-Blast",
				"Giga-Impact",
				"Stone-Edge",
				"Aqua-Jet",
				"Round",
				"Quick-Guard",
				"Scald",
				"Retaliate",
				"Work-Up",
				"Sacred-Sword",
				"Secret-Sword",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Keldeo-Ordinary PokemonInstance Class
	#region Keldeo-Ordinary
	public class KeldeoOrdinaryInstance : PokemonInstance
	{
		#region Keldeo-Ordinary Constructors
		/// <summary>
		/// Keldeo-Ordinary Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public KeldeoOrdinaryInstance(string nickname, int level)
		: base(
				647,
				SpeciesKeldeoOrdinary.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Keldeo-Ordinary Builder only waiting for a Level
		/// </summary>
		public KeldeoOrdinaryInstance(int level)
		: base(
				647,
				SpeciesKeldeoOrdinary.Instance, // PokemonInstance Species
				"Keldeo-Ordinary", level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Keldeo-Ordinary Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public KeldeoOrdinary() : base(
			647,
			SpeciesKeldeoOrdinary.Instance, // PokemonInstance Species
			Water.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ariados Species to store common natural stats of all Ariadoss
	#region SpeciesAriados
	public class SpeciesAriados : PokemonSpecies
	{
#nullable enable
		private static SpeciesAriados? _instance = null;
#nullable restore
        public static SpeciesAriados Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAriados();
                }
                return _instance;
            }
        }

		#region SpeciesAriados Constructor
		public SpeciesAriados() : base(
			"Ariados",
			1.1,
			33.5,
			70, // HPs
			90, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			40		
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
				"Body-Slam",
				"Double-Edge",
				"Poison-Sting",
				"Pin-Missile",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Dig",
				"Toxic",
				"Psychic",
				"Agility",
				"Night-Shade",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Constrict",
				"Leech-Life",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Spider-Web",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Facade",
				"Secret-Power",
				"Signal-Beam",
				"Bounce",
				"Natural-Gift",
				"Sucker-Punch",
				"Poison-Jab",
				"X-Scissor",
				"Giga-Impact",
				"Shadow-Sneak",
				"Cross-Poison",
				"Captivate",
				"Bug-Bite",
				"Hone-Claws",
				"Venoshock",
				"Foul-Play",
				"Round",
				"Struggle-Bug",
				"Electroweb",
				"Sticky-Web",
				"Fell-Stinger",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Toxic-Thread",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Ariados PokemonInstance Class
	#region Ariados
	public class AriadosInstance : PokemonInstance
	{
		#region Ariados Constructors
		/// <summary>
		/// Ariados Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AriadosInstance(string nickname, int level)
		: base(
				168,
				SpeciesAriados.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ariados Builder only waiting for a Level
		/// </summary>
		public AriadosInstance(int level)
		: base(
				168,
				SpeciesAriados.Instance, // PokemonInstance Species
				"Ariados", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ariados Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ariados() : base(
			168,
			SpeciesAriados.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}
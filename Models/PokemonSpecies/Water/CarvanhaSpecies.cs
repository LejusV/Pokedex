using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Carvanha Species to store common natural stats of all Carvanhas
	#region CarvanhaSpecies
	public class CarvanhaSpecies : PokemonSpecies
	{
#nullable enable
		private static CarvanhaSpecies? _instance = null;
#nullable restore
        public static CarvanhaSpecies Instance => _instance ?? (_instance = new CarvanhaSpecies());

		#region CarvanhaSpecies Constructor
		public CarvanhaSpecies() : base(
			318,
			"Carvanha",
			Water.Instance, Dark.Instance,
			0.8,
			20.8,
			new PokemonStats(
				45, // HPs
				90, 20, // Attack & Defense
				65, 20, // Spacial Attack & Defense
				65 // Speed
			)			
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
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Swift",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Dive",
				"Poison-Fang",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Dark-Pulse",
				"Ice-Fang",
				"Zen-Headbutt",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Snarl",
				"Confide",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion
}
using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ponyta Species to store common natural stats of all Ponytas
	#region PonytaSpecies
	public class PonytaSpecies : PokemonSpecies
	{
#nullable enable
		private static PonytaSpecies? _instance = null;
#nullable restore
        public static PonytaSpecies Instance => _instance ?? (_instance = new PonytaSpecies());

		#region PonytaSpecies Constructor
		public PonytaSpecies() : base(
			77,
			"Ponyta",
			Fire.Instance,
			1.0,
			30.0,
			new PokemonStats(
				50, // HPs
				85, 55, // Attack & Defense
				65, 65, // Spacial Attack & Defense
				90 // Speed
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
				"Stomp",
				"Double-Kick",
				"Headbutt",
				"Horn-Drill",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Ember",
				"Flamethrower",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Hypnosis",
				"Agility",
				"Quick-Attack",
				"Rage",
				"Mimic",
				"Double-Team",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Curse",
				"Protect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Morning-Sun",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Bounce",
				"Natural-Gift",
				"Flare-Blitz",
				"Captivate",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Ally-Switch",
				"Incinerate",
				"Inferno",
				"Wild-Charge",
				"Confide",
				"High-Horsepower"
			};
		}
		#endregion
	}
	#endregion
}
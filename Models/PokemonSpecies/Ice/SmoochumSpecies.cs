using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Smoochum Species to store common natural stats of all Smoochums
	#region SmoochumSpecies
	public class SmoochumSpecies : PokemonSpecies
	{
#nullable enable
		private static SmoochumSpecies? _instance = null;
#nullable restore
        public static SmoochumSpecies Instance => _instance ?? (_instance = new SmoochumSpecies());

		#region SmoochumSpecies Constructor
		public SmoochumSpecies() : base(
			238,
			"Smoochum",
			Ice.Instance, Psychic.Instance,
			0.4,
			6.0,
			new PokemonStats(
				45, // HPs
				30, 15, // Attack & Defense
				85, 65, // Spacial Attack & Defense
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
				"Pound",
				"Mega-Punch",
				"Ice-Punch",
				"Mega-Kick",
				"Body-Slam",
				"Double-Edge",
				"Sing",
				"Ice-Beam",
				"Blizzard",
				"Counter",
				"Seismic-Toss",
				"Toxic",
				"Confusion",
				"Psychic",
				"Meditate",
				"Mimic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Lick",
				"Dream-Eater",
				"Lovely-Kiss",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Powder-Snow",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Perish-Song",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Shadow-Ball",
				"Fake-Out",
				"Uproar",
				"Hail",
				"Facade",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Fake-Tears",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Water-Pulse",
				"Miracle-Eye",
				"Wake-Up-Slap",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Lucky-Chant",
				"Copycat",
				"Nasty-Plot",
				"Avalanche",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Magic-Room",
				"Round",
				"Echoed-Voice",
				"Frost-Breath",
				"Heart-Stamp",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion
}
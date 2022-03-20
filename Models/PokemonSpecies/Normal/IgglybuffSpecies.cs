using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Igglybuff Species to store common natural stats of all Igglybuffs
	#region IgglybuffSpecies
	public class IgglybuffSpecies : PokemonSpecies
	{
#nullable enable
		private static IgglybuffSpecies? _instance = null;
#nullable restore
        public static IgglybuffSpecies Instance => _instance ?? (_instance = new IgglybuffSpecies());

		#region IgglybuffSpecies Constructor
		public IgglybuffSpecies() : base(
			174,
			"Igglybuff",
			Normal.Instance, Fairy.Instance,
			0.3,
			1.0,
			new PokemonStats(
				90, // HPs
				30, 15, // Attack & Defense
				40, 20, // Spacial Attack & Defense
				15 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Sing",
				"Flamethrower",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Dig",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Curse",
				"Protect",
				"Feint-Attack",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Perish-Song",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Helping-Hand",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Punishment",
				"Last-Resort",
				"Captivate",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Work-Up",
				"Wild-Charge",
				"Misty-Terrain",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}
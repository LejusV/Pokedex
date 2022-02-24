using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Smoochum Specie to store common natural stats of every {'abilities': ['oblivious', 'forewarn', 'hydration'], 'base_experience': 61, 'height': 4, 'id': 238, 'moves': ['pound', 'mega-punch', 'ice-punch', 'mega-kick', 'body-slam', 'double-edge', 'sing', 'ice-beam', 'blizzard', 'counter', 'seismic-toss', 'toxic', 'confusion', 'psychic', 'meditate', 'mimic', 'double-team', 'light-screen', 'reflect', 'metronome', 'lick', 'dream-eater', 'lovely-kiss', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'powder-snow', 'protect', 'sweet-kiss', 'mud-slap', 'perish-song', 'icy-wind', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'dynamic-punch', 'sweet-scent', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'fake-out', 'uproar', 'hail', 'facade', 'helping-hand', 'trick', 'role-play', 'wish', 'magic-coat', 'recycle', 'skill-swap', 'secret-power', 'fake-tears', 'signal-beam', 'covet', 'calm-mind', 'water-pulse', 'miracle-eye', 'wake-up-slap', 'natural-gift', 'payback', 'fling', 'lucky-chant', 'copycat', 'nasty-plot', 'avalanche', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'psyshock', 'magic-room', 'round', 'echoed-voice', 'frost-breath', 'heart-stamp', 'confide', 'aurora-veil'], 'name': 'smoochum', 'stats': {'hp': 45, 'attack': 30, 'defense': 15, 'special-attack': 85, 'special-defense': 65, 'speed': 65}, 'types': ['ice', 'psychic'], 'weight': 60, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 8, 'capture_rate': 45, 'color': 'pink', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ムチュール', 'roomaji': 'Muchul', 'ko': '뽀뽀라', 'zh-Hant': '迷唇娃', 'fr': 'Lippouti', 'de': 'Kussilla', 'es': 'Smoochum', 'it': 'Smoochum', 'en': 'Smoochum', 'ja': 'ムチュール', 'zh-Hans': '迷唇娃'}, 'genera': {'ja-Hrkt': 'くちづけポケモン', 'ko': '뽀뽀포켓몬', 'zh-Hant': '親吻寶可夢', 'fr': 'Pokémon Bisou', 'de': 'Kuss', 'es': 'Pokémon Beso', 'it': 'Pokémon Bacio', 'en': 'Kiss Pokémon', 'ja': 'くちづけポケモン', 'zh-Hans': '亲吻宝可梦'}}
	public class SpecieSmoochum : PokemonSpecie
	{
#nullable enable
		private static SpecieSmoochum? _instance = null;
#nullable restore
        public static SpecieSmoochum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSmoochum();
                }
                return _instance;
            }
        }

		public SpecieSmoochum() : base(
			"Smoochum",
			45, // HPs
			30, 15, // Attack & Defense
			85, 65, // Special Attack & Defense
			65			
		) {}
	}


	//Smoochum Pokemon Class
	public class Smoochum : Pokemon
	{

		public Smoochum(string nickname, int level)
		: base(
				238,
				SpecieSmoochum.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Smoochum() : base(
			238,
			SpecieSmoochum.Instance, // Pokemon Specie
			Ice.Instance, Psychic.Instance			
		) {}
	}
}